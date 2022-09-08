using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBM {
    internal class Cliente : Pessoa {

        public int Id;
        private String Cpf { get; set; }

        private DateTime DataN;

       
        public Cliente() { }
        public Cliente(String Cpf,int id, String Nome, char Sexo, String Telefone, float Salario, Endereco endereco) : base(Nome, Sexo, Telefone, Salario, endereco) {
            this.Cpf = Cpf;
            

        }

       
            #region
            public Cliente CadastraCliente() {

                Console.WriteLine("\n**** Cadastrar Cliente ****\n");
              
                Console.Write("Informe Id: ");
                Id = int.Parse(Console.ReadLine());

                Console.Write("\nInforme o CPF: ");
                Cpf = Console.ReadLine();

                Console.Write("\nData de Nascimento: ");
                DataN = DateTime.Parse(Console.ReadLine());

                Console.Write("\nInforme seu Nome: ");
                Nome = Console.ReadLine();

                Console.WriteLine("\nInforme seu Sexo [M] ou [F] ");
                Sexo = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("\nInforme seu Telefone: ");
                Telefone = Console.ReadLine();

                Console.Write("\nInforme sua Renda R$: ");
                Salario = float.Parse(Console.ReadLine());

                endereco.CadastrarEndereco();




                #endregion
                return new Cliente(Cpf, Id, Nome, Sexo, Telefone, Salario, endereco);
                
            }

            public String ImprimirCliente() {
                return "\n **** Status de Cliente ****\n" +
                       "\nNome: " +this.Nome +
                       "\nCPF: " + this.Cpf +
                       "\nData de nascimento: " + this.DataN.ToShortDateString() +
                       "\nSexo: " + this.Sexo +
                       "\nSálario R$:" + this.Salario +
                       "\nTelefone: " + this.Telefone + "\n" +
                       "\n**** Endereço ****" +
                       "\nLogradouro: " + this.endereco.ImprimeEndereco();

            }


    }
}
