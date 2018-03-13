using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.POO2.aDisciplinas
{
    class Aluno
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public int Idade { get; private set; }

        public List<AlunoDisciplina> AlunoDisciplina;

        /// <summary>
        /// Método que cria um aluno, atribuindo valores a atributos do tipo 'private'.
        /// </summary>
        /// <param name="nome">Padrão: Gabriel.</param>
        /// <param name="sobrenome">Padrão: Vicente.</param>
        /// <param name="idade">Padrão: 21.</param>
        public void NovoAluno(string nome = "Gabriel", string sobrenome = "Vicente", int idade = 21)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
    }
}
