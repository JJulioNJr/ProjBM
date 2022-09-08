using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjBM {
    internal class Conta {

        private String Senha { get; set; }

        public int NroConta { get; set; }

        public String Password { get; set; }

        public String Titular { get; set; }

        public float Limite { get; set; }

        public float Saldo { get; set; }

        public Cliente  cliente = new Cliente();

      
        private DateTime dataAtual;

        public Conta() {
            this.NroConta = -1;
            this.dataAtual = DateTime.Now;
           

        }

        public Conta(float saldo) {
            this.Saldo = saldo;

        }
       

        public void AbriConta(int z) {
           this.Titular = cliente.Nome;
            this.NroConta = z;

            Console.WriteLine("\nConta está Aberta !!!");
           
          
        }

        

        public String EfetuarSaque() {
            float saque = 0;

            Console.Write("\nInforme o Valor do Saque R$:");
            float valor = float.Parse(Console.ReadLine());

            if (valor <= Saldo) {
                this.Saldo -= valor;

            }
            else {
                Console.WriteLine("\nSaldo Atual Indisponivel para Saque!!!");
            }
           if (Saldo == 0) {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\nAperte Enter para Continuar... \n");
                SolicitarLimite();
            }
            return saque.ToString();
        }

        public String EfetuarDeposito() {
            Console.Write("\nInforme o Valor que Deseja Depositar R$: ");
            float valor = float.Parse(Console.ReadLine());
            

            if (valor > 0) {
                this.Saldo += valor;
              
                String ms = "\nValor R$:" + valor + " Depositado Com Sucesso!!!" +
                         "\nSaldo Total: " + this.Saldo;
                return "\n" + ms + "\n";

            }
            else {
                return "\nValor Não Atende as Normas de Deposito";
            }



        }

        public String ConsultarSaldo() {
            
          
               return "\n**** Bancao Morangão ****\n\n" +
                   "\n   " + dataAtual + "\n" +
                   "\nTitular: " + cliente.Nome + "Numero Conta: " + this.NroConta +
                   "\nSaldo Disponivel: " + this.Saldo;
        }

        #region Login Etapa1
        public String CadastrarLogin() {
            Console.Write("\nInforme uma Senha Numerica: ");
            String xy = Console.ReadLine();
          
            Thread.Sleep(2000);
            Console.Clear();
  
            return xy;
        }
        #endregion

        public String RealizarPagamento() {

            Console.Write("Informe o Valor da Fatura R$:");
            float valor = float.Parse(Console.ReadLine());

            if (valor > 0 && valor <= Saldo) {
                Saldo -= valor;
                return "Fatura Paga com Sucesso!!!";
            }
            else {
                return "Valor do Saldo Insuficiente para o Pagamento da Fatura!!!";
            }

        }

        #region Login Etapa2
        public bool VerificarLogin(String x) {
            int cont = 0;
            bool status = true;
            do {
                Console.Write(" Informe o Mesma Senha: ");
                this.Password = Console.ReadLine();
                this.Senha = x;

                if (Senha.Equals(Password)) {
                    String msg = "\nAutenticando Senha....";
                    Thread.Sleep(2000);
                    String msg2 = "\nSenha Autenticada...Sistema Liberado!!!";
                    Console.Write(msg + msg2);
                    return true;

                }
                else {
                    cont++;
                    if (cont == 3) {
                        Console.Write("\nCartão Foi Bloqueado...Excedeu as 3 Tentativas de Login!!!");
                        Senha = null;
                        status = false;
                        break;

                    }
                    Console.Write("\nSenha Invalida!!!");

                }
            } while (status);

            return false;

        }
        #endregion

        public String SolicitarLimite() {
            int op = 0;
            String msg = "";

            do {
                Console.WriteLine("\nLimite Pre-Aprovado");
                Console.WriteLine("\nEmprestimo Consignado Digite [1]" +
                                  "\nEmprestimo Emediato Digite [2]" +
                                  "\nSair Digite [3]");
                Console.Write("\nDigite: ");
                op = int.Parse(Console.ReadLine());


                switch (op) {

                    case 1:
                        Console.WriteLine("\n\t\t\tEmprestimo Consignado");
                        if (op == 1) {
                            this.Limite = 2000;
                            Saldo += Limite;
                            msg = "Emprestimo Consignado";
                         // ConsultarLimite(msg);
                            Console.WriteLine("\n\t\t\tSaldo R$: " + this.Saldo);
                            return msg;
                            //return;
                        }
                        else {
                            Console.WriteLine("\n\t\t\tLimite ainda não Disponivel!!!");

                        }
                        break;
                    case 2:
                        Console.WriteLine("\n\t\t\tEmprestimo Pré-Aprovado");
                        if (op == 2) {
                            this.Limite = 1000;
                            Saldo += Limite;
                            msg = "Emprestimo Consignado";
                           // ConsultarLimite(msg);
                            Console.WriteLine("\n\t\t\tSaldo R$: " + this.Saldo);
                            return msg;
                        }
                        else {
                            Console.WriteLine("\n\t\t\tLimite ainda não Disponivel!!!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n\t\t\tSaindo do Menu!!!");
                        break;
                    default:
                        if (op > 0 || op < 4) {
                            Console.WriteLine("\n\t\t\tOpção Inválida");
                        }
                        break;
                }
            } while (op != 3);


            return "";

        }












    }
}
