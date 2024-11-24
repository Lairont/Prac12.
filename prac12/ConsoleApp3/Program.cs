using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    /// <summary>
    /// Задача 3. Найти максимальную величину из двух целых переменных a, b с использованием вспомогательных методов.
    /// </summary>
    internal class Program
    {
        public static int Function(int a, int b)
        {
           return a > b ? a : b;
        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Function(a, b));
            Console.ReadLine();
        }
    }
}
