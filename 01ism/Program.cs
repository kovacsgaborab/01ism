using System;

namespace _01ism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");      // \n - new line, \t - tabulátor
            //                                        // \ jelek közé írva illeszthetünk be különleges karaktereket

            //double tortjellegu = 10 / 3.0;          //egész szám osztva egész számmal egész számot ad vissza
            //Console.WriteLine(tortjellegu);         //racionális szám osztva egésszel racionálist ad

            //tortjellegu = 10 % 3.0;                 // % jellel maradékot kapunk vissza
            //Console.WriteLine(tortjellegu);

            Random vel = new Random(); //random változó

            string[] lehetoseg = new string[] { "kő", "papír", "olló" }; //felsoroljuk az elemeit, és innen tudja hány elemű

            int gepvalasz = vel.Next(0, 3);  //választ egy random számot 0-2-ig

            Console.WriteLine("Gép választása: {0}", lehetoseg[gepvalasz]);



            Console.ReadKey();
        }
    }
}
