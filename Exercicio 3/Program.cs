//Escreva um programa que contenha uma variável: horaAtual;
//Essa variável deverá conter a hora do dia e três mensagens deverão ser
//impressas na tela de acordo com a hora:
//“Bom dia”, “Boa tarde” ou “Boa noite”.

using System;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaAtual;
            Console.WriteLine(" Digite um horario (ultilize o horario no formato 24h!): ");
            horaAtual = Convert.ToInt32(Console.ReadLine());
            if (horaAtual >= 07 && horaAtual <= 12)
            {
                Console.WriteLine("Bom Dia!");
            }
            if (horaAtual >= 13 && horaAtual <= 17)
            {
                Console.WriteLine("Boa Tarde!");
            }
            if (horaAtual >= 18 && horaAtual <= 23)
            {
                Console.WriteLine("Boa Noite!");
            }
            if(horaAtual >= 00 && horaAtual <= 06)
            {
                Console.WriteLine("Boa madrugada!");
            }
            if (horaAtual >= 24)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Horario invalido ou inexistente! ");
            }
            Console.ReadLine();
        }
    }
}
