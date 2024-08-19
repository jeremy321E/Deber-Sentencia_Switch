using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario un número que represente un día de la semana
            Console.WriteLine("Ingrese un número del 1 al 7 para seleccionar un día de la semana:");
            int diaSemana = Convert.ToInt32(Console.ReadLine());

            // Usar switch para determinar el nombre del día correspondiente
            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("El día seleccionado es Lunes.");
                    break;
                case 2:
                    Console.WriteLine("El día seleccionado es Martes.");
                    break;
                case 3:
                    Console.WriteLine("El día seleccionado es Miércoles.");
                    break;
                case 4:
                    Console.WriteLine("El día seleccionado es Jueves.");
                    break;
                case 5:
                    Console.WriteLine("El día seleccionado es Viernes.");
                    break;
                case 6:
                    Console.WriteLine("El día seleccionado es Sábado.");
                    break;
                case 7:
                    Console.WriteLine("El día seleccionado es Domingo.");
                    break;
                default:
                    Console.WriteLine("El número ingresado no es válido. Por favor, ingrese un número del 1 al 7.");
                    break;
            }
        }
    }
}
