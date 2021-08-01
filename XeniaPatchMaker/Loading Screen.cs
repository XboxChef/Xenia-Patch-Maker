using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XeniaPatchMaker.Util;

namespace XeniaPatchMaker
{
    public partial class Loading_Screen : SplashScreen
    {
        public Loading_Screen()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        public static string UpToDate { get; internal set; }

        private void Loading_Screen_Shown(object sender, EventArgs e)
        {

            timer1.Interval = 3000;
            
            timer1.Start();


        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            labelStatus.Text = "Starting...";
            Program.Load.Close();
            Program.MainForm.Hide();
            PatchUtil.CheckUpdates();
            timer1.Stop();
        }
    }
}