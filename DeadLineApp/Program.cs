using System;
using System.Windows.Forms;

namespace DeadLineApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDeadLine());          
        }
    }
}
