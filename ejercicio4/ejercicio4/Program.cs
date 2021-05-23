using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cadena = { "hola mundo", "segundo texto" };
            string cadena1;
            string cadena2;
            Console.WriteLine("Escriba un texto:");
            cadena1 = Console.ReadLine();

            Console.WriteLine("Longitud de la cadena:");
            Console.WriteLine("");
            Console.WriteLine(string.Format("con String.format: La cadena {0} tiene una longitud de {1} caracteres", cadena1, cadena1.Length));
            Console.WriteLine($"OTRA FORMA ($): La cadena {cadena1} tiene una longitud de {cadena1.Length} caracteres");
            Console.WriteLine("");


            Console.WriteLine("Concatenacion de cadenas:");
            Console.WriteLine("Escriba otro texto para concatenar con la cadena anterior:");
            cadena2 = Console.ReadLine();
            Console.WriteLine(string.Format("con String.format: {0}{1}", cadena1, cadena2));
            Console.WriteLine($"OTRA FORMA ($):{cadena1}{cadena2}");
            Console.WriteLine("");


            Console.WriteLine("Extraer una subcadena del array []cadena={primer texto,texto segundo}:");
            Console.WriteLine("Desde que longitud recortar?:");
            int found = 0;
            string n = Console.ReadLine();
            int num = Convert.ToInt32(n);
            Console.WriteLine("");
            foreach (string s in cadena)
                Console.WriteLine(s);
            Console.WriteLine("");
            Console.WriteLine("Resultado:");
            Console.WriteLine("");
            foreach (string s in cadena)
            {
                found = s.IndexOf(n) + 1;
                Console.WriteLine("{0}", s.Substring(found + num));
            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Escriba dos numeros enteros (por cada uno de ellos presionar enter) para realizar la suma");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int resultado = n1 + n2;
            string num1 = Convert.ToString(n1);
            string num2 = Convert.ToString(n2);

            Console.WriteLine(string.Format("La suma de {0}+{1}={2}", num1, num2, resultado));


        }
    }
}
