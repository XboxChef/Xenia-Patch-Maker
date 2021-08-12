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
    public partial class ValueConverter : XtraForm
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
                Program.MainForm.Data_Between(ConvertedValue.Text);
                return;

            }
            catch
            {

            }

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertedValue.Text = int.Parse(StringValue.Text).ToString("x").ToUpper();
                Program.MainForm.Data_Between(ConvertedValue.Text);
                return;
            }
            catch
            {

            }

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
            Program.valueConverter = null;
        }

        private void ConvertedValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {//.ToString("X").ToUpper();  StringValue.Text
            try
            {
                ConvertedValue.Text = BitConverter.ToInt32(BitConverter.GetBytes((float)Convert.ToDouble((float)double.Parse(StringValue.Text, System.Globalization.CultureInfo.InvariantCulture))), 0).ToString("X").ToUpper();
                Program.MainForm.Data_Between(ConvertedValue.Text);
                return;

            }
            catch
            {

            }

        }
        public static float ToSingle(double value)
        {
            return (float)value;
        }
    }
}