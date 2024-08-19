using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Solicitar al usuario la longitud de los tres lados del triángulo
            Console.WriteLine("Ingrese la longitud del primer lado del triángulo:");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud del segundo lado del triángulo:");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud del tercer lado del triángulo:");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            // Clasificar el triángulo según el tipo
            string tipoTriangulo = ClasificarTriangulo(lado1, lado2, lado3);

            // Usar switch para mostrar el tipo de triángulo
            switch (tipoTriangulo)
            {
                case "Equilátero":
                    Console.WriteLine("El triángulo es equilátero: todos sus lados son iguales.");
                    break;
                case "Isósceles":
                    Console.WriteLine("El triángulo es isósceles: dos de sus lados son iguales.");
                    break;
                case "Escaleno":
                    Console.WriteLine("El triángulo es escaleno: todos sus lados son diferentes.");
                    break;
                default:
                    Console.WriteLine("Las longitudes ingresadas no forman un triángulo válido.");
                    break;
            }
        }
        static string ClasificarTriangulo(double lado1, double lado2, double lado3)
        {
            // Verificar si las longitudes forman un triángulo válido
            if (EsTrianguloValido(lado1, lado2, lado3))
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    return "Equilátero";
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                {
                    return "Isósceles";
                }
                else
                {
                    return "Escaleno";
                }
            }
            else
            {
                return "Inválido";
            }
        }

        static bool EsTrianguloValido(double lado1, double lado2, double lado3)
        {
            // Verificar la condición de existencia de un triángulo
            return (lado1 + lado2 > lado3) && (lado2 + lado3 > lado1) && (lado1 + lado3 > lado2);
        }
    }
}
