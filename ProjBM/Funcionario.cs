using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBM {
    internal class Funcionario : Pessoa {
        public int Tipofuncionario { get; set; }
        public Agencia Agencia { get; set; }
        public String Descricao { get; set; }
        Agencia agencia = new Agencia();
        Conta con = new Conta();

        public Funcionario() { }

        public Funcionario(String Descricao, String Nome, String Telefone, Agencia agencia) : base(Nome, Telefone) {
            this.Descricao = Descricao;

        }

        public Funcionario CadastroFuncionario() {

            Console.WriteLine("\n**** Cadastrar Agencia e Funcionario****\n");
            do {
                Console.Write("\nInforme o Tipo de Funcionario:  1 - [Gerente] ou 2 - [Colaborador do Banco] " +
                              " Digite:    ");
                Tipofuncionario = int.Parse(Console.ReadLine());

                if (Tipofuncionario == 1) {
                    this.Descricao = "Gerente";
                }
                else {
                    this.Descricao = "Colaborador do banco";
                }
            } while (Tipofuncionario <= 0 || Tipofuncionario > 2);

            Console.WriteLine("\nNome: ");
            Nome = Console.ReadLine();

            Console.Write("\nTelefone: ");
            Telefone = Console.ReadLine();


            agencia.CadastrarAgencia();



            return new Funcionario(Descricao, Nome, Telefone, Agencia);
        }


        public String AprovarConta() {
            int nro = 0;
          
                if (Descricao.Equals("Gerente")) {
                    Console.Write("Gerente você Autoriza a Abertura da Conta? 1/sim ou 2/não Digite: ");
                    nro = int.Parse(Console.ReadLine());

                    Console.WriteLine("O Gerente Aprovou sua Conta...\n Seja Bem Vindo!!! ");
                }else {
                    Console.WriteLine("Gerente Inacessivel no sistema no Momento");
                }

            if (nro == 1) {
                return "O Gerente Aprovou sua Conta...\n Seja Bem Vindo!!! ";
            }
            else {
                return "O Gerente  Não Aprovou a Conta..\nSorry";
            }

        }

        public String ImprimirFuncionario() {
            return "\n **** Status de Funcionario ****\n" +
                   "\nNome: " + this.Nome +
                   "\nDescrição: " + this.Descricao +
                   "\nTelefone: " + this.Telefone + "\n" +
                   "\n**** Endereco Agencia ****" +
                   "\n" + this.agencia.ImprimeAgencia();
        }



        public bool VerificaGerente() {
            if (Tipofuncionario == 0) {
                return false;
            }
            else {
                return true;
            }
        }






    }
}
