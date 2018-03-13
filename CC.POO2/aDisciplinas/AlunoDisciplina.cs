using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.POO2.aDisciplinas
{

    class AlunoDisciplina
    {
        public double NotaAtividade1 { get; set; }
        public double NotaAtividade2 { get; set; }
        public double NotaAvaliacao { get; set; }
        public int Faltas { get; set; }
        public double Media { get; set; }
        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }
    }

}
