using DevExpress.XtraEditors;
using System;
using System.Drawing;

namespace XeniaPatchMaker
{
    public partial class UpdateNotifyDialog : XtraForm
    {
        private readonly UpdateChecker _checker;
        private bool _loadednotes;

        public UpdateNotifyDialog(UpdateChecker checker)
        {

            _checker = checker;

            InitializeComponent();
            label1.Text = string.Format(label1.Text, checker.RepositoryName);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateNotifyDialog_Shown(object sender, EventArgs e)
        {

        }

        private void UpdateNotifyDialog_Load(object sender, EventArgs e)
        {
            try
            {
                TopMost = true;
                this.BringToFront();
                Focus();
                Program.MainForm.Hide();


            }
            catch
            {

            }
        }

        private async void boxReleaseNotes_CheckedChanged(object sender, EventArgs e)
        {
            if (_loadednotes) return;
            Changes.Visible = true;
            Changes.Size = new Size(374, 200);
            ActiveForm.Size = new Size(390, 350);
            string rs = await _checker.RenderReleaseNotes();

            Changes.Text = rs;
            _loadednotes = true;

        }

        private void buttonNo_Click(object sender, EventArgs e)
        {

        }
    }
}
