using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_de_temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double c = double.Parse(Console.ReadLine());

            double f = (c * 9 / 5) + 32;
            double k = c + 273.15;

            Console.WriteLine();

            Console.WriteLine("Temperatura em Fahrenheit: " + f + " ºF");

            Console.WriteLine();

            Console.WriteLine("Temperatura em Kelvin: " + k + " K");

            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
