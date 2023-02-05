using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте две целочисленные переменные и выведите на экран результаты всех арифметических 
             * операций над этими двумя переменными.
             */

            int var_1 = 6;
            int var_2 = 9;

            Console.WriteLine($"{var_1} + {var_2} = {var_1 + var_2}");
            Console.WriteLine($"{var_1} - {var_2} = {var_1 - var_2}");
            Console.WriteLine($"{var_1} * {var_2} = {var_1 * var_2}");
            Console.WriteLine($"{var_1} / {var_2} = {Convert.ToDouble(var_1) / Convert.ToDouble(var_2)}");
            Console.WriteLine($"{var_1} ** {var_2} = {Math.Pow(var_1, var_2)}");
            Console.WriteLine($"{var_1} % {var_2} = {var_1 % var_2}");

            Console.ReadLine();
        }
    }
}
