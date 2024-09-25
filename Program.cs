using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumber.model;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter a Number:");
                int number;

                while (true)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < 1)
                    {
                        Console.WriteLine("Please enter a positive number:");
                        continue; 
                    }
                    break;
                }

                string result = Prime.IsPrime(number) ? "Prime Number" : "Not Prime Number";
                Console.WriteLine(result);

                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Check another number");
                Console.WriteLine("2. Exit");

                int choice;

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Program exited.");
        }

        
    }
}
    
