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
    public partial class Settings : DevExpress.XtraEditors.XtraForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            DisableDesc.Checked = Properties.Settings.Default.DisableDesc;
            WriteInfo.Checked = Properties.Settings.Default.WriteInfo;
            HideValueConverter.Checked = Properties.Settings.Default.HideValueConverter;
            AutoDelete.Checked = Properties.Settings.Default.AutoDelete;
            DisableMessageBox.Checked = Properties.Settings.Default.DisableMessageBox;
            ColorDisabled.Checked = Properties.Settings.Default.ColorDisabled;
            DefaultAuthors.Text = Properties.Settings.Default.DefaultAuthors;
            UseDefaultAuthors.Checked = Properties.Settings.Default.UseDefaultAuthors;
            UseDefaultAuthors.Checked = Properties.Settings.Default.UseDefaultAuthors;
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.WriteInfo = WriteInfo.Checked;
            Properties.Settings.Default.HideValueConverter = HideValueConverter.Checked;
            Properties.Settings.Default.DisableDesc = DisableDesc.Checked;
            Properties.Settings.Default.AutoDelete = AutoDelete.Checked;
            Properties.Settings.Default.DisableMessageBox = DisableMessageBox.Checked;
            Properties.Settings.Default.ColorDisabled = ColorDisabled.Checked;
            Properties.Settings.Default.DefaultAuthors = DefaultAuthors.Text;
            Properties.Settings.Default.UseDefaultAuthors = UseDefaultAuthors.Checked;
        }
    }
}