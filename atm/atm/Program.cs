using System;

namespace atm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the bestest ATM!\n" +
                "What would you like to do?\n" +
                "1. Deposit\n" +
                "2. Withdraw\n" +
                "3. View Balance\n" +
                "4. Exit\n");

            Console.Read();
        }
    }
}
