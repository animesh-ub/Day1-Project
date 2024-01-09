using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Project
{
    internal class LoopName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();
            for(int i = 0;i < 10; i++)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
