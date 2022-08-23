using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio I02 - Error al cubo
                Consigna
                Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
                Se debe validar que el número sea mayor que cero, caso contrario, 
                mostrar el mensaje: "ERROR. ¡Reingresar número!".

                IMPORTANTE
                Utilizar el método Pow de la clase Math para calcular las potencias.
             */

            int numeroIngresado;

            Console.Write("Ingrese un número: ");
            int.TryParse(Console.ReadLine(), out numeroIngresado);

            if (numeroIngresado == 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
            else
            {
                Console.WriteLine("El cuadrado es: {0}", Math.Pow(numeroIngresado, 2));
                Console.WriteLine("El cubo es: {0}", Math.Pow(numeroIngresado, 3));
            }

            Console.WriteLine("FIN.");
        }
    }
}
