using System;
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
            try
            {
                WriteInfo.Checked = Properties.Settings.Default.WriteInfo;
                AutoDelete.Checked = Properties.Settings.Default.AutoDelete;
                DisableMessageBox.Checked = Properties.Settings.Default.DisableMessageBox;
                ColorDisabled.Checked = Properties.Settings.Default.ColorDisabled;
                DefaultAuthors.Text = Properties.Settings.Default.DefaultAuthors;
                UseDefaultAuthors.Checked = Properties.Settings.Default.UseDefaultAuthors;
                UseDefaultAuthors.Checked = Properties.Settings.Default.UseDefaultAuthors;
                AddressMath.Value = Properties.Settings.Default.AddressMath;
                DefaultSavePath.Checked = Properties.Settings.Default.SavePathBool;
                textEdit1.Text = Properties.Settings.Default.SavedPath;
                LoadColors();

                if (Properties.Settings.Default.HideValueConverter == true)
                {
                    HideValueConverter.Checked = false;
                }
                if (Properties.Settings.Default.HideValueConverter == false)
                {
                    HideValueConverter.Checked = true;
                }
            }
            catch 
            {

            }
        }

        private void LoadColors()
        {
            // Color settings
            PatchUseColor.Checked = Properties.Settings.Default.PatchUseColor;
            PatchInfoUseColor.Checked = Properties.Settings.Default.PatchInfoUseColor;
            MainUseColor.Checked = Properties.Settings.Default.MainUseColor;
            // End of color settings
            MainColor1.Color = MainColorLabel1.ForeColor = Properties.Settings.Default.mainheadercolor1;
            MainColor2.Color = MainColorLabel2.ForeColor = Properties.Settings.Default.mainheadercolor2;
            MainColor3.Color = MainColorLabel3.ForeColor = Properties.Settings.Default.mainheadercolor3;
            MainColor4.Color = MainColorLabel4.ForeColor = Properties.Settings.Default.mainheadercolor4;
            PatchInfoColor1.Color = PatchInfoColorLabel1.ForeColor = Properties.Settings.Default.patchInfoColor1;
            PatchInfoColor2.Color = PatchInfoColorLabel2.ForeColor = Properties.Settings.Default.patchInfoColor2;
            PatchInfoColor3.Color = PatchInfoColorLabel3.ForeColor = Properties.Settings.Default.patchInfoColor3;
            PatchAddressColor1.Color = PatchAddressColorlabel1.ForeColor = Properties.Settings.Default.PatchAddressColor1;
            PatchAddressColor2.Color = PatchAddressColorlabel2.ForeColor = Properties.Settings.Default.PatchAddressColor2;
            PatchAddressColor3.Color = PatchAddressColorlabel3.ForeColor = Properties.Settings.Default.PatchAddressColor3;
            PatchAddressColor4.Color = PatchAddressColorlabel4.ForeColor = Properties.Settings.Default.PatchAddressColor4;
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();

            Properties.Settings.Default.AddressMath = (int)AddressMath.Value;
            Properties.Settings.Default.WriteInfo = WriteInfo.Checked;
            // if true, hide, if not leave it visible
            if (HideValueConverter.Checked == true)
            {
                Properties.Settings.Default.HideValueConverter = false;
            }
            else
            {
                Properties.Settings.Default.HideValueConverter = true;
            }
            Properties.Settings.Default.AutoDelete = AutoDelete.Checked;
            Properties.Settings.Default.DisableMessageBox = DisableMessageBox.Checked;
            Properties.Settings.Default.ColorDisabled = ColorDisabled.Checked;
            Properties.Settings.Default.DefaultAuthors = DefaultAuthors.Text;
            Properties.Settings.Default.UseDefaultAuthors = UseDefaultAuthors.Checked;
        }

        private void ColorControl_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ActiveControl != null)
                {
                    switch (ActiveControl.Name)
                    {
                        case "MainColor1":
                            MainColorLabel1.ForeColor = MainColor1.Color;
                            Properties.Settings.Default.mainheadercolor1 = MainColorLabel1.ForeColor;

                            break;
                        case "MainColor2":
                            MainColorLabel2.ForeColor = MainColor2.Color;
                            Properties.Settings.Default.mainheadercolor2 = MainColorLabel2.ForeColor;

                            break;
                        case "MainColor3":
                            MainColorLabel3.ForeColor = MainColor3.Color;
                            Properties.Settings.Default.mainheadercolor3 = MainColorLabel3.ForeColor;

                            break;
                        case "MainColor4":
                            MainColorLabel4.ForeColor = MainColor4.Color;
                            Properties.Settings.Default.mainheadercolor4 = MainColorLabel4.ForeColor;

                            break;
                        case "PatchInfoColor1":
                            PatchInfoColorLabel1.ForeColor = PatchInfoColor1.Color;
                            Properties.Settings.Default.patchInfoColor1 = PatchInfoColorLabel1.ForeColor;

                            break;
                        case "PatchInfoColor2":
                            PatchInfoColorLabel2.ForeColor = PatchInfoColor2.Color;
                            Properties.Settings.Default.patchInfoColor2 = PatchInfoColorLabel2.ForeColor;

                            break;
                        case "PatchInfoColor3":
                            PatchInfoColorLabel3.ForeColor = PatchInfoColor3.Color;
                            Properties.Settings.Default.patchInfoColor3 = PatchInfoColorLabel3.ForeColor;

                            break;
                        case "PatchAddressColor1":
                            PatchAddressColorlabel1.ForeColor = PatchAddressColor1.Color;
                            Properties.Settings.Default.PatchAddressColor1 = PatchAddressColorlabel1.ForeColor;

                            break;
                        case "PatchAddressColor2":
                            PatchAddressColorlabel2.ForeColor = PatchAddressColor2.Color;
                            Properties.Settings.Default.PatchAddressColor2 = PatchAddressColorlabel2.ForeColor;

                            break;
                        case "PatchAddressColor3":
                            PatchAddressColorlabel3.ForeColor = PatchAddressColor3.Color;
                            Properties.Settings.Default.PatchAddressColor3 = PatchAddressColorlabel3.ForeColor;

                            break;
                        case "PatchAddressColor4":
                            PatchAddressColorlabel4.ForeColor = PatchAddressColor4.Color;
                            Properties.Settings.Default.PatchAddressColor4 = PatchAddressColorlabel4.ForeColor;

                            break;
                    }
                }
            }
            catch
            {
            }
        }

        private void MainColor1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }

        private void UseColorSettings_Checkbox(object sender, EventArgs e)
        {
            if (ActiveControl != null)
            {
                switch (ActiveControl.Name)
                {
                    case "DefaultSavePath":
                        Properties.Settings.Default.SavePathBool = DefaultSavePath.Checked;
                        break;
                    case "PatchUseColor":
                        Properties.Settings.Default.PatchUseColor = PatchUseColor.Checked;
                        break;
                    case "PatchInfoUseColor":
                        Properties.Settings.Default.PatchInfoUseColor = PatchInfoUseColor.Checked;
                        break;
                    case "MainUseColor":
                        Properties.Settings.Default.MainUseColor = MainUseColor.Checked;
                        break;
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.SavedPath = textEdit1.Text = folderBrowser.SelectedPath;
            }
        }
    }
}
