using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string o;
            int n1, n2, res, Opcion; //para operaciones sin MATH aplicado 
            double n3,n4 = 2,resultado; //para operaciones con MATH aplicado

            do
            {
                Console.WriteLine("CALCULADORA de numeros Enteros:");
                Console.WriteLine("Menú:");
                Console.WriteLine("1-Suma");
                Console.WriteLine("2-Resta");
                Console.WriteLine("3-Producto");
                Console.WriteLine("4-Division");
                Console.WriteLine("5-El valor absoluto de un número");
                Console.WriteLine("6-El cuadrado");
                Console.WriteLine("7-La raíz cuadrada");
                Console.WriteLine("8-El seno");
                Console.WriteLine("9-El Coseno");
                Console.WriteLine("10-La parte entera de un tipo float.");
                Console.WriteLine("");
                Console.WriteLine("Opcion:");
                o = Console.ReadLine();
                Opcion = Convert.ToInt32(o);
                Console.WriteLine("");
                Console.WriteLine("");

                if (Opcion != 1 && Opcion != 2 && Opcion != 3 && Opcion != 4 && Opcion != 5 && Opcion != 6 && Opcion != 7 && Opcion != 8 && Opcion != 9 && Opcion != 10)
                {
                    Console.WriteLine("");
                    Console.WriteLine("****************");
                    Console.WriteLine("Opcion Invalida!");
                    Console.WriteLine("****************");
                    Console.WriteLine("");
                }

                switch (Opcion)
                {
                    case 1:
                        Console.WriteLine("1-Suma");
                        Console.WriteLine("Ingrese dos numeros (por cada uno de ellos presione ENTER):");
                        o = Console.ReadLine();
                        n1 = Convert.ToInt32(o);
                        o = Console.ReadLine();
                        n2 = Convert.ToInt32(o);
                        res = n1 + n2;
                        Console.WriteLine(string.Format("la suma de {0} + {1} = {2}",n1,n2,res));  //consigna del ejercicio
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Seguir usando la CALCULADORA?");
                            Console.WriteLine("1-Si");
                            Console.WriteLine("0-No");
                            Console.WriteLine("Opcion:");
                            o = Console.ReadLine();
                            Opcion = Convert.ToInt32(o);
                            if (Opcion == 1)
                            {
                                Opcion = -1;
                                break;
                            }
                            else
                            {
                                if (Opcion == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("Opcion Invalida!");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("");
                                }
                            }
                        } while (Opcion != 1 && Opcion != 0);

                        break;

                    case 2:
                        Console.WriteLine("2-Resta");
                        Console.WriteLine("Ingrese dos numeros (por cada uno de ellos presione ENTER):");
                        o = Console.ReadLine();
                        n1 = Convert.ToInt32(o);
                        o = Console.ReadLine();
                        n2 = Convert.ToInt32(o);
                        res = n1 - n2;
                        Console.WriteLine(n1 + ("-") + n2 + ("=") + res);
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Seguir usando la CALCULADORA?");
                            Console.WriteLine("1-Si");
                            Console.WriteLine("0-No");
                            Console.WriteLine("Opcion:");
                            o = Console.ReadLine();
                            Opcion = Convert.ToInt32(o);
                            if (Opcion == 1)
                            {
                                Opcion = -1;
                                break;
                            }
                            else
                            {
                                if (Opcion == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("Opcion Invalida!");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("");
                                }
                            }
                        } while (Opcion != 1 && Opcion != 0);

                        break;

                    case 3:
                        Console.WriteLine("3-Producto");
                        Console.WriteLine("Ingrese dos numeros (por cada uno de ellos presione ENTER):");
                        o = Console.ReadLine();
                        n1 = Convert.ToInt32(o);
                        o = Console.ReadLine();
                        n2 = Convert.ToInt32(o);
                        res = n1 * n2;
                        Console.WriteLine(n1 + ("*") + n2 + ("=") + res);
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Seguir usando la CALCULADORA?");
                            Console.WriteLine("1-Si");
                            Console.WriteLine("0-No");
                            Console.WriteLine("Opcion:");
                            o = Console.ReadLine();
                            Opcion = Convert.ToInt32(o);
                            if (Opcion == 1)
                            {
                                Opcion = -1;
                                break;
                            }
                            else
                            {
                                if (Opcion == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("Opcion Invalida!");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("");
                                }
                            }
                        } while (Opcion != 1 && Opcion != 0);

                        break;

                    case 4:
                        Console.WriteLine("4-Division");
                        Console.WriteLine("Ingrese dos numeros (por cada uno de ellos presione ENTER):");
                        o = Console.ReadLine();
                        n1 = Convert.ToInt32(o);
                        o = Console.ReadLine();
                        n2 = Convert.ToInt32(o);
                        res = n1 / n2;
                        Console.WriteLine(n1 + ("/") + n2 + ("=") + res);
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Seguir usando la CALCULADORA?");
                            Console.WriteLine("1-Si");
                            Console.WriteLine("0-No");
                            Console.WriteLine("Opcion:");
                            o = Console.ReadLine();
                            Opcion = Convert.ToInt32(o);
                            if (Opcion == 1)
                            {
                                Opcion = -1;
                                break;
                            }
                            else
                            {
                                if (Opcion == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("Opcion Invalida!");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("");
                                }
                            }
                        } while (Opcion != 1 && Opcion != 0);

                        break;

                    case 5:
                        Console.WriteLine("5-El valor absoluto de un número");
                        Console.WriteLine("Ingrese un numero:");
                        o = Console.ReadLine();
                        n1 = Convert.ToInt32(o);
                        res = Math.Abs(n1);
                        Console.WriteLine(("|")+ n1 + ("| =") + res);
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Seguir usando la CALCULADORA?");
                            Console.WriteLine("1-Si");
                            Console.WriteLine("0-No");
                            Console.WriteLine("Opcion:");
                            o = Console.ReadLine();
                            Opcion = Convert.ToInt32(o);
                            if (Opcion == 1)
                            {
                                Opcion = -1;
                                break;
                            }
                            else
                            {
                                if (Opcion == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("Opcion Invalida!");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("");
                                }
                            }
                        } while (Opcion != 1 && Opcion != 0);

                        break;

                    case 6:
                        Console.WriteLine("6-El cuadrado");
                        Console.WriteLine("Ingrese un numero:");
                        o = Console.ReadLine();
                        n3 = Convert.ToDouble(o);
                        n4 = 2;
                        resultado = Math.Pow(n3,n4);
                        Console.WriteLine(n3 + ("^2 =") + resultado);
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Seguir usando la CALCULADORA?");
                            Console.WriteLine("1-Si");
                            Console.WriteLine("0-No");
                            Console.WriteLine("Opcion:");
                            o = Console.ReadLine();
                            Opcion = Convert.ToInt32(o);
                            if (Opcion == 1)
                            {
                                Opcion = -1;
                                break;
                            }
                            else
                            {
                                if (Opcion == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("Opcion Invalida!");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("");
                                }
                            }
                        } while (Opcion != 1 && Opcion != 0);

                        break;

                    case 7:
                        Console.WriteLine("7-La raíz cuadrada");
                        Console.WriteLine("Ingrese un numero:");
                        o = Console.ReadLine();
                        n3 = Convert.ToDouble(o);
                        resultado = Math.Sqrt(n3);
                        Console.WriteLine(n3 + ("^1/2 =") + resultado);
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Seguir usando la CALCULADORA?");
                            Console.WriteLine("1-Si");
                            Console.WriteLine("0-No");
                            Console.WriteLine("Opcion:");
                            o = Console.ReadLine();
                            Opcion = Convert.ToInt32(o);
                            if (Opcion == 1)
                            {
                                Opcion = -1;
                                break;
                            }
                            else
                            {
                                if (Opcion == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("Opcion Invalida!");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("");
                                }
                            }
                        } while (Opcion != 1 && Opcion != 0);

                        break;

                    case 8:
                        Console.WriteLine("8-El seno");
                        Console.WriteLine("Ingrese un angulo en grado sexagesimal:");
                        o = Console.ReadLine();
                        n3 = Convert.ToDouble(o);
                        resultado = Math.Sin(n3);
                        Console.WriteLine(("sen(")+n3+(")=") + resultado);
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Seguir usando la CALCULADORA?");
                            Console.WriteLine("1-Si");
                            Console.WriteLine("0-No");
                            Console.WriteLine("Opcion:");
                            o = Console.ReadLine();
                            Opcion = Convert.ToInt32(o);
                            if (Opcion == 1)
                            {
                                Opcion = -1;
                                break;
                            }
                            else
                            {
                                if (Opcion == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("Opcion Invalida!");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("");
                                }
                            }
                        } while (Opcion != 1 && Opcion != 0);

                        break;

                    case 9:
                        Console.WriteLine("9-El coseno");
                        Console.WriteLine("Ingrese un angulo en grado sexagesimal:");
                        o = Console.ReadLine();
                        n3 = Convert.ToDouble(o);
                        resultado = Math.Cos(n3);
                        Console.WriteLine(("cos(") + n3 + (")=") + resultado);
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Seguir usando la CALCULADORA?");
                            Console.WriteLine("1-Si");
                            Console.WriteLine("0-No");
                            Console.WriteLine("Opcion:");
                            o = Console.ReadLine();
                            Opcion = Convert.ToInt32(o);
                            if (Opcion == 1)
                            {
                                Opcion = -1;
                                break;
                            }
                            else
                            {
                                if (Opcion == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("Opcion Invalida!");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("");
                                }
                            }
                        } while (Opcion != 1 && Opcion != 0);

                        break;

                    case 10:
                        Console.WriteLine("10-La parte entera de un tipo float.");
                        Console.WriteLine("Ingrese un numero decimal:");
                        o = Console.ReadLine();
                        n3 = Convert.ToDouble(o);
                        resultado = Math.Sign(n3);
                        Console.WriteLine(("La parte entera de ") + n3 + ("es") + resultado);
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Seguir usando la CALCULADORA?");
                            Console.WriteLine("1-Si");
                            Console.WriteLine("0-No");
                            Console.WriteLine("Opcion:");
                            o = Console.ReadLine();
                            Opcion = Convert.ToInt32(o);
                            if (Opcion == 1)
                            {
                                Opcion = -1;
                                break;
                            }
                            else
                            {
                                if (Opcion == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("Opcion Invalida!");
                                    Console.WriteLine("****************");
                                    Console.WriteLine("");
                                }
                            }
                        } while (Opcion != 1 && Opcion != 0);

                        break;
                }

                Console.WriteLine("");
                Console.WriteLine("");
            } while (Opcion != 1 || Opcion != 2 || Opcion != 3 || Opcion != 4 || Opcion != 5 || Opcion != 6 || Opcion != 7 || Opcion != 8 || Opcion != 9 || Opcion != 10);



        }
    }
}