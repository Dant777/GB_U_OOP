using System;
using GB_U_OOP;
using GB_U_OOP.BankEntities;
using GB_U_OOP.BankEntities.Base;

namespace ConsoleBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой.
             * У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.
             */
            BankАccount acc1 = new BankАccount(1000);
            BankАccount acc2 = new BankАccount(500);
            PrintInfo(acc1);
            PrintInfo(acc2);
            Console.WriteLine("================================");//Success
            MoneyTransfer(acc1, acc2, 100);

            Console.WriteLine("================================");//Error
            MoneyTransfer(acc1, acc2, 901);
            

            /*
             * Реализовать метод, который в качестве входного параметра принимает строку
             * string, возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.
             */
            Console.WriteLine("\n******************************");
            string testTxt = "string revers";
            Console.WriteLine(testTxt);
            Console.WriteLine(ReversString(testTxt));

            Console.ReadKey();
        }


        private static void PrintInfo(BaseBankАccount acc)
        {
            Console.WriteLine($"Account Id - {acc.Id}: \n\t-Money: {acc.MoneyInAcc}$ \n\t-Type account: {acc.TypeAccount}");
        }

        private static void MoneyTransfer(BaseBankАccount accOut, BaseBankАccount accTo, decimal transferMoney)
        {

            if (accOut.MoneyToAnotherAcc(accTo, transferMoney))
            {
                Console.WriteLine("---SUCCESS---");
                PrintInfo(accOut);
                PrintInfo(accTo);
            }
            else
            {
                Console.WriteLine("---TRANSFER ERROR---");
            }

        }

        private static string ReversString(string txt)
        {
            string reversTxt = String.Empty;

            for (int i = txt.Length - 1; i >= 0; i--)
            {
                reversTxt += txt[i];
            }
            return reversTxt;

        }
    }
}
