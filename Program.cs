using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmstrongNumber.model;



namespace ArmstrongNumber
    {
        internal class Program
        {
            static void Main(string[] args)
            {
            int number , choice;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter a Number:");
                

                while (true)
                {
                    number = int.Parse(Console.ReadLine());
                    if (number >= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a valid positive number:");
                }

                string result = Armstrong.IsArmstrong(number) ? "Armstrong Number" : "Not an Armstrong Number";
                Console.WriteLine(result);

                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Check another number");
                Console.WriteLine("2. Exit");

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

    

