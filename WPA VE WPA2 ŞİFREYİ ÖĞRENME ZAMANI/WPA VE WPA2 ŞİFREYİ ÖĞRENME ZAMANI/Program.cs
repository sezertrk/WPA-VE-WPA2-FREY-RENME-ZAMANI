using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WPA_VE_WPA2_ŞİFREYİ_ÖĞRENME_ZAMANI
{
    static class Program
    {
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
