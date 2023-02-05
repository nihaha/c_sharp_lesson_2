using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        /**
         * Используя Visual Studio, создайте проект по шаблону Console Application. 
         * Имеется 3 переменные типа int x = 10, y = 12, и z = 3; Выполните и рассчитайте результат 
         * следующих операций для этих переменных: 
         * x += y - x++ * z;
         * z = --x – y * 5;
         * y /= x + 5 % z;
         * z = x++ + y * 5;
         * x = y - x++ * z;
         */

        static void Main(string[] args)
        {
            int x = 10, 
                y = 12,
                z = 3;

            Console.WriteLine($"x += y - x++ * z equals to {x += y - x++ * z}");
            Console.WriteLine($"z = --x – y * 5 equals to {z = --x - y * 5}");
            Console.WriteLine($"y /= x + 5 % z equals to {y /= x + 5 % z}");
            Console.WriteLine($"z = x++ + y * 5 equals to {z = x++ + y * 5}");
            Console.WriteLine($"x = y - x++ * z equals to {x = y - x++ * z}");

            Console.ReadLine();
        }
    }
}
