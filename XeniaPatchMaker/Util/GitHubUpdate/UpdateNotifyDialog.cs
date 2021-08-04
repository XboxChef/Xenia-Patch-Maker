using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using XeniaPatchMaker;

namespace XeniaPatchMaker
{
    public partial class UpdateNotifyDialog : XtraForm
    {
        private readonly UpdateChecker _checker;

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
            Focus();
            
        }
    }
}
