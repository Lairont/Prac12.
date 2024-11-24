using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    /// <summary>
    /// Задача 6. Вывести дни недели в зависимости от номера дня с использованием вспомогательного метода.
    /// </summary>
    internal class Program
    {
       public static string Week(byte day)
        {
            switch(day)
            { 
            case 1:
                return "Понедельник";
            case 2:
                return "Вторник";
            case 3:
                return "Среда";
            case 4:
                return "Четверг";
            case 5:
                return "Пятница";
            case 6:
                return "Суббота";
            case 7:
                return "Воскресенье";
            default:
                return "Ошибка";
            }
         }
        static void Main()
        {
            Console.Write("Введит от 1 до 7: ");
            byte Number = byte.Parse(Console.ReadLine());
            Console.WriteLine($"{Week(Number)}");
            Console.ReadLine();
        }
    }
}
