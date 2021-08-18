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
                if(TypeConverter.Text == "Bytes To Hex")
                {
                    //byte to hex
                    string hex = BitConverter.ToString(Encoding.ASCII.GetBytes(StringValue.Text));
                    ConvertedValue.Text = hex.Replace("-", "");
                    return;
                }
                if (TypeConverter.Text == "Double To Hex")
                {
                    //double to hex
                    ConvertedValue.Text = BitConverter.ToInt32(BitConverter.GetBytes((float)Convert.ToDouble((float)double.Parse(StringValue.Text, System.Globalization.CultureInfo.InvariantCulture))), 0).ToString("X").ToUpper();
                    Program.MainForm.Data_Between(ConvertedValue.Text);
                    return;
                }
                if(TypeConverter.Text == "Float To Hex")
                {
                    //float to hex
                    ConvertedValue.Text = BitConverter.ToInt32(BitConverter.GetBytes((float)Convert.ToDouble(StringValue.Text)), 0).ToString("X").ToUpper();
                    Program.MainForm.Data_Between(ConvertedValue.Text);
                    return;
                }
                if (TypeConverter.Text == "Decimal To Hex")
                {
                    //decimal to hex
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