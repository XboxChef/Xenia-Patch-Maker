using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using XeniaPatchMaker;

namespace GitHubUpdate
{
    public partial class UpdateNotifyDialog : XtraForm
    {
        private readonly UpdateChecker _checker;

        public UpdateNotifyDialog(UpdateChecker checker)
        {
            
            _checker = checker;

            InitializeComponent();

            label1.Text = string.Format(label1.Text, checker.RepostoryName);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
