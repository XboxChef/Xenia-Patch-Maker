using DevExpress.XtraEditors;
using System;
using System.Text;
using System.Windows.Forms;

namespace XeniaPatchMaker
{
    public partial class ValueConverter : XtraForm
    {
        public ValueConverter()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ValueConverter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.valueConverter = null;
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (TypeConverter.Text == "Bytes to Hex")
                {
                    // Byte to hex
                    string hex = BitConverter.ToString(Encoding.ASCII.GetBytes(StringValue.Text));
                    ConvertedValue.Text = hex.Replace("-", "");
                    return;
                }
                if (TypeConverter.Text == "Double to Hex")
                {
                    // Double to hex
                    ConvertedValue.Text = BitConverter.ToInt32(BitConverter.GetBytes((float)Convert.ToDouble((float)double.Parse(StringValue.Text, System.Globalization.CultureInfo.InvariantCulture))), 0).ToString("X").ToUpper();
                    Program.MainForm.Data_Between(ConvertedValue.Text);
                    return;
                }
                if (TypeConverter.Text == "Float to Hex")
                {
                    // Float to hex
                    ConvertedValue.Text = BitConverter.ToInt32(BitConverter.GetBytes((float)Convert.ToDouble(StringValue.Text)), 0).ToString("X").ToUpper();
                    Program.MainForm.Data_Between(ConvertedValue.Text);
                    return;
                }
                if (TypeConverter.Text == "Decimal to Hex")
                {
                    // Decimal to hex
                    ConvertedValue.Text = int.Parse(StringValue.Text).ToString("x").ToUpper();
                    Program.MainForm.Data_Between(ConvertedValue.Text);
                    return;
                }
                return;
            }
            catch
            {
            }
        }
    }
}
