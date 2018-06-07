using System;

namespace atm
{
    class Program
    {
        public static decimal Balance = 5000m;

        static void Main(string[] args)
        {
            Options();
            Console.Read();
        }

        public static void Options()
        {
            Console.WriteLine("Welcome to the bestest ATM!\n" +
                "What would you like to do?\n" +
                "1. Deposit\n" +
                "2. Withdraw\n" +
                "3. View Balance\n" +
                "4. Exit\n");

            int selection = int.Parse(Console.ReadLine());

            UserSelection(selection);
            Console.WriteLine($"Balance is now {Balance}");
        }

        public static void UserSelection(int selection)
        {
           switch (selection)
           {
               case 1:
                   Deposit();
               break;

               case 2:
                    Withdraw();
               break;

               case 3:

               break;

               case 4:
                   Environment.Exit(0);
                   break;

               default:
                    Console.WriteLine("Not valid.  Select again");
                    Options();
                    break;
           }
        }

        public static decimal Deposit()
        {
            Console.WriteLine("How much would you like to deposit?\n");
            decimal userDeposit = decimal.Parse(Console.ReadLine());
            Balance += userDeposit;
            return Balance;
        }

        public static decimal Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            decimal userWithdraw = decimal.Parse(Console.ReadLine());
            if (userWithdraw > Balance)
            {
                Console.WriteLine("You're withdrawing too much");
                Withdraw();
            }
            else
            {
                Balance -= userWithdraw;
            }
            return Balance;
        }
    }
}
