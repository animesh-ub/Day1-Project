using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Project
{
    internal class Gapof3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("100 to 5 with Gap of 3");
                
            {

                for (int i = 100; i >= 5; i -= 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
