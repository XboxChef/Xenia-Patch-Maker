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
    public partial class XPFM : Form
    {
        string Data;
        public XPFM()
        {
            InitializeComponent();
        }



        private void BropBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            Data = string.Join("", fileList);
            TitleId.Text = GetTitleId(System.IO.File.ReadAllText(Data), "Media ID:", "Title ID:", 0);
            HashKey.Text = GetHashKey(System.IO.File.ReadAllText(Data), "Module hash: ", " for default", 0);
            MediaId.Text = GetMediaId(System.IO.File.ReadAllText(Data), "Title ID:", "Savegame ID:", 0);
        }

        private void XPFM_Load(object sender, EventArgs e)
        {
            groupBox3.AllowDrop = true;
            groupBox3.DragDrop += new DragEventHandler(BropBox_DragDrop);
        }

        private void DropBox_DragEnter(object sender, DragEventArgs e)
        {
            // See if this is a copy and the data includes text.
            if (e.Data.GetDataPresent(DataFormats.FileDrop) &&
                (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                // Don't allow any other drop.
                e.Effect = DragDropEffects.None;
            }
        }


        private void XEXInfo_Click(object sender, EventArgs e)
        {
            //
            if (OutPut.Text.Contains(string.Empty))
            {
                OutPut.Text = "title_name = \"" + TitleName.Text + "\"" +
    Environment.NewLine + "title_id = \"" + TitleId.Text + "\"" +
    Environment.NewLine + "hash = \"" + HashKey.Text + "\"" +
    Environment.NewLine + "#media_id = \"" + MediaId.Text + "\"" +
    Environment.NewLine; 
            }
            else
            {
                MessageBox.Show("Output Must Be Empty Else Tool Is Disabled");
            }
        }

        private void IsOn_CheckedChanged(object sender, EventArgs e)
        {
            if(IsOn.Checked == true)
            {
                IsOn.Text = "true";
            }
            else
            {
                IsOn.Text = "false";
            }
        }

        private void AddPokeHeader_Click(object sender, EventArgs e)
        {
            //Safe Guard For Users TO Make Sure Format Is Correct At All Times
            if (TitleId.TextLength > 0)
            {
                if (DoesHaveSecond.Checked == true)
                {
                    //If True Writes Both
                    OutPut.AppendText("    [[patch." + ProvideSizeType.Text + "]]" +
    Environment.NewLine + "        address = " + textBox9.Text +
    Environment.NewLine + "        value = " + textBox10.Text +
    Environment.NewLine);
                    OutPut.AppendText("    [[patch." + ProvideSizeType.Text + "]]" +
Environment.NewLine + "        address = " + textBox9.Text +
Environment.NewLine + "        value = " + textBox10.Text +
Environment.NewLine);
                }
                else
                {
                    //If False it will only Write One
                    OutPut.AppendText("    [[patch." + ProvideSizeType.Text + "]]" +
Environment.NewLine + "        address = " + textBox9.Text +
Environment.NewLine + "        value = " + textBox10.Text +
Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Main Header Must Be Made First (Please Write XEX Info)");
            }
        }

        private void XEXInfoClear_Click(object sender, EventArgs e)
        {
            PatchName.Text = string.Empty;
            Desc.Text = string.Empty;
            Authors.Text = string.Empty;
        }

        private void SecondPatch_CheckedChanged(object sender, EventArgs e)
        {

            if (DoesHaveSecond.Checked == true)
            {
                DoesHaveSecond.Text = "Enabled";
            }
            else
            {
                DoesHaveSecond.Text = "Disabled";
            }
        }

        private void AddPatchHeader_Click(object sender, EventArgs e)
        {
            //Safe Guard For Users TO Make Sure Format Is Correct At All Times
            if (TitleId.TextLength > 0)
            {
                //writes the line with user's input
                OutPut.AppendText("[[patch]]" +
        Environment.NewLine + "    name = \"" + PatchName.Text + "\"" +
        Environment.NewLine + "    desc = \"" + Desc.Text + "\"" +
        Environment.NewLine + "    author = \"" + Authors.Text + "\"" +
        Environment.NewLine + "    is_enabled = " + IsOn.Text + "\"" +
        Environment.NewLine); 
            }
        }
        private string GetTitleId(string Placeholder, string Start, string End, int length)
        {
            int x = Placeholder.LastIndexOf(Start/*"Title ID:"*/) + Start.Length + 1;
            length = Placeholder.IndexOf(End/*"Savegame ID:"*/) - x;
            string s = Placeholder.Substring(x, length);
            return String.Concat(s.Where(c => !Char.IsWhiteSpace(c)));
        }
        private string GetMediaId(string Placeholder, string Start, string End, int length)
        {
            int x = Placeholder.LastIndexOf(Start/*"Title ID:"*/) + Start.Length + 1;
            length = Placeholder.IndexOf(End/*"Savegame ID:"*/) - x;
            string s = Placeholder.Substring(x, length);
            return String.Concat(s.Where(c => !Char.IsWhiteSpace(c)));
        }
        private string GetHashKey(string Placeholder, string Start, string End, int length)
        {
            int x = Placeholder.LastIndexOf(Start/*"Title ID:"*/) + Start.Length + 1;
            length = Placeholder.IndexOf(End/*"Savegame ID:"*/);
            return Placeholder.Substring(x - 1, 16);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Warning", "This Will Delete Current Output", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                OutPut.Text = "TeddyHammer - Aka Serenity Project Manager/Owner, " +
            Environment.NewLine + "Etokapa - Sending Logs Instead Of Nudes," +
            Environment.NewLine + "Billy Blueberry - Emotional Support :P";
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                //do something else
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog dialog = new SaveFileDialog()
            {
                CheckFileExists = true,
                DereferenceLinks = true,
                Filter = "Xenia Patch File(*.patch;) |*.patch;| All files(*.*) | *.*",
                Title = "Save Patch File..."
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                   
                }
            }

        }
    }
}
