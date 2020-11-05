using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
            //EcuatieDeGradul1_1();
            //EcuatieDeGradul2_2();
            //NSeDivideCuK_3();
            //AnBisect_4();
            //ExtragetiAkaCifra_5();
            //LungimileLaturilorUnuiTriunghui_6();
            //InversareValori_7();  
            //Inversari2_8();
            //DivizoriiluiN_9();
            //TestDePrimalitate_10();
            //CifreNumarInOrdineInversa_11();
            DivizibilitateAB_12();
        }


        /// <summary>
        /// problema 12
        /// </summary>
        private static void DivizibilitateAB_12()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inceputul intervalului");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti sfarsitul intervalului");
            int b = int.Parse(Console.ReadLine());
            int contor = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    contor += 1;
                }
            }

            Console.WriteLine(contor);
        }

        
        /// <summary>
        /// problema 11
        /// </summary>
        private static void CifreNumarInOrdineInversa_11()
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("0");
            }

            while (n != 0)
            {
                Console.Write(n % 10 + " ");
                n = n / 10;
            }

            
        }


        /// <summary>
        /// problema 10
        /// </summary>
        private static void TestDePrimalitate_10()
        {
            int n = int.Parse(Console.ReadLine());

            bool prim = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    prim = false;
                    break;
                }
            }

            if (prim)
            {
                Console.WriteLine("Numarul este prim.");
            }
            else
            {
                if (n == 0 || n == 2 || n == 1)
                {
                    Console.WriteLine("Numarul este prim");
                }
                else
                {
                    Console.WriteLine("Numarul nu este prim"); 
                }
            }

        }

        /// <summary>
        /// problema 9
        /// </summary>
        private static void DivizoriiluiN_9()
        {
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }

        }


        /// <summary>
        /// Problema 8
        /// </summary>
        private static void Inversari2_8()
        {

            int a = 10;
            int b = 20;

            Console.WriteLine($"Inainte de inversare a = {a} and b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Dupa inversare: a = {a} and b = {b}");
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
