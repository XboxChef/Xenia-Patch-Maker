using DevExpress.XtraEditors;
using System;
using static XeniaPatchMaker.Util.PatchUtil;

namespace XeniaPatchMaker
{
    public partial class Find : XtraForm
    {
        public Find()
        {
            InitializeComponent();
        }

        private void CaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void OK_Click(object sender, EventArgs e)
        {
        }

        private void SearchTextbox_EditValueChanging(object sender, EventArgs e)
        {
            if (IsNullOrEmpty(SearchTextbox.Text))
            {
                SearchAll.Enabled = false;
                OK.Enabled = false;
            }
            if (!IsNullOrEmpty(SearchTextbox.Text))
            {
                SearchAll.Enabled = true;
                OK.Enabled = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkEdit2_Click(object sender, EventArgs e)
        {
            CheckEdit checkbox = (CheckEdit)sender;
            if (checkbox.Text.Equals(checkEdit2.Text))
            {
                checkEdit3.Checked = false;
                checkEdit4.Checked = false;
            }
            else if (checkbox.Text.Equals(checkEdit3.Text))
            {
                checkEdit2.Checked = false;
                checkEdit4.Checked = false;
            }
            else if (checkbox.Text.Equals(checkEdit4.Text))
            {
                checkEdit3.Checked = false;
                checkEdit2.Checked = false;
            }
            else if (checkbox.Text.Equals(checkEdit1.Text))
            {
                // culture.CompareInfo.IndexOf(paragraph, word, CompareOptions.IgnoreCase) >= 0
                //  SearchTextbox.Equals(a, b, StringComparison.CurrentCultureIgnoreCase);
            }
        }
    }
}
