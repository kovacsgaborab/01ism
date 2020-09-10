﻿using System;

namespace _01ism
{
    class Program
    {
        static string[] lehetoseg = new string[] { "kő", "papír", "olló" }; //felsoroljuk az elemeit, és innen tudja hány elemű

        static int gepvalasztas()
        {
            Random vel = new Random(); //random változó
            return vel.Next(0, 3);
        }

        static int jatekosvalasztas()
        {
            Console.WriteLine("kő {0}, papír {1}, olló {2}");
            Console.Write("Válasz: ");
            return Convert.ToInt32(Console.ReadLine()); //értéket adunk a jatekosvalasz változónak
        }
        static void eredmenykiiras(int gep, int ember)
        {
            Console.WriteLine("Gép: {0} --- Játékos: {1}", lehetoseg[gep], lehetoseg[ember]);

            switch (embernyer(gep, ember))
            {
                case 0:
                    Console.WriteLine("Döntetlen!");
                    break;
                case 1:
                    Console.WriteLine("Skynet nyer!");
                    break;
                case 2:
                    Console.WriteLine("Játékos nyer!");
                    break;
            }
        }
        static int embernyer(int gep, int ember)
        {
            if (ember == gep) //ha ugyanaz, akkor döntetlen
            {
                return 0;
            }

            else if (gep == 0 && ember == 2 || gep == 1 && ember == 0 || gep == 2 && ember == 1)
            {
                return 1;
            }

            else
            {
                return 2;
            }
        }

        private static bool akarjatszani()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.Write("Tovább [i/n]?");
            string valasz = Console.ReadLine().ToLower();
            Console.WriteLine("\n-----------------------------------------------");

            if (valasz == "i")
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");      // \n - new line, \t - tabulátor
            //                                        // \ jelek közé írva illeszthetünk be különleges karaktereket

            //double tortjellegu = 10 / 3.0;          //egész szám osztva egész számmal egész számot ad vissza
            //Console.WriteLine(tortjellegu);         //racionális szám osztva egésszel racionálist ad

            //tortjellegu = 10 % 3.0;                 // % jellel maradékot kapunk vissza
            //Console.WriteLine(tortjellegu);



            bool tovabb = true;

            while (tovabb)
            {
                int gepvalasz = gepvalasztas();

                //Console.WriteLine("Gép választása: {0}", lehetoseg[gepvalasz]);

                int jatekosvalasz = jatekosvalasztas();

                //Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalasz]);

                eredmenykiiras(gepvalasz, jatekosvalasz);

                tovabb = akarjatszani();
            }

            Console.ReadKey();
        }
    }
}
