using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        public static double Fun(int x, int y)
        {
            return (Math.Sqrt(x) + x) / (Math.Sqrt(y) + y);
        }
        static void Main()
        {
            Console.Write($"x= {Fun(5, 7) + Fun(12, 8) + Fun(19, 2):f2}");
            Console.Read();
        }
    }
}
