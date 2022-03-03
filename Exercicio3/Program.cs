using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distância percorrida em Km: ");
            decimal.TryParse(Console.ReadLine(), out decimal valorDistancia);

            Console.WriteLine("Informe a quantidade de litros gastos em combustível: "); 
            decimal.TryParse(Console.ReadLine(), out decimal valorLitros);        

            Console.WriteLine($"Sua média de gasto é: {valorDistancia / valorLitros}");
            Console.ReadLine();



        }
    }
}
