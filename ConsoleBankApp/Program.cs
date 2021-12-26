using System;
using GB_U_OOP;

namespace ConsoleBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создать класс счет в банке с закрытыми полями: номер счета, баланс,
             * тип банковского счета (использовать перечислимый тип).
             * Предусмотреть методы для доступа к данным – заполнения и чтения.
             * Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать
             */
            BankАccountType1 account1 = new BankАccountType1(1, 1000, TypeAccount.FrozenAccount);
            BankАccountType1 account2 = new BankАccountType1(2, 2000, TypeAccount.FrozenAccount);

            PrintInfo(account1);
            PrintInfo(account2);

            /*
             * Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
             * Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.
             */
            Console.WriteLine("=======================================\n");
            BankАccountType2 accountTyp2_1 = new BankАccountType2(1000, TypeAccount.FrozenAccount);
            BankАccountType2 accountTyp2_2 = new BankАccountType2( 2000, TypeAccount.FrozenAccount);

            PrintInfo(accountTyp2_1);
            PrintInfo(accountTyp2_2);


            /*
             * В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.
             */

            Console.WriteLine("=======================================\n");
            BankАccountType3 accountTyp3_1 = new BankАccountType3(1000, TypeAccount.FrozenAccount);
            BankАccountType3 accountTyp3_2 = new BankАccountType3(2000, TypeAccount.FrozenAccount);
            BankАccountType3 accountTyp3_3 = new BankАccountType3(3000, TypeAccount.FrozenAccount);

            PrintInfo(accountTyp3_1);
            PrintInfo(accountTyp3_2);
            PrintInfo(accountTyp3_3);

            Console.ReadKey();
        }

        private static void PrintInfo(BankАccountType1 acc)
        {
            Console.WriteLine($"Account Id - {acc.GetId()}: \n\t-Money: {acc.GetMoneyInAcc()}$ \n\t-Type account: {acc.GetTypeAccount()}");
        }

        private static void PrintInfo(BankАccountType2 acc)
        {
            Console.WriteLine($"Account Id - {acc.GetId()}: \n\t-Money: {acc.GetMoneyInAcc()}$ \n\t-Type account: {acc.GetTypeAccount()}");
        }

        private static void PrintInfo(BankАccountType3 acc)
        {
            Console.WriteLine($"Account Id - {acc.Id}: \n\t-Money: {acc.MoneyInAcc}$ \n\t-Type account: {acc.TypeAccount}");
        }
    }
}
