using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el precio del producto
            Console.WriteLine("Ingrese el precio del producto:");
            decimal precio = decimal.Parse(Console.ReadLine());

            // Solicitar la cantidad de unidades
            Console.WriteLine("Ingrese la cantidad de unidades que desea comprar:");
            int cantidad = int.Parse(Console.ReadLine());

            // Variable para almacenar el descuento aplicable
            decimal descuento = 0m;

            // Determinar el descuento aplicable según la cantidad
            switch (cantidad)
            {
                case int n when (n >= 1 && n <= 9):
                    descuento = 0m; // Sin descuento
                    break;
                case int n when (n >= 10 && n <= 19):
                    descuento = 0.10m; // 10% de descuento
                    break;
                case int n when (n >= 20 && n <= 49):
                    descuento = 0.20m; // 20% de descuento
                    break;
                case int n when (n >= 50):
                    descuento = 0.30m; // 30% de descuento
                    break;
                default:
                    Console.WriteLine("Cantidad no válida.");
                    return;
            }

            // Calcular el precio total con el descuento
            decimal subtotal = precio * cantidad;
            decimal montoDescuento = subtotal * descuento;
            decimal total = subtotal - montoDescuento;

            // Mostrar el resultado al usuario
            Console.WriteLine($"Subtotal: {subtotal:C}");
            Console.WriteLine($"Descuento aplicado: {montoDescuento:C} ({descuento:P})");
            Console.WriteLine($"Total a pagar: {total:C}");
        }
    }
}
