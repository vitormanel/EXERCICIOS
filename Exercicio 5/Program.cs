//Criar um jogo simplificado onde dois jogadores podem jogar dados;
//Regras:
//• O jogo deverá solicitar o nome dos dois jogadores;
//O jogo terá 3 rodadas;
//O jogador que tirar o maior número nos dados nessas 3 rodadas vence;
//• Em caso de empate (onde os dois tiram o mesmo número), nenhum
//jogador pontuará;
//• Os números permitidos vão de 0 a 6.
//A aplicação informará qual dos jogadores tirou o maior número.
using System;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \n Joguinho < Academia do Programador > Melhor de 3 Com desempate \n ");
            String nomes1;
            String nomes2;
            int valor1;
            int valor2;
            //int recebeValor = 6;
            Console.WriteLine("Entre com o nome do primeiro jogador: ");
            nomes1 = Console.ReadLine();
            Console.WriteLine("Entre com o nome do segundo jogador: ");
            nomes2 = Console.ReadLine();
            Console.WriteLine("\n " + nomes1);
            Console.WriteLine("\n " + nomes2);
            Console.WriteLine("\n Rodada 1: ");
            Console.WriteLine("Pontuaçao do jogador: " + nomes1);
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pontuaçao do jogador: " + nomes2);
            valor2 = Convert.ToInt32(Console.ReadLine()); 
            if(valor1 > 6) //Numero fornecido maior que 6 (funcionando)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Erro: os pontos fornecidos pelo usuario NÃO podem ser maiores que 6! \n");
                Console.ReadLine();
                Environment.Exit(0);
                if(valor2 > 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Erro: os pontos fornecidos pelo usuario NÃO podem ser maiores que 6! \n");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            //Rodada 1 (funcional)
            if (valor1 > valor2)
            {
                Console.WriteLine("O jogador " + nomes1 + " Venceu a Rodada 1");
            }
            else if (valor1 < valor2)
            {
                Console.WriteLine("O jogador " + nomes2 + " Venceu a Rodada 1");
                Console.ReadLine();
            }

            //Rodada 2 (funcionando)
            Console.WriteLine("\n Rodada 2: ");
            Console.WriteLine("Pontuaçao do jogador: " + nomes1);
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pontuaçao do jogador: " + nomes2);
            valor2 = Convert.ToInt32(Console.ReadLine());
            if(valor1 > valor2)
            {
                Console.WriteLine("O jogador " + nomes1 + " Venceu a Rodada 2");
            }
            else if(valor1 < valor2)
            {
                Console.WriteLine("O jogador " + nomes2 + " Venceu a Rodada 2");  
                Console.ReadLine();
            }
            //Rodada 3
            Console.WriteLine("\n Rodada 3: ");
            Console.WriteLine("Pontuaçao do jogador: " + nomes1);
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pontuaçao do jogador: " + nomes2);
            valor2 = Convert.ToInt32(Console.ReadLine());
            if (valor1 > valor2)
            {
                Console.WriteLine("O jogador " + nomes1 + " Venceu a Rodada 3");
            }
            else if (valor1 < valor2)
            {
                Console.WriteLine("O jogador " + nomes2 + " Venceu a Rodada 3");
                Console.ReadLine();
            }
            if(valor1 > valor2)
            {
                Console.WriteLine("O jogador: " + nomes1 + " Venceu o jogo");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fim de Jogo, Obrigado por jogar");
            }
            else if (valor1 < valor2)
            {
                Console.WriteLine("O jogador: " + nomes2 + " Venceu o jogo");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fim de Jogo, Obrigado por jogar");
            }
            //Em caso de empate entao: (funcionando)
            if (valor1 == valor2)
            {
                Console.WriteLine("Voces empataram sendo assim aqui vai a rodada de Desempate: \n");

                Console.WriteLine("\n Rodada de Desempate: ");
                Console.WriteLine("Pontuaçao do jogador: " + nomes1);
                valor1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pontuaçao do jogador: " + nomes2);
                valor2 = Convert.ToInt32(Console.ReadLine());
                if (valor1 > valor2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O jogador " + nomes1 + " Desempatou e" + " Venceu o Jogo!");
                }
                else if (valor1 < valor2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O jogador: " + nomes2 + " Desempatou e" + " Venceu o Jogo!");
                    Console.ReadLine();
                }
                if(valor1 == valor2)
                {
                    Console.WriteLine("Voces tiveram um empate definitivo: Tentem de novo!");
                }
            }
            Console.ReadLine();
        }
    }
}
