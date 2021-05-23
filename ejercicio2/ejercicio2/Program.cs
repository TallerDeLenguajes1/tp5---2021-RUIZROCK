using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {   string o;
            int n1, n2,res, Opcion;

            do
            {
                Console.WriteLine("CALCULADORA de numeros Enteros:");
                Console.WriteLine("Menú:");
                Console.WriteLine("1-Suma");
                Console.WriteLine("2-Resta");
                Console.WriteLine("3-Producto");
                Console.WriteLine("4-Division");
                Console.WriteLine("");
                Console.WriteLine("Opcion:");
                o = Console.ReadLine();
                Opcion = Convert.ToInt32(o);
                Console.WriteLine("");
                Console.WriteLine("");

                if (Opcion!=1&&Opcion !=2&&Opcion != 3&&Opcion != 4){
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
                        Console.WriteLine(n1 + ("+") + n2 + ("=") + res);
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
                }

                Console.WriteLine("");
                Console.WriteLine("");
            } while (Opcion != 1|| Opcion != 2||Opcion != 3||Opcion != 4);

            

        }
    }
}
