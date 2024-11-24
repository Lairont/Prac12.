using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    /// <summary>
    /// Задача 5. Найти s=max(a, b) + max(c, d), используя вспомогательную функцию (метод).
    /// </summary>
    internal class Program
    {
        public static int Max(int x, int y)
        {
            return x > y ? x : y; 
        }

        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine($"s={Max(a, b) + Max(c, d)}");
            Console.ReadLine();
        }
    }
}
