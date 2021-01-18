using System;
using System.Collections;

namespace CrudDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList num = new ArrayList();
            int opcao = 0; 

            Console.WriteLine("");
            Console.WriteLine("Entre com 7 números");
            Console.WriteLine("------------------------");
            
                for(int i=0; i <= 6; i++){
                    Console.WriteLine($"Numero {i + 1}");
                    num.Add(Console.ReadLine());
                }
            Console.Clear();

                for(int i=0; i < num.Count; i++){
                    Console.WriteLine("Explore as opções de sua preferencia");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("1- Ver os numeros de entrada");
                    Console.WriteLine("2- Adicionar um novo numero");
                    Console.WriteLine("3- Alterar um numero existente");
                    Console.WriteLine("4- Excluir um numero");
                    Console.WriteLine("5- Sair");
                        opcao = int.Parse(Console.ReadLine());
            

                    switch(opcao){

                            case 1:
                            Console.Clear();
                                Console.WriteLine(">> Os numeros de entrada são:");
                                    int x = 0;
                                    foreach(String myList in num){
                                        Console.WriteLine($"Numero {++x} = {myList}");
                                    }
                            Console.WriteLine("");
                            Console.WriteLine("-------------------------------------");
                            break;

                            case 2:
                            Console.Clear();
                                Console.WriteLine(">> Insira um novo numero: ");
                                    num.Add(Console.ReadLine());
                                Console.WriteLine("Numero inserido com sucesso!");
                            Console.WriteLine("");
                            Console.WriteLine("-------------------------------------");
                            break;

                            case 3:
                            Console.Clear();
                                Console.WriteLine(">> Qual numero deseja alterar?");
                                    int index = num.BinarySearch(Console.ReadLine());  
                                        num.RemoveAt(index);
                                    if(index < 0){
                                        Console.WriteLine(">> Valor informado não foi encontrado. Passe um valor válido.");
                                    }else{
                                        Console.WriteLine(">> Informe o numero desejado:");
                                            num.Insert(index, Console.ReadLine());
                                    }
                                Console.WriteLine("Numero alterado com sucesso!");
                            Console.WriteLine("");
                            Console.WriteLine("-------------------------------------");   
                            break;

                            case 4:
                            Console.Clear();
                                Console.WriteLine(">> Entre com o numero a ser excluído: ");
                                    string remove = Console.ReadLine();
                                    num.Remove(remove);
                                Console.WriteLine("Numero excluído com sucesso!");
                            Console.WriteLine("");
                            Console.WriteLine("-------------------------------------");        
                            break;

                            case 5:
                                Console.WriteLine(">> Saida com exito");
                                i += num.Count;
                            continue;
                            
                        default:
                        Console.Clear();
                            Console.WriteLine(">> Escolha uma opção de 1 á 5");
                        break;
                    }//END switch
                }//END for menu
        }//END main
    }
}
