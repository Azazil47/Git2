using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Git2
{
    static class Program
    {
        public static String line;
        public static String line2;
        /// <summary>
        /// Главная точка входа для приложения.
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
