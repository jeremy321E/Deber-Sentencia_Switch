using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario la calificación numérica
            Console.WriteLine("Ingrese la calificación numérica (0-100):");
            int calificacion = Convert.ToInt32(Console.ReadLine());

            // Convertir la calificación a una letra equivalente usando switch
            switch (calificacion)
            {
                case int n when (n >= 90 && n <= 100):
                    Console.WriteLine("La calificación es: A");
                    break;

                case int n when (n >= 80 && n < 90):
                    Console.WriteLine("La calificación es: B");
                    break;

                case int n when (n >= 70 && n < 80):
                    Console.WriteLine("La calificación es: C");
                    break;

                case int n when (n >= 60 && n < 70):
                    Console.WriteLine("La calificación es: D");
                    break;

                case int n when (n >= 0 && n < 60):
                    Console.WriteLine("La calificación es: F");
                    break;

                default:
                    Console.WriteLine("Calificación inválida. Por favor, ingrese un valor entre 0 y 100.");
                    break;
            }
        }
    }
}
