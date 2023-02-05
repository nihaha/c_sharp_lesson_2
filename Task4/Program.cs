using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task4
{
    internal class Program
    {
        /** Используя Visual Studio, создайте проект по шаблону Console Application.
         * Создать программу для определения синуса угла, ввод угла должен осуществлять пользователь.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Please, input angle value");
            double angle = Convert.ToDouble(Console.ReadLine());

            if (angle <= 180) {
                // double sin = Math.Sin(angle);
                double sin = 4 * angle * (180 - angle) / (40500 - angle * (180 - angle));
                Console.WriteLine($"Sin of the given angle equals to {sin}");
            } else {
                Console.WriteLine("The value should be between 0 and 180");
            }            

            Console.ReadLine();
        }
    }
}
