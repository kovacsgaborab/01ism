using System;

namespace _01ism
{
    class Program
    {
        static string[] lehetoseg = new string[] { "kő", "papír", "olló" }; //felsoroljuk az elemeit, és innen tudja hány elemű
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
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");      // \n - new line, \t - tabulátor
            //                                        // \ jelek közé írva illeszthetünk be különleges karaktereket

            //double tortjellegu = 10 / 3.0;          //egész szám osztva egész számmal egész számot ad vissza
            //Console.WriteLine(tortjellegu);         //racionális szám osztva egésszel racionálist ad

            //tortjellegu = 10 % 3.0;                 // % jellel maradékot kapunk vissza
            //Console.WriteLine(tortjellegu);

            Random vel = new Random(); //random változó

            

            int gepvalasz = vel.Next(0, 3);  //választ egy random számot 0-2-ig

            //Console.WriteLine("Gép választása: {0}", lehetoseg[gepvalasz]);

            int jatekosvalasz;

            Console.WriteLine("kő {0}, papír {1}, olló {2}");
            Console.Write("Válasz: ");
            jatekosvalasz = Convert.ToInt32(Console.ReadLine()); //értéket adunk a jatekosvalasz változónak

            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalasz]);

            eredmenykiiras(gepvalasz, jatekosvalasz);

            Console.ReadKey();
        }
    }
}
