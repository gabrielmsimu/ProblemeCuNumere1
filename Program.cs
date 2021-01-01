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
        static Random rnd = new Random();
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
            //DivizibilitateAB_12();
            //AniBisectiY1Y2_13();
            //Palindrom_14();
            //Numere_15();
            //Numere_16();
            //Numere_17();
            //Numere_18();

            Numere_20();

            


        }


        /// <summary>
        /// Afisati fractia m/n in format zecimal cu perioada intre paranteze (daca e cazul). 
        /// Exemplu 13/30 = 0.4(3)
        /// </summary>
        private static void Numere_20()
        {
            int m = 13;
            int n = 30;
            double d;

            d = (double)m / n;
            Console.Write($"{Math.Truncate(d)},");
            double parte_fractionara = d - Math.Truncate(d);
            
            while (parte_fractionara != 0)
            {
                double x = Math.Truncate(parte_fractionara * 100 % 10);
                double y = Math.Truncate(parte_fractionara * 10);

                if (x == y)
                {
                    Console.Write($"({x})");
                    parte_fractionara = 0;
                }
                else
                {
                    Console.Write($"{y}");
                    parte_fractionara = parte_fractionara * 10 - Math.Truncate(parte_fractionara * 10);
                }
                    


            }


            Console.WriteLine();
        }

        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  
        /// De ex. pentru n = 1776 afisati 2^4 x 3^1 x 37^1. 
        /// </summary>
        private static void Numere_18()
        {
            int n = 2483;
            Console.WriteLine(n);

            int puterea;
            string rezultat_final = "";

            while (n != 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (Prim(i) && n % i == 0)
                    {
                        puterea = 0;
                        while (n % i == 0)
                        {
                            n = n / i;
                            puterea++;
                        }
                        rezultat_final = rezultat_final + $"{i}^{puterea} x ";
                    }
                }
            }
            rezultat_final = rezultat_final.Remove(rezultat_final.Length - 2, 1);
            Console.WriteLine(rezultat_final);
        }



        /// <summary>
        /// Aceasta functie testeaza primalitatea numerelor pentru functia Numere_18.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static bool Prim(int x)
        {

            
            for (int i = 2; i <= x/2; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
                                   
            return true;

        }


        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. 
        /// Folositi algoritmul lui Euclid. 
        /// </summary>
        private static void Numere_17()
        {
            //int a = rnd.Next(0, 1001);
            //int b = rnd.Next(0, 1001);
            int a = 1071, b = 462;
            Console.WriteLine($"a = {a}; b= {b}");
            int rest;

            int produs = a * b;

            Console.Write($"Cel mai mare divizor comun (cmmdc) dintre {a} si {b} este ");
            if (a > b)
            {
                do
                {
                    rest = a % b;
                    a = b;
                    b = rest;
                } while (rest != 0);
                Console.Write(a);
                Console.Write($", iar cel mai mare multiplu comun (cmmmc) este {produs / a}");
            }
            else
            {
                do
                {
                    rest = b % a;
                    b = a;
                    a = rest;
                } while (rest != 0);
                Console.Write(b);
                Console.Write($", iar cel mai mare multiplu comun (cmmmc) este {produs / b}");
            }
            
            
            Console.WriteLine();
                     

        }



        /// <summary>
        /// Problema16
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>
        private static void Numere_16()
        {
            int nr1, nr2, nr3, nr4, nr5;

            Console.WriteLine("Dati valoarea primului numar:");
            nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati valoarea celui de-al doi-lea numar:");
            nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati valoarea celui de-al 3-lea numar:");
            nr3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati valoarea celui de-al 4-lea numar:");
            nr4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati valoarea celui de-al 5-lea numar:");
            nr5 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before: {nr1}, {nr2}, {nr3}, {nr4}, {nr5}");
                            
            int aux;

            while (nr1 >= nr2 || nr2 >= nr3 || nr3 >= nr4 || nr4 >= nr5)
            {
                if (nr1 > nr2)
                {
                    aux = nr1;
                    nr1 = nr2;
                    nr2 = aux;
                }
                if (nr2 > nr3)
                {
                    aux = nr2;
                    nr2 = nr3;
                    nr3 = aux;
                }
                if (nr3 > nr4)
                {
                    aux = nr3;
                    nr3 = nr4;
                    nr4 = aux;
                }
                if (nr4 > nr5)
                {
                    aux = nr4;
                    nr4 = nr5;
                    nr5 = aux;
                }

            }
            Console.WriteLine($"After: {nr1}, {nr2}, {nr3}, {nr4}, {nr5}");

        }


        /// <summary>
        /// Problema 15
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
        /// </summary>
        private static void Numere_15()
        {
            int nr1, nr2, nr3;

            Console.WriteLine("Dati valoarea primului numar:");
            nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati valoarea celui de-al doi-lea numar:");
            nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati valoarea celui de-al 3-lea numar:");
            nr3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before: {nr1}, {nr2}, {nr3}");
            int aux;

            while (nr1 >= nr2 || nr2 >= nr3)
            {
                if (nr1>nr2)
                {
                    aux = nr1;
                    nr1 = nr2;
                    nr2 = aux;
                }
                if (nr2 > nr3)
                {
                    aux = nr2;
                    nr2 = nr3;
                    nr3 = aux;
                }              

            }
            Console.WriteLine($"After: {nr1}, {nr2}, {nr3}");
        }


        /// <summary>
        /// Problema 14
        /// Determianti daca un numar n este palindrom. 
        /// Un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
        /// </summary>
        private static void Palindrom_14()
        {
            int numar = int.Parse(Console.ReadLine());
            int replacement_nr = numar;
            int palindrom = 0;

            do
            {
                palindrom = palindrom * 10 + replacement_nr % 10;
                replacement_nr /= 10;
            } while (replacement_nr != 0);

            if (palindrom == numar)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Nu este palindrom");
            }
        }

        /// <summary>
        /// Problema 13
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void AniBisectiY1Y2_13()
        {
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int contor = 0;

            for (int i = y1; i <= y2; i++)
            {
                if (i % 4 != 0)
                { 
                    //do nothing
                }
                
                else
                {
                    if (i % 100 != 0)
                    {
                        contor++;
                    }
                    else
                    {
                        if (i % 400 != 0)
                        {
                            // do nothing
                        }
                        else
                        {
                            contor++;
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Exista {contor} ani bisecti intre {y1} si {y2}.");
        }


        /// <summary>
        /// problema 12
        /// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
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
        /// Afisati in ordine inversa cifrele unui numar n. 
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
        /// Test de primalitate: determinati daca un numar n este prim.
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
        /// Afisati toti divizorii numarului n. 
        /// </summary>
        private static void DivizoriiluiN_9()
        {
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }

        }


        /// <summary>
        /// Problema 8
        /// (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.   
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
        /// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor. 
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
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
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
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
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
        /// Detreminati daca un an y este an bisect. 
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
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare.
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
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. 
        /// Tratati toate cazurile posibile. 
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
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        /// </summary>
        private static void EcuatieDeGradul1_1()
        {
            int a, b;
            double x;
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
