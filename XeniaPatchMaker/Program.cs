using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeniaPatchMaker
{
    static class Program
    {
        static XPM xPFM;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (xPFM == null)
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                xPFM = new XPM();
                Application.Run(xPFM);
            }


        }
    }
}
