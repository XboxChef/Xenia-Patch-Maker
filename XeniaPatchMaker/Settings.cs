using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeniaPatchMaker
{
    public partial class Settings : XtraForm
    {
        public Settings()
        {
            InitializeComponent();
            if (xtraTabControl1.SelectedTabPage == xtraTabPage3)
            {
                Text = "About Us";
            }
            else
            {
                Text = "Patch Maker Settings";
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void xtraTabControl1_Selecting(object sender, DevExpress.XtraTab.TabPageCancelEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage3)
            {
                Text = "About Us";
            }
            else
            {
                Text = "Patch Maker Settings";
            }
        }
    }
}
