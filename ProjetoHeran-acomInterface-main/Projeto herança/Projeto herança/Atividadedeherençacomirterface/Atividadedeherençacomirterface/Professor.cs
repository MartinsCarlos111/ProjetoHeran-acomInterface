using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadedeherençacomirterface
{
    public class Professor : Pessoa
    {
        private string titulacao;

        public Professor()
        {
            this.titulacao = null;
        }
        public Professor(string nome, int idade, string titulacao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Titulacao = titulacao;
        }
        
        public string Titulacao
        {
            get { return titulacao; }
            set { titulacao = value; }
        }

        public override String ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, " ", this.Idade.ToString(), " ", this.Titulacao);
            return s;
        }
    }
}
