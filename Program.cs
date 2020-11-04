using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
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
            NSeDivideCuK_3();
            AnBisect_4();
            ExtragetiAkaCifra_5();
            LungimileLaturilorUnuiTriunghui_6();
            InversareValori_7();  
            Inversari2_8();
        }


        /// <summary>
        /// Problema 8
        /// </summary>
        private static void Inversari2_8()
        {
            Console.WriteLine("Introduceti pe rand cele doua valori (a si b)");
            Console.WriteLine("A are valoarea: ");
            string a = (Console.ReadLine());
            Console.WriteLine("B are valoarea: ");
            string b = (Console.ReadLine());

            int lungimeA = a.Length;
            int lungimeB = b.Length;

            int A = int.Parse(a);
            int B = int.Parse(b);

            A = A + B * (int)Math.Pow(10, lungimeB);
            A = A / (int)Math.Pow(10,lungimeB);
            Console.WriteLine("Noul A este " + A);

            A = int.Parse(a);
            B = B + A * (int)Math.Pow(10, lungimeA);
            B = B / (int)Math.Pow(10, lungimeA);
            Console.WriteLine("Noul B este " + B);

        }


        /// <summary>
        /// Problema 7
        /// </summary>
        private static void InversareValori_7()
        {
            Console.WriteLine("Introduceti pe rand cele doua valori (a si b)");
            Console.WriteLine("A are valoarea: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("B are valoarea: ");
            int b = int.Parse(Console.ReadLine());


            int max = a;
            a = b;
            b = max;
            Console.WriteLine("Dupa schimbare: ");
            Console.WriteLine("A: " + a + " B: " + b);
        }


        /// <summary>
        /// Problema 6
        /// </summary>
        private static void LungimileLaturilorUnuiTriunghui_6()
        {
            Console.WriteLine("Introduceti pe rand lungimie laturilor.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && b + c > a && c + a > b)
            {
                Console.WriteLine("Lungimile laturilor pot forma un triunghi");
            }

            else
            {
                Console.WriteLine("Lungimile laturilor nu pot forma un triunghi");
            }
        }


        /// <summary>
        /// Problema 5
        /// </summary>
        private static void ExtragetiAkaCifra_5()
        {
            Console.WriteLine("Introduceti a cata cifre doriti sa extrageti din numar");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti numarul pentru care doriti sa extrageti a {k}a cifra");
            int n = int.Parse(Console.ReadLine());
            int cifra, c = k;

            do
            {
                cifra = n % 10;
                n = n / 10;
                k--;

            } while (k > 0);

            Console.WriteLine($"A {c}a cifra este {cifra}.");

        }

        /// <summary>
        /// Problema4
        /// </summary>
        private static void AnBisect_4()
        {
            int an;
            Console.WriteLine("Introduceti anul pentru testare:");
            an = int.Parse(Console.ReadLine());
            if (an % 4 != 0)
            {
                Console.WriteLine("anul este obisnuit");
            }
            else
            {
                if (an % 100 != 0)
                {
                    Console.WriteLine("anul este bisect");
                }
                else
                {
                    if (an % 400 != 0)
                    {
                        Console.WriteLine("anul este obisnuit");
                    }
                    else
                    {
                        Console.WriteLine("anul este bisect");
                    }
                }
            }
        }


        /// <summary>
        /// Problema 3
        /// </summary>
        private static void NSeDivideCuK_3()
        {
            int n, k;
            Console.WriteLine("Introduceti valoarea lui n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui k");
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine($"{n} se divide cu {k}");
            }
            else
            {
                Console.WriteLine($"{n} nu se divide cu {k}");
            }

        }


        /// <summary>
        /// Problema 2
        /// </summary>
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
        /// <summary>
        /// Problema 1
        /// </summary>
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
