using XeniaPatchMaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XeniaPatchMaker.Util;
using System.IO;

namespace XeniaPatchMaker
{
    static class Program
    {
        public static XPM MainForm { get; set; }
        public static Settings Settings { get; set; }
        public static ValueConverter valueConverter { get; set; }
        public static Loading_Screen Load { get; set; }
        public static Find Finder { get; set; }
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (MainForm == null)
            {
                Application.Run(MainForm = new XPM(args));
            }

        }

        private static void Start(string Path)
        {

        }
    }
}
