using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CC.POO2.dAlunosDGV;
using System.Threading;

namespace CC.POO2
{
    /// <summary>
    /// Implemente um programa em C# que solicite ao usuário o nome de um aluno e a respectiva nota
    /// de avaliação(de 0.0 até 10.0). As informações solicitadas deverão ser armazenadas em um objeto
    /// DataGridView. Um botão deverá percorrer o conteúdo armazenado na DataGridView e filtrar os
    /// alunos que tenham nota de avaliação inferior a 6.0. Osa alunos com nota inferior a 6.0 deverão ser
    /// copiados para um outro DataGridView.
    /// </summary>
    /// <seealso cref="UserControl" />
    public partial class CtrAlunosDGV : UserControl
    {
        List<Aluno> listaAlunos = new List<Aluno>();

        public CtrAlunosDGV()
        {
            InitializeComponent();
        }

        private void CtrAlunosDGV_Load(object sender, EventArgs e)
        {
            var t = new ToolTip();
            t.SetToolTip(BtnPreencherListasRandom, "Preencher 10 alunos.");
            t.SetToolTip(BtnLimparLista, "Limpar Listas");
        }

        private void BtnAdicionarAluno_Click(object sender, EventArgs e)
        {
            try /* Pegar erros */
            {
                //Verifico se os TextBoxes estão preenchidos
                if (TxtNomeAluno.Text == string.Empty || TxtNotaAluno.Text == string.Empty)
                    throw new Exception("Preencha o nome e a nota do aluno para continuar, por favor.");

                //Nessa linha ele tenta converter o textbox da nota do aluno em double,
                //Se ele não conseguir, mostra um erro
                if (!double.TryParse(TxtNotaAluno.Text, out double notaAluno))
                    throw new Exception("Por favor, somente números na nota do aluno.");

                //As notas devem ser entre 0 e 10
                if (notaAluno < 0 || notaAluno > 10)
                    throw new Exception("Por favor, a nota deve ser entre 0 e 10.");

                /***********************************************************************
                 * Naquela lista que criamos lá em cima, vamos adicionar um novo aluno
                 * com as informações que o usuário inseriu agora e acabamos de validar
                 ************************************************************************/

                listaAlunos.Add(new Aluno {
                                    Nome = TxtNomeAluno.Text,
                                    Nota = notaAluno });

                //Atualizo as DGVs, ou seja, DGV recebe a lista atualizada com esse
                //registro que acabamos de colocar.
                AtualizaDGVs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizaDGVs()
        {
            Task.Factory.StartNew(() =>
            {
                Invoke((MethodInvoker)delegate
                {
                    DgvAlunos.DataSource = listaAlunos.ToList();
                    DgvAlunosFiltrados.DataSource = listaAlunos.Where(x => x.Nota < 6).ToList();
                });
                Thread.Sleep(100);
            });
        }

        private void BtnPreencherListasRandom_Click(object sender, EventArgs e)
        {
            var listaPalavras = new List<string> {
               "Alfa", "Bravo", "Charlie", "Delta", "Eco",
               "Fox", "Golf", "Hotel", "Índia",
               "Juliete", "Kilo", "Lima", "Mike",
               "November", "Oscar", "Papa", "Quebec",
               "Romeo", "Sierra", "Tango",  "Uniforme",
               "Victor", "Xadrez", "Yankee", "Whisky",
               "Zulu"
            };

            //Crio fora, senão irá dar os mesmos valores sempre
            var rand = new Random();
            for (var i = 0; i <= 9; i++)
            {
                listaAlunos.Add(new Aluno
                {
                    Nome = listaPalavras[rand.Next(listaPalavras.Count)],
                    Nota = rand.Next(0, 10)
                });
            }

            AtualizaDGVs();
        }

        private void BtnLimparLista_Click(object sender, EventArgs e)
        {
            listaAlunos.Clear();
            AtualizaDGVs();
        }
    }
}

