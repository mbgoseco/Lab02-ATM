using System;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            uint balance = 9999;
            string selection = "";

            while (selection != "4")
            {
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Exit");
                Console.Write("Choose a selection (1, 2, 3, or 4): ");
                try
                {
                    selection = Console.ReadLine();
                    //switch here
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void ViewBalance(uint balance)
        {

        }

        public static uint Withdraw(uint balance, uint amount)
        {

        }

        public static uint Deposit(uint balance, uint amount)
        {

        }

    }
}
