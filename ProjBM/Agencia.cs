using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBM {
    internal class Agencia {

        public static String Nome = "BANCO MORANGÂO";
        public Endereco endereco;
       

        public Agencia() { }
        public Agencia(String Nome,Endereco endereco) { 
          this.endereco=endereco;
        
        }

        public Agencia CadastrarAgencia() {
            endereco = new Endereco();
            endereco.CadastrarEndereco();

            return new Agencia(Nome, endereco);

        }
        public Agencia(Endereco endereco1) { }


        public String ImprimeAgencia() {
            return "\nNome:" + Nome +
                    "**** Endereco ****" +
                     endereco.ImprimeEndereco();
        }
                
    }
}
