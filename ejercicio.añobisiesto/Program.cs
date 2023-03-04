using System;
namespace Programa01examen
{class Program
    {public static bool Añobisiesto(int a)
        {if (a % 4 == 0 & (a % 100 != 0 | a % 400 == 0))
         return true;
         return false;
        }
        static void Main(string[] args)
        {int j;
            Console.Write("Escriba un año: ");
            j = Int32.Parse(Console.ReadLine());
            if (Añobisiesto(j) == true)
            {  Console.WriteLine("{0} Es un año bisiesto", j);
            }
            else
            {Console.WriteLine("{0} No es un año bisiesto", j);
            }
        }
    }
}