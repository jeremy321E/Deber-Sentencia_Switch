using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario su edad
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());

            // Determinar si el usuario tiene la edad suficiente para votar
            if (edad < 18)
            {
                Console.WriteLine("No tienes la edad suficiente para votar.");
            }
            else if (edad >= 18)
            {
                Console.WriteLine("Tienes la edad suficiente para votar.");
            }
            else
            {
                Console.WriteLine("Edad no válida.");
            }
        }
    }
}
