using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        public static double Fun(int x)
        {
            return (Math.Sqrt(x) + x) / 2;
        }
        static void Main()
        {
            Console.Write($"Y= {Fun(5)+Fun(12)+Fun(19):f2}");
            Console.ReadLine();
        }
    }
}
