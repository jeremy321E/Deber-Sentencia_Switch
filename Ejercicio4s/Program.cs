using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario el nombre de una fruta
            Console.WriteLine("Ingrese el nombre de una fruta:");
            string fruta = Console.ReadLine().ToLower();

            // Determinar si la fruta es cítrica o no usando switch
            switch (fruta)
            {
                case "naranja":
                case "limón":
                case "lima":
                case "mandarina":
                case "pomelo":
                    Console.WriteLine("La fruta es cítrica.");
                    break;

                default:
                    Console.WriteLine("La fruta no es cítrica.");
                    break;
            }
        }
    }
}
