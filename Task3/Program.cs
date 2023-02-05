using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task3
{
    internal class Program
    {
        /** Используя Visual Studio, создайте проект по шаблону Console Application.
         * Создать программу для определения гипотенузы прямоугольного треугольника,
         * используя формулу с = √a2 + b2, где с – гипотенуза, а b и a катеты прямоугольного треугольника. 
         * Ввод катетов должен осуществлять пользователь.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Please, input first cathetus");
            double cathetus_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, input second cathetus");
            double cathetus_2 = Convert.ToDouble(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(cathetus_1, 2) + Math.Pow(cathetus_2, 2));

            Console.WriteLine($"Hypotenuse of your triangle equeal to {hypotenuse}");
            Console.ReadLine();
        }
    }
}
