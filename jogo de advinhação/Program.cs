using System;

namespace jogo_de_advinhação
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nr = new Random();
            int numeromagico = nr.Next(0, 20);
            string nome;
            int tentativa = 3;
            int entrada;
            
            Console.WriteLine("Adivinhe se Puder!");
            Console.WriteLine("Olá e Seja Bem Vindo ao Adivinhe se Puder!");
            Console.WriteLine("O Objetivo desse jogo é você acertar o número aleatório de 0 a 20");
            Console.WriteLine("Agora, você dizer seu nome por favor?");
            nome = Console.ReadLine();
            Console.WriteLine("Perfeito " + nome + ", Você tem 3 Tentativas. Boa Sorte!");
            
            while (tentativa != 0)

            {
                Console.WriteLine("Qual é o Numero Mágico?");
                entrada = int.Parse(Console.ReadLine());
                if (entrada == numeromagico)
                {
                    Console.WriteLine("Parabéns! Você Conseguiu! Fim de Jogo!");
                    break;
                }
                else
                { tentativa--;
                    Console.WriteLine("Oh Não! Tente Novamente! (" + tentativa + " Tentativas Restantes)");
                              }
                         }
            if (tentativa == 0)
            {
                Console.WriteLine("Oh Não! Você esgotou todas suas tentativas e não acertou nenhuma. Fim de Jogo.");
            }
            
            }
            
            }
        }
    

