//Desenhe um retângulo com asteriscos, considere que o primeiro input é a
//largura do retângulo, e o segundo input é a altura.
using System;

namespace EXERCICIOS_PRESENCIAL___11___02___2022.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura;
            int altura;
            Console.WriteLine(" Digite o tamanho da largura: ");
            largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Digite o tamanho da altura: ");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i < altura; i++)
            {
                for(int j = 0; j < largura; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
