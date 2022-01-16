using System;
using GB_U_OOP;

namespace ConsoleBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount a = new BankAccount(50000);
            BankAccount a1 = new BankAccount(50000);
            BankAccount b = new BankAccount(10000);

           
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine("======================");
            Console.WriteLine(a == a1);
            Console.WriteLine(a != a1);

            Console.ReadKey();
        }
    }

}