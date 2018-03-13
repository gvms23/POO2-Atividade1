using System.Collections.Generic;

namespace CC.POO2.aDisciplinas
{
    class Disciplina
    {
        public string Nome { get; set; }
        public int QuantidadeAulas { get; set; }

        public List<AlunoDisciplina> AlunoDisciplina { get; set; }
    }
}
