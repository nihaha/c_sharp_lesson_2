using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task1
{
    internal class Program
    {
        /** Используя Visual Studio, создайте проект по шаблону Console Application. 
         * Создайте программу для перевода метров в сантиметры (1м = 100см), 
         * ввод метров должен осуществлять пользователь. 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Please, input the number of meters");

            double meters = Convert.ToDouble(Console.ReadLine());
            double centimeters = meters * 100;

            Console.WriteLine($"{meters} meters equals to {centimeters} centimeters.");
            Console.ReadLine();
        }
    }
}
