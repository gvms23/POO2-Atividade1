using System.ComponentModel;
using System.Threading;

namespace CC.POO2.eEstoqueDGV
{
    class DGVItem
    {
        public DGVItem() { }

        public DGVItem(Estoque estoque)
        {
            ID = estoque.ID;
            Quantidade = estoque.Quantidade;
            Valor = estoque.Valor;
            Cliente = $"{estoque.Cliente.ID} - {estoque.Cliente.Nome}";
            Produto = $"{estoque.Produto.ID} - {estoque.Produto.Descricao}";
        }

        [Browsable(false)]
        public int ID { get; set; }

        public double Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
    }
}
