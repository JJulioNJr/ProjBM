using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Security.Principal;
using System.Threading;

namespace ProjBM {



    internal class Program {




        static void MenuOperacao() {
            Console.WriteLine("\n**** Menu Operações Bancarias ****\n");
            Console.WriteLine("\n1 -  Sacar" +
                              "\n2 -  Consultar Saldo" +
                              "\n3 -  Depositar" +
                              "\n0-   Sair");
            Console.Write("\nDigite: ");

        }

        static void MenuPrincipal() {
            Console.WriteLine("\n**** Menu Principal ****\n");
            Console.WriteLine("\n1 - Cadastrar Cliente" +
                              "\n2 - Cadastrar Funcionario" +
                              //"\n3 - Remover conta " +
                              "\n4 - Consultar Cliente" +
                              "\n5 - Consultar Funcionario" +
                              "\n6 - Operações de Caixa" +
                              "\n0 - Sai do Sistema");
            Console.Write("\nDigite: ");
        }


        static void Main(string[] args) {
            int opc = 0;
            List<Cliente> cliente = new List<Cliente>();
            Cliente cl = new Cliente();

            List<Funcionario> funcionario = new List<Funcionario>();
            Funcionario fc = new Funcionario();

            List<Conta> conta = new List<Conta>();
            Conta conta1 = new Conta();

            do {

                MenuPrincipal();
                opc = int.Parse(Console.ReadLine());

                switch (opc) {

                    case 1:
                        int ct = 0;
                        cl.CadastraCliente();
                        cliente.Add(cl);
                        Console.Write("\nInforme se deseja Abrir uma Conta: 1/sim ou 2/não Digite: ");
                        ct = int.Parse(Console.ReadLine());

                        if (ct == 1) {
                            if (fc.VerificaGerente() == true) {
                                Console.WriteLine("\n Vamos Abrir uma Conta!?");
                                fc.AprovarConta();
                                conta1.AbriConta(cl.Id);
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                            else {
                                Console.WriteLine("\nGerente não encontrado no Sistema!!! ");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else {
                            Console.WriteLine("\nO Ok Deixaremos para uma Próxima!!! ");
                        }




                        break;
                    case 2:
                        fc.CadastroFuncionario();
                        funcionario.Add(fc);

                        break;

                    case 3:
                        /* foreach (Conta  c in conta) {
                              if () {
                                  conta.Remove(cliente.Contains(c.Id));
                              }
                          }*/

                        break;
                    #region consultar
                    case 4:
                        cliente.ForEach(i => Console.WriteLine(i.ImprimirCliente()));
                        //repetindo a consulta para dois tipos iguais 
                        break;
                    case 5:
                        funcionario.ForEach(i => Console.WriteLine(i.ImprimirFuncionario()));
                        //repetindo a consulta para dois tipos iguais 
                        break;
                    #endregion
                    case 6:
                        int esc = 0;
                      

                        if (conta1.NroConta == cl.Id) {
                            
                            String recebe = conta1.CadastrarLogin();
                            if (conta1.VerificarLogin(recebe) == true) {
                                do {

                                    MenuOperacao();
                                    esc = int.Parse(Console.ReadLine());
                                    switch (esc) {

                                        case 1:

                                            conta1.EfetuarSaque();
                                            break;
                                        case 2:
                                            Console.WriteLine(conta1.ConsultarSaldo());
                                            break;
                                        case 3:
                                            conta1.EfetuarDeposito();
                                            break;
                                        default:
                                            if (esc > 0 || esc < 4) {
                                                Console.WriteLine("\nOpção Inválida");
                                            }
                                            break;



                                    }
                                } while (esc != 0);
                            }
                            else {
                                Console.WriteLine("\nAperte Enter para Continuar...");
                                Console.ReadKey();
                                Console.Clear();
                            }

                        }
                        else {
                            Console.WriteLine("\nConta não confere no sistema ou não existe...");
                            Console.WriteLine("\nAperte Enter para Continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            } while (opc != 0) ;

        }   
    } 
}


