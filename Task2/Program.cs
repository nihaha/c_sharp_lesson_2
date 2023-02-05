using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task2
{
    internal class Program
    {
        /** Используя Visual Studio, создайте проект по шаблону Console Application.
         * Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r.
         * Используя формулу πR 2 , вычислите площадь круга и выведите результат на экран.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Please, input the radius, m");

            double PI = Math.PI;
            double radius = Convert.ToDouble(Console.ReadLine());
            double square = Math.Round(Math.Pow(PI * radius, 2), 2);

            Console.WriteLine($"Circle square equals to {square} m2");
            Console.ReadLine();
        }
    }
}
