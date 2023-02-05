using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7
{
    internal static class Program
    {
        /** Используя Visual Studio, создайте проект по шаблону Windows Forms (.Net framework). 
         * Создайте программу для расчета возраста пользователя, по введенному им году рождения 
         * необходимо вывести его текущий возраст. (использовать DateTime).
         */


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
