using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadedeherençacomirterface
{
    public class Aluno:Pessoa
    {
        private string curso;
        public Aluno()
        {
            this.curso = null;
        }
        public Aluno(string nome, int idade, string curso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.curso = curso;
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, " ", this.Idade.ToString(), " ", this.Curso);
            return s;
        }
    }
}
