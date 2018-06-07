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
            //test for cases where the user enters in anything other than a number
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
                //this will run so that they can proceed with their transactions
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
            //if a user enters in a negative number, this will catch it
            try
            {
                userDeposit = double.Parse(Console.ReadLine());
                if (userDeposit < 0)
                {
                    throw new Exception();
                }
                AddDeposit(userDeposit);
            }
            catch (FormatException)//this accounts for different forms that are not numbers
            {
                Console.WriteLine("Wrong format.\n");
            }
            catch (Exception)//a user will be told they cannot enter in a negative number
            {
                Console.WriteLine("Can't deposit negative numbers.\n");
                Deposit();
            }
        }
        //add to the running balance
        public static double AddDeposit(double userDeposit)
        {
            Balance += userDeposit;
            Console.WriteLine($"Your balance is ${Balance}\n");
            return Balance;
        }

        public static void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?\n");

            double userWithdraw = 0;
            //if a user tries to withdraw more than their balance, this will catch it
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
            catch (Exception)//this will catch other forms that are not numbers
            {
                Console.WriteLine("Wrong format.\n");
            }
        }
        //withdraws from the running balance
        public static double MinusWithdraw(double userWithdraw)
        {
            if (userWithdraw > Balance) Console.WriteLine("You don't have that much...");
            else Balance -= userWithdraw;
            Console.WriteLine($"Your balance is ${Balance}\n");
            return Balance;
        }

    }
}
