using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos numeros");
                Console.WriteLine("[5] Division de dos numeros");
                Console.WriteLine("[6] Numeros primos");
                Console.WriteLine("[7] Conversion a celsius");
                Console.WriteLine("[8] Conversion a Farenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Calculando...");
                        NPrimo();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese el valor en farenheit");
                        int F = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El valor de {0} es {1}°C", F, Celsius(F));
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.WriteLine("Ingrese el valor en celsius");
                        int C = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El valor de {0} es {1}°F", C, Farenheit(C));
                        Console.ReadKey();
                        break;




                }
            } while (!opcion.Equals("0"));

        }


        static int Suma(int a, int b)
        {
            return a + b;
        }
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static int Resta(int c, int d)
        {
            return c - d;
        }
        static int Multiplicacion(int e, int f)
        {
            return e * f;
        }
        static int Division(int g, int h)
        {
            return g / h;
        }
        static void NPrimo()
        {
            int numero = 2, divisible = 0;
            while (numero <= 29)
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisible++;
                    }
                    if (divisible > 2)
                    {
                        break;
                    }
                }
                if (divisible == 2)
                {
                    Console.WriteLine("{0} es primo", numero);
                }
                divisible = 0;
                numero++;
            }
        }
        static int Celsius(int F)
        {
            return (5 * (F - 32)) / 9;
        }
        static int Farenheit(int C)
        {
            return ((9 * C ) / 5 ) + 32;
        }
    }
}
