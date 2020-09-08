using System;

namespace _01ism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");      // \n - new line, \t - tabulátor
                                                    // \ jelek közé írva illeszthetünk be különleges karaktereket

            double tortjellegu = 10 / 3.0;          //egész szám osztva egész számmal egész számot ad vissza
            Console.WriteLine(tortjellegu);         //racionális szám osztva egésszel racionálist ad

            tortjellegu = 10 % 3.0;                 // % jellel maradékot kapunk vissza
            Console.WriteLine(tortjellegu);

            Console.ReadKey();
        }
    }
}
