using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.POO2.eEstoqueDGV
{
    class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<Estoque> Estoque { get; set; }
    }
}
