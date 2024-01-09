using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Project
{
    internal class Program2
    {

        static void Main()
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
            }
            else if (choice == 2)
            {
                Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
            }
            else if (choice == 3)
            {
                Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
            }
            else if (choice == 4)
            {
                Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
            }

        }
    }
}
