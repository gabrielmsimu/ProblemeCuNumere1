using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemeCuNumere1
{
    class Program
    {
        static void Main(string[] args)
        {
            EcuatieDeGradul1_1();
            EcuatieDeGradul2_2();
        }

        private static void EcuatieDeGradul2_2()
        {
            int a, b, c, delta;
            Console.WriteLine("Sa rezolvam o ecuatie de gradul 2: ax^2 + bx + c= 0");
            Console.WriteLine("Introduceti valoarea lui a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui c");
            c = int.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;

            if (delta >= 0)
            {
                Console.WriteLine($"solutiile sunt {(-b + Math.Sqrt(delta))/(2*a)} si {(-b - Math.Sqrt(delta))/(2*a)} ");
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii.");
            }
            
           
            
        }

        private static void EcuatieDeGradul1_1()
        {
            int a, b, x;
            Console.WriteLine("Sa rezolvam o ecuatie de gradul 1: ax + b = 0");
            Console.WriteLine("Introduceti valoarea lui a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui b");
            b = int.Parse(Console.ReadLine());

            if (b>=0)
            {
                Console.WriteLine($"Ecuatia este {a}x + {b} = 0");
            }
            else
            {
                Console.WriteLine($"Ecuatia este {a}x{b} = 0");
            }
            x = -b / a;
            Console.WriteLine($"=> x = {x}");


        }
    }
}
