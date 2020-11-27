using System;

namespace Gerenciar_produtos_27_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Geerenciar produtos");
            Console.WriteLine("-------------------");
            Console.WriteLine();// pular linha 

            string[] nome      = new string [2];
            float [] preco     = new float  [2];
            bool  [] promocao  = new bool   [2];


        int escolha;
        int contador = 0;
            do
            {
                Console.WriteLine("Menu inicial");
                Console.WriteLine();
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine($"[1] - Cadsatrar o nome e preço do produto");
                Console.WriteLine($"[2] - listagem dos produtos");
                Console.WriteLine($"[0] - Sair");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (escolha)
                {
                    case 1:
                            // cadastrar produto
                            string resposta;
                            do
                            {
                                if (contador<2)
                                {
                                    Console.WriteLine($"Digite o nome do {contador+1}º produto");
                                        nome[contador] = Console.ReadLine();

                                        Console.WriteLine($"Digite o preço do {contador+1}º produto");
                                        preco[contador] = int.Parse(Console.ReadLine());

                                        Console.WriteLine($"{contador+1} esta em promoção?");
                                        promocao[contador] = bool.Parse(Console.ReadLine());
                                        contador++;
                                        if (true)
                                        {
                                            Console.WriteLine("Produto esta em promoção!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Não esta em promoção");
                                        }
                                        

                                }
                                else{
                                    Console.WriteLine();
                                    Console.WriteLine("Limite de produtos excedidos");
                                        break;
                                }
                                Console.WriteLine("Deseja cadastrar produto? s/n");
                                        resposta = Console.ReadLine();

                            } while (resposta == "s");
                        break;

                    case 2:  // listar passagem
                             for (var i = 0; i < 2; i++)
                            {
                                Console.WriteLine($"produtos {nome[i]}");
                                Console.WriteLine($"preço {preco[i]}");
                                Console.WriteLine("");
                            };
                        break;

                    case 0:
                        //sair
                        break;

                    default:
                        Console.WriteLine("Opção inválda");
                        break;
                }

            } while (escolha != 0);
        }
    }
}
