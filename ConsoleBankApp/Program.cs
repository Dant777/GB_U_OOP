using System;
using GB_U_OOP;

namespace ConsoleBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber a = new RationalNumber(3, 5);
            RationalNumber b = new RationalNumber(2, 15);

           // RationalNumber s = a + b;
            a++;
            Console.WriteLine(a.ToString());

            Console.ReadKey();
        }
    }

}