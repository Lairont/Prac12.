using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    /// <summary>
    /// Задача 4. Найти максимальную величину их трех целых переменных a, b, c с использованием вспомогательных методов. 
    /// </summary>
    internal class Program
    {
        public static int Function(int a, int b, int c)
        {
            return a > b ? (a > c ? a : c) : (b > c ? b : c);
        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Function(a, b, c));
            Console.ReadLine();
        }
    }
}
