//Desenvolver um algoritmo que leia 5 valores inteiros e calcule e escreva a
//média aritmética dos valores lidos, a quantidade de valores positivos e a
//quantidade de valores negativos.

using System;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            float valor1, valor2, valor3, valor4, valor5;
            float valorTotal;
            float numerosNegativos = 0;
            float numerosPositivos = 0;

            //Inicio
            Console.Write("Digite o valor 1: ");
            valor1 = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Digite o valor 2: ");
            valor2 = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Digite o valor 3: ");
            valor3 = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Digite o valor 4: ");
            valor4 = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Digite o valor 5: ");
            valor5 = Convert.ToSingle(Console.ReadLine());
            
            //soma aritmetica
            valorTotal = (valor1 + valor2 + valor3 + valor4 + valor5) / 5;

            //armazenando numeros positivos e numeros negativos nas variaveis que inicialmente recebem 0;

            if(valor1 < 0 || valor2 < 0 || valor3 < 0 || valor4 < 0 || valor5 < 0)
            {
                numerosNegativos++;
            }
            if(valor1 > 1 || valor2 > 1 || valor3 > 1 || valor4 > 1 || valor5 > 1)
            {
                numerosPositivos++;
            }
            Console.WriteLine("\nA media aritmética dos numeros é: " + valorTotal);
            Console.WriteLine("Quantidade de numeros negativos: " + numerosNegativos);
            Console.WriteLine("Quantidade de numeros positivos: " + numerosPositivos);
            Console.ReadLine();
        }
    }
}
