using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBM {
    internal class Endereco {
        
        public String Logradouro { get; set; }
        public String Numero { get; set; }
        public String Cep { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Bairro { get; set; }

        public Endereco() { }

        public Endereco(string logradouro, string numero, string cep, string cidade, string estado, string bairro) {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Cep = cep;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Bairro = bairro;
        }
        public Endereco CadastrarEndereco() {
            Console.WriteLine("\n**** Cadastrar Endereço ****");

            Console.Write("\nLogradouro: ");
            this.Logradouro = Console.ReadLine();
            Console.Write("\nCP: ");
            this.Numero = Console.ReadLine();
            Console.Write("\nNumero: ");
            this.Cep = Console.ReadLine();
            Console.Write("\nCidade: ");
            this.Cidade = Console.ReadLine();
            Console.Write("\nEstado:");
            this.Estado = Console.ReadLine();
            Console.Write("\nBairro: ");
            this.Bairro = Console.ReadLine();

            Console.Clear();
            return new Endereco(Logradouro,Numero,Cep,Cidade,Estado,Bairro);
        }


        public String ImprimeEndereco() {
            return "\nLogradouro: " + Logradouro +
                   "\nNumero: " + Numero +
                   "\nCep: " + Cep +
                   "\nCidade: " + Cidade +
                   "\nEstado: " + Estado +
                   "\nBairro: " + Bairro;
        }

    }
}
