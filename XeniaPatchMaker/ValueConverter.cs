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
    public partial class ValueConverter : DevExpress.XtraEditors.XtraForm
    {
        public ValueConverter()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertedValue.Text = BitConverter.ToInt32(BitConverter.GetBytes((float)Convert.ToDouble(StringValue.Text)), 0).ToString("X").ToUpper();
                XPM.Data_Holder = ConvertedValue.Text;
                return;

            }
            catch
            {

            }

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            ConvertedValue.Text = int.Parse(StringValue.Text).ToString("x").ToUpper();
            XPM.Data_Holder = ConvertedValue.Text;
            return;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConvertedValue_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void ValueConverter_FormClosing(object sender, FormClosingEventArgs e)
        {
            XPM.valueConverter = null;
        }

        private void ConvertedValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}