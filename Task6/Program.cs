using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task6
{
    internal class Program
    {
        /** Используя Visual Studio, создайте проект по шаблону Console Application.
         * Написать программу для расчета скидки за покупку, скидку и цену товара должен
         * осуществлять пользователь.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Please, input price value");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, input discount value");
            double discount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The discount equals to {100 * discount / price}%");
            Console.ReadLine();
        }
    }
}
