using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeniaPatchMaker
{
    static class Program
    {
        public static XPM MainForm { get; set; }
        public static Settings Settings { get; set; }
        public static ValueConverter valueConverter { get; set; }
        public static Loading_Screen Load { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (MainForm == null)
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //use the creation on the main Form To have More Control
                MainForm = new XPM();
                Application.Run(MainForm);
            }


        }
    }
}
