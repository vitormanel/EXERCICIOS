using System;

//Desenhe um retângulo com asteriscos, onde as forem linhas pares escreva
//"A" e as linhas ímpares escreva "B"


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
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write("A");
                    }
                    else
                    {
                        Console.Write("B");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}