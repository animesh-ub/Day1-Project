using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Project
{
    internal class OddLoop
    {
            public static void Main(string[] args)
            {
                Console.WriteLine("Using do-while loop:");
                DisplayOddWithDoWhile();

                Console.WriteLine("\nUsing while loop:");
                DisplayOddWithWhile();

                Console.WriteLine("\nUsing for loop:");
                DisplayOddWithFor();
            }

            static void DisplayOddWithDoWhile()
            {
                int i = 1;
                do
                {
                    Console.WriteLine(i);
                    i += 2;
                } while (i <= 10);
            }

            static void DisplayOddWithWhile()
            {
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine(i);
                    i += 2;
                }
            }

            static void DisplayOddWithFor()
            {
                for (int i = 1; i <= 10; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
    }
}
