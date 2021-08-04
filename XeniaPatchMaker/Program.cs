using XeniaPatchMaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XeniaPatchMaker.Util;

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


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (MainForm == null)
            {
                //MainForm = new XPM();
                Application.Run(MainForm = new XPM()); 
            }

        }

    }
}
