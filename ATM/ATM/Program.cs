using System;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Default values for user's balance and menu selection
            uint balance = 9999;
            string selection = "";

            // This loop contains the logic and UI for the main menu. The user may enter a selection to use different function of the app. Any exceptions will print a brief message and prompt the user to enter again.
            while (selection != "4")
            {
                Console.WriteLine("Welcome to Mike's ATM!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Exit");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("Choose a selection (1, 2, 3, or 4): ");
                try
                {
                    selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine($"Your current balance is ${balance}");
                            break;
                        case "2":
                            uint drawAmt;
                            Console.Clear();
                            Console.WriteLine($"Current balance: ${balance}");
                            Console.Write("Enter the amount you would like to withdraw: $");
                            drawAmt = Convert.ToUInt32(Console.ReadLine());
                            if (drawAmt > balance)
                            {
                                Console.Clear();
                                Console.WriteLine("Sorry, you do not have the sufficient funds to withdraw that amount.");
                            } else
                            {
                                balance = Withdraw(balance, drawAmt);
                                Console.Clear();
                                Console.WriteLine($"${drawAmt} has been withdrawn from your account. Your new balance is ${balance}");
                            }
                            break;
                        case "3":
                            uint addAmt;
                            Console.Clear();
                            Console.WriteLine($"Current balance: ${balance}");
                            Console.Write("Enter the amount you would like to deposit: $");
                            addAmt = Convert.ToUInt32(Console.ReadLine());
                            balance = Deposit(balance, addAmt);
                            Console.Clear();
                            Console.WriteLine($"${addAmt} has been added to your account. You new balance is ${balance}");
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("Thank you for using Mike's ATM!");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.ReadKey();
                            break;
                        default:
                            throw new Exception("Please choose one of the given options.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                finally
                {
                    Console.Clear();
                }
            }
        }

        // Returns the user's balance minus the amount requested to withdraw
        public static uint Withdraw(uint balance, uint amount)
        {
            return balance - amount;
        }

        // Returns the user's balance plus the deposited amount
        public static uint Deposit(uint balance, uint amount)
        {
            return balance + amount;
        }

    }
}
