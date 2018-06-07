using System;

namespace atm
{
    public class Program
    {
        public static double Balance = 5000;

        public static void Main(string[] args)
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

            int selection = 0;

            try
            {
                selection = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry");
            }
            finally
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
                        Console.WriteLine($"Your balance is ${Balance}\n");
                        break;

                   case 4:
                       Environment.Exit(0);
                       break;

                   default:
                        Console.WriteLine("Not valid.  Select again.\n");
                        Options();
                        break;
               }

            }
            Options();
        }

        public static void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?\n");
            double userDeposit = 0;
            try
            {
                userDeposit = double.Parse(Console.ReadLine());
                if (userDeposit < 0)
                {
                    throw new Exception();
                }
                AddDeposit(userDeposit);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format.\n");
            }
            catch (Exception)
            {
                Console.WriteLine("Can't deposit negative numbers.\n");
                Deposit();
            }
        }

        public static double AddDeposit(double userDeposit)
        {
            Balance += userDeposit;
            return Balance;
        }

        public static void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?\n");

            double userWithdraw = 0;
            try
            {
                userWithdraw = double.Parse(Console.ReadLine());
                if (userWithdraw > Balance || userWithdraw < 0)
                {
                    Console.WriteLine("Try again.\n");
                    Options();
                }
                MinusWithdraw(userWithdraw);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong format.\n");
            }
        }

        public static double MinusWithdraw(double userWithdraw)
        {
            if (userWithdraw > Balance) Console.WriteLine("You don't have that much...");
            else Balance -= userWithdraw;
            return Balance;
        }

    }
}
