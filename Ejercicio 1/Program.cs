using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Ejercicio I01 - Máximo, mínimo y promedio
                 Consigna
                 Ingresar 5 números por consola, guardándolos en una 
                 variable escalar. Luego calcular y mostrar: el valor máximo, 
                 el valor mínimo y el promedio.
              */

            int maximoNumeroIngresado = int.MinValue;
            int minimoNumeroIngresado = int.MaxValue;
            float promedioDeNumerosIngresados;
            int numeroIngresado;
            int acumuladorDeNumerosIngresados = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un número: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado < minimoNumeroIngresado)
                {
                    minimoNumeroIngresado = numeroIngresado;
                }

                if (numeroIngresado > maximoNumeroIngresado)
                {
                    maximoNumeroIngresado = numeroIngresado;
                }

                acumuladorDeNumerosIngresados += numeroIngresado;
            }

            promedioDeNumerosIngresados = (float)acumuladorDeNumerosIngresados / 5;

            Console.WriteLine($"El minimo es: {minimoNumeroIngresado}");
            Console.WriteLine($"El maximo es: {maximoNumeroIngresado}");
            Console.WriteLine($"El promedio es: {promedioDeNumerosIngresados}");

        }
    }
}
