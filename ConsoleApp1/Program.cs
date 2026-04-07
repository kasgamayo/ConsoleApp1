// See https://aka.ms/new-console-template for more information
using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
            bool isRunning = true;

            Console.WriteLine("Welcome to the Simple Banking! What is your name?");
            string name = Console.ReadLine();

            while (isRunning)
            {
                Console.WriteLine("\nHello " + name + ", what would you like to do?");
                Console.WriteLine("1 - Check balance");
                Console.WriteLine("2 - Deposit");
                Console.WriteLine("3 - Withdraw");
                Console.WriteLine("4 - Exit");
                Console.Write("Enter your answer: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Your current balance is: " + balance);
                        break;

                    case "2":
                        Console.Write("Enter amount to deposit:");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        balance = balance + depositAmount;
                        Console.WriteLine("Deposit successful!\nNew balance: " + balance);
                        break;

                    case "3":
                        Console.Write("Enter amount to withdraw:");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        bool hasEnoughBalance = balance >= withdrawAmount;

                        if (hasEnoughBalance)
                        {
                            balance = balance - withdrawAmount;
                            Console.WriteLine("Withdrawal successful!\nNew balance: " + balance);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds! Cannot withdraw " + withdrawAmount + ". Current balance is: " + balance);
                        }
                        break;

                    case "4":
                        isRunning = false;
                        Console.WriteLine("Thank you for banking with us, " + name + "!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose 1, 2, 3, or 4.");
                        break;
                }
            }
        }
    }
}
