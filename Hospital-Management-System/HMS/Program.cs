
using HMS.Medicines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
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

            if (Screen.PrimaryScreen.Bounds.Width >= 1280 && Screen.PrimaryScreen.Bounds.Height >= 768)
            {
                Application.Run(new Layout());
            }
            else
            {
                Application.Run(new ScreenError());
            }
        }
    }
}
