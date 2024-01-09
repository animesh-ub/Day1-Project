using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Project
{
    internal class DisplayInt
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter intergenr in one Line");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);

            Console.Write(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
