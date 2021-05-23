using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int N;
            Console.WriteLine("cantidad de numeros:");
            string cadena = Console.ReadLine();
            N = Convert.ToInt32(cadena);

            Console.WriteLine("Ingrese los numeros");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Numero "+ i + ": ");
                cadena = Console.ReadLine();
                int numero = Convert.ToInt32(cadena);
                if (numero>=0)
                {
                    Console.WriteLine("convertir string "+numero+" a int: "+numero);
                }

            }
            
        }
    }
}
