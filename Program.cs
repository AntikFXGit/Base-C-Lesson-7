using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Base_C_Lesson_7
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Задача 1
            Form form = new Form1();

            // Задача 2
            Form form2 = new Form2();

            // Запуск...
            Application.Run(form2);
        }



    }
}
