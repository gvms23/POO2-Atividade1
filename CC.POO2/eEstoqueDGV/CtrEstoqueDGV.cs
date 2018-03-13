using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CC.POO2.eEstoqueDGV;
using System.Threading;

namespace CC.POO2
{
    /// <summary>
    /// Implemente o layout ao lado utilizando os componentes vistos durante a aula. Para armazenar temporariamente utilize componente DataGridView. 
    /// <para>Adicione também um controle básico de estoque.Todas vez que um produto for adicionado, subtrair a quantidade desejada pelo que está no estoque (se possível).</para>
    /// </summary>
    /// <seealso cref="UserControl" />
    public partial class CtrEstoqueDGV : UserControl
    {
        List<Cliente> listaClientes;
        List<Produto> listaProdutos;
        List<Estoque> listaOperacoes = new List<Estoque>();
        List<DGVItem> listaItensDGV = new List<DGVItem>();
        int quantidadeGlobal = 10;

        public CtrEstoqueDGV()
        {
            InitializeComponent();
        }

        private void CtrEstoqueDGV_Load(object sender, EventArgs e)
        {
            CarregarValores();
            TxtQuantidadeProduto.Text = quantidadeGlobal.ToString();

            AjustarTamanhoColunasInicio();
            new Estoque().ResetID();
        }

        private void AjustarTamanhoColunasInicio()
        {
            //Crio um objeto
            listaOperacoes.Add(new Estoque
            {
                Cliente = new Cliente { Nome = "T", ID = 0 },
                Operacao = EstoqueTipoOperacao.Venda,
                Produto = new Produto { Descricao = "T", ID = 0, Valor = 0 },
                Valor = 0,
                Quantidade = 1
            });

            //atualizo o DGV com a lista
            AtualizaDGV();

            //Forço a atualização das colunas do DGV
            DgvOperacoes.DataBindingComplete += (o, _) =>
            {
                if (o is DataGridView dataGridView)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };

            //Limpo a lista
            listaOperacoes.Clear();

            //atualizo novamente o DGV com a lista vazia, mantendo os headers
            AtualizaDGV();
        }

        /// <summary>
        /// Assina as listas de cliente e produto, criando 10 objetos em cada um.
        /// </summary>
        private void CarregarValores()
        {
            listaClientes = new List<Cliente>();
            listaProdutos = new List<Produto>();

            for (var i = 1; i <= 10; i++)
            {
                listaProdutos.Add(new Produto
                {
                    ID = i,
                    Descricao = $"Produto {i}",
                    Valor = i * 10
                });
                listaClientes.Add(new Cliente
                {
                    ID = i,
                    Nome = $"Cliente {i}",
                });
            }

            CboCliente.DataSource = listaClientes.ToList();
            CboProduto.DataSource = listaProdutos.ToList();

            CboCliente.DisplayMember = "Nome";
            CboCliente.ValueMember = "ID";

            CboProduto.DisplayMember = "Descricao";
            CboProduto.ValueMember = "ID";
        }

        private void BtnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (CboCliente.SelectedItem == null || CboProduto.SelectedItem == null || TxtQuantidadeProduto.Text == null)
                    throw new Exception("Preencha o cliente, o produto e a quantidade.");

                if (!double.TryParse(TxtQuantidadeProduto.Text, out double quantidade))
                    throw new Exception("Preencha somente números na quantidade.");

                if (Math.Abs(quantidade) < 0.001) throw new Exception("A quantidade deve ser maior que zero.");

                var cliente = listaClientes.FirstOrDefault(x => x.ID == (int)CboCliente.SelectedValue);
                var produto = listaProdutos.FirstOrDefault(x => x.ID == (int)CboProduto.SelectedValue);

                listaOperacoes.Add(new Estoque
                {
                    Cliente = cliente,
                    Operacao = EstoqueTipoOperacao.Venda,
                    Quantidade = quantidade,
                    Produto = produto,
                    Valor = Convert.ToDecimal(produto.Valor) * Convert.ToDecimal(quantidade)
                });

                CarregarValores();
                AtualizaDGV();

                TxtQuantidadeProduto.Text = (quantidadeGlobal += 10).ToString();

                CboCliente.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Atualiza o DGV Operações com base na listaOperacoes e ajusta o tamanho do DGV.
        /// </summary>
        public void AtualizaDGV()
        {
            listaItensDGV = new List<DGVItem>();
            listaOperacoes
                    .ToList()
                    .ForEach(x => listaItensDGV.Add(new DGVItem(x)));

            DgvOperacoes.DataSource = listaItensDGV.ToList();

            Task.Factory.StartNew(() =>
            {
                Invoke((MethodInvoker)delegate
                {
                    //Ajuste largura
                    DgvOperacoes.DataBindingComplete += (o, _) =>
                    {
                        if (o is DataGridView dataGridView)
                        {
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    };
                });
                Thread.Sleep(50);
            });

            AtualizarSomas();
        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCliente.SelectedItem == null) return;

            Task.Factory.StartNew(() =>
            {
                Invoke((MethodInvoker)delegate
                {
                    LblClienteEscolhido.Text = $"Cliente Escolhido: {(CboCliente.SelectedItem as Cliente).ID} - {(CboCliente.SelectedItem as Cliente).Nome}";
                });
                Thread.Sleep(100);
            });


        }

        private void BtnLimparLista_Click(object sender, EventArgs e)
        {
            listaOperacoes.Clear();

            AtualizaDGV();
            CboCliente.Enabled = true;
            
            //Reset
            quantidadeGlobal = 10;
            TxtQuantidadeProduto.Text = quantidadeGlobal.ToString();
            new Estoque().ResetID();
        }

        private void DgvOperacoes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (DgvOperacoes.RowCount > 0)
                BtnLimparLista.Enabled = true;
            else
                BtnLimparLista.Enabled = false;
        }

        private void BtnRemoverProdutoDGV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linhaSelecionada in DgvOperacoes.SelectedRows)
            {
                var item = (DGVItem)linhaSelecionada.DataBoundItem;
                listaOperacoes.ToList().ForEach(delegate (Estoque estoqueItem)
                {
                    if (estoqueItem.ID == item.ID) listaOperacoes.Remove(estoqueItem);
                });
            }
            AtualizaDGV();
        }

        private void DgvOperacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvOperacoes.SelectedRows.Count > 0)
                BtnRemoverProdutoDGV.Enabled = true;
            else
                BtnRemoverProdutoDGV.Enabled = false;
        }

        private void DgvOperacoes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CboCliente.Enabled |= !listaOperacoes.Any();
        }

        public void AtualizarSomas()
        {
            Task.Factory.StartNew(() =>
            {
                Invoke((MethodInvoker)delegate
                {
                    LblQuantidadeTotal.Text = $"Quantidade Total: {listaOperacoes.Sum(x => x.Quantidade).ToString()}";
                    LblValorTotal.Text = $"Valor Total: {listaOperacoes.Sum(x => x.Valor).ToString()}";
                });
                Thread.Sleep(100);
            });
        }
    }
}
