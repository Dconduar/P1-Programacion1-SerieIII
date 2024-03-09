using System;

namespace CalculadoraPrecios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a la Calculadora de Precios!");

            // Ingresar precios de los productos
            Console.Write("Ingrese el precio del primer producto (centavos): ");
            int precio1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el precio del segundo producto (centavos): ");
            int precio2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el precio del tercer producto (centavos): ");
            int precio3 = Convert.ToInt32(Console.ReadLine());

            // Calcular el total
            int total = precio1 + precio2 + precio3;

            // Aplicar descuento si el total excede de 500 centavos
            total = total > 500 ? (int)(total * 0.9) : total;

            Console.WriteLine($"El total es: {total} centavos");
        }
    }
}
