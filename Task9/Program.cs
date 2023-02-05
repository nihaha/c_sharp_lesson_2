using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        /** Используя Visual Studio, создайте проект по шаблону Console Application. 
         * Напишите программу расчета объема - V и площади поверхности -S цилиндра. 
         * Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πr 2h. 
         * Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR(R+h). Результаты расчетов выведите на экран. 
         * Пользователь должен иметь возможность вводит r – радиус цилиндра и h – высоту цилинда.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Please, input cylinder height, m");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, input cylinder radius, m");
            double radius = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI + Math.Pow(radius, 2) * height;
            double square = 2 * Math.PI * radius * (radius + height);

            Console.WriteLine($"Cylinder volume is {Math.Round(volume, 2)} m3");
            Console.WriteLine($"Cylinder square is {Math.Round(square, 2)} m2");
            Console.ReadLine();
        }
    }
}
