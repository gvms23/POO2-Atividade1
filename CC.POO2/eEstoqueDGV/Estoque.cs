using System.Threading;

namespace CC.POO2.eEstoqueDGV
{
    class Estoque
    {
        public Estoque()
        {
            ID = Interlocked.Increment(ref GlobalID);
        }

        /// <summary>
        /// ID é auto-incrementado, esse método força o ID = 0.
        /// </summary>
        public void ResetID()
        {
            GlobalID = 0;
        }

        static int GlobalID;
        public int ID { get; private set; }
        public double Quantidade { get; set; }
        public decimal Valor { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public EstoqueTipoOperacao Operacao { get; set; }
    }
}
