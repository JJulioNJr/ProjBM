using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBM {
    internal class Pessoa {

        public String Nome { get; set; }
       
        protected char Sexo { get; set; }

        protected String Telefone { get; set; }
        protected float Salario { get; set; }

        public Endereco endereco = new Endereco();


        public Pessoa() { }

      
        public Pessoa(String Nome, char Sexo,String Telefone,float salario,Endereco endereco) {

            this.Nome = Nome;
            this.Telefone= Telefone;
            this.Sexo = Sexo;
            this.Salario = salario;
        }

        public Pessoa(String Nome,String Telefone) {
            this.Nome= Nome;
            this.Telefone= Telefone;

        }
    }
}
