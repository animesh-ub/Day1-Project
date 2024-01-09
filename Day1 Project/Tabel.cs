using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day1_Project
{
    internal class Tabel
    {
        public static void Main(string[] args)
        {
            int number1 = 5; // You can change the number for which you want to display the table
            int number2 = 9;
            int number3 = 7;

            Console.WriteLine($"Table of {number1} using for loop:");
            DisplayTableWithFor(number1);

            Console.WriteLine($"\nTable of {number2} using while loop:");
            DisplayTableWithWhile(number2);

            Console.WriteLine($"\nTable of {number3} using do-while loop:");
            DisplayTableWithDoWhile(number3);
        }

        static void DisplayTableWithFor(int number1)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number1} * {i} = {number1 * i}");
            }
        }

        static void DisplayTableWithWhile(int number2)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{number2} * {i} = {number2 * i}");
                i++;
            }
        }

        static void DisplayTableWithDoWhile(int number3)
        {
            int i = 1;
            do
            {
                Console.WriteLine($"{number3} * {i} = {number3 * i}");
                i++;
            } while (i <= 10);
        }
    }
        
}
