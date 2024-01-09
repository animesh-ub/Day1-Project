using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Project
{
    internal class While_doWhile
    {
        static void Main()
        {
            Console.WriteLine("Using do-while loop:");
            DisplayEvenWithDoWhile();

            Console.WriteLine("\nUsing while loop:");
            DisplayEvenWithWhile();

            Console.WriteLine("\nUsing for loop:");
            DisplayEvenWithFor();
        }

        static void DisplayEvenWithDoWhile()
        {
            int i = 2;
            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= 10);
        }

        static void DisplayEvenWithWhile()
        {
            int i = 2;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }

        static void DisplayEvenWithFor()
        {
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }

}
