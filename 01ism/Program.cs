using System;
using System.IO;
namespace _01ism
{
    class Program
    {
        static string[] lehetoseg = new string[] { "kő", "papír", "olló" }; //felsoroljuk az elemeit, és innen tudja hány elemű

        static int gepnyer = 0;
        static int jatekosnyer = 0;
        static int menet = 0;

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
                gepnyer++;
                return 1;
            }

            else
            {
                jatekosnyer++;
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

            statisztikafilebol();

            bool tovabb = true;

            while (tovabb)
            {
                menet++;

                int gepvalasz = gepvalasztas();

                //Console.WriteLine("Gép választása: {0}", lehetoseg[gepvalasz]);

                int jatekosvalasz = jatekosvalasztas();

                //Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalasz]);

                eredmenykiiras(gepvalasz, jatekosvalasz);

                tovabb = akarjatszani();
            }

            statisztikakiiras();
            statisztikafileba();

            Console.ReadKey();
        }

        private static void statisztikafilebol()
        {
            StreamReader stat = new StreamReader("statisztika.txt");

            

            while (!stat.EndOfStream)
            {
                string[] szovegadat = stat.ReadLine().Split(';');
                int[] adat = new int[3];

                for (int i = 0; i < adat.Length; i++)
                {
                    adat[i] = int.Parse(szovegadat[i]);
                }

                Console.WriteLine("{0} {1} {2}", adat[0], adat[1], adat[2]);
            }
            stat.Close();

            Console.WriteLine("--------------------statisztika vége----------------------");
        }

        private static void statisztikakiiras()
        {
            Console.WriteLine("\t Menetek száma: {0}" +
                "\t Játékos győzelmének száma: {1}" +
                "\t Gép győzelmének száma: {2}", menet, jatekosnyer, gepnyer);

        }

        private static void statisztikafileba()
        {
            StreamWriter sw = new StreamWriter("statisztika.txt");
            for (int i = 0; i < length; i++)
            {
                sw.Write(menet, jatekosnyer, gepnyer);
            }


            sw.Close();
        }
    }
}
