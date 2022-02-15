using System;
using System.Windows.Forms;

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
    }
}
