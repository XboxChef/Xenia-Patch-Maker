using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XeniaPatchMaker.Properties;
using XeniaPatchMaker.Util;
using static XeniaPatchMaker.Util.PatchUtil;
namespace XeniaPatchMaker
{
    public partial class XPM : XtraForm
    {
        #region PlaceHolders
        Settings settings { get; set; }
        public static string CurrentFullPath { get; set; }

        public static string CurrentFullName { get; set; }

        public static string Data { get; set; }
        #endregion

        #region Initialize
        public XPM()
        {
            InitializeComponent();
            if (!File.Exists(Path.Combine(Application.StartupPath, "DB.xml")))
            {
                // Create a new file     
                using (FileStream fs = File.Create(Path.Combine(Application.StartupPath, "DB.xml")))
                {
                    byte[] author = new UTF8Encoding(true).GetBytes(@Resources.DB);
                    fs.Write(author, 0, author.Length);
                }
            }
            Text = "Xenia Patch Maker By TeddyHammer ( Version: " + Application.ProductVersion + " )";
        }

        #endregion

        #region Header Info Input
        private void XEXInfo_Click(object sender, EventArgs e)
        {
            if (HashKey.Text.Length > 10)
            {
                if (OutPut.Text.Contains(string.Empty))
                {
                    OutPut.AppendText("title_name = \"" + TitleName.Text + "\"");
                    OutPut.AppendText(Environment.NewLine);
                    OutPut.AppendText("title_id = \"" + TitleId.Text + "\"");
                    OutPut.AppendText(Environment.NewLine);
                    OutPut.AppendText("hash = \"" + HashKey.Text + "\"");
                    OutPut.AppendText(Environment.NewLine);
                    OutPut.AppendText("#media_id = \"" + MediaId.Text + "\"");
                    OutPut.AppendText(Environment.NewLine);
                }
                else
                {
                    MessageBox.Show("Output Must Be Empty Else Tool Is Disabled");
                }
            }
            else
            {
                MessageBox.Show("Must Drop Log File");
            }

        }
        private void AddPokeHeader_Click(object sender, EventArgs e)
        {
            //Safe Guard For Users TO Make Sure Format Is Correct At All Times
            if (OutPut.Text.Contains("[[patch]]"))
            {
                //Condition Checks Make Sure User At Least Writes Something
                if (!IsNullOrEmpty(PatchAddress.Text) && !IsNullOrEmpty(PatchValue.Text))
                {
                    OutPut.AppendText("    [[patch." + ProvideSizeType.Text + "]]");
                    OutPut.AppendText(Environment.NewLine);
                    OutPut.AppendText("        address = " + oxadd.Text + PatchAddress.Text);
                    OutPut.AppendText(Environment.NewLine);
                    OutPut.AppendText("        value = " + oxvalue.Text + PatchValue.Text);
                    OutPut.AppendText(Environment.NewLine);
                    PatchValue.Text = string.Empty;
                    PatchAddress.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Must Enter Info!");
                }

            }
            else
            {
                MessageBox.Show("Patch Header Must Be Made First (Please Write Patch Info)");
            }
        }
        private void AddPatchHeader_Click(object sender, EventArgs e)
        {
            //Safe Guard For Users TO Make Sure Format Is Correct At All Times
            if (OutPut.Text.Contains("#media_id ="))
            {
                //Condition Checks Make Sure User At Least Writes Something
                if (!IsNullOrEmpty(PatchName.Text) && !IsNullOrEmpty(Desc.Text) && !IsNullOrEmpty(Authors.Text))
                {
                    OutPut.AppendText(Environment.NewLine + "[[patch]]");
                    //writes the line with user's input
                    OutPut.AppendText(Environment.NewLine + "    name = \"" + PatchName.Text + "\"");
                    OutPut.AppendText(Environment.NewLine + "    desc = \"" + Desc.Text + "\"");
                    OutPut.AppendText(Environment.NewLine + "    author = \"" + Authors.Text + "\"");
                    OutPut.AppendText(Environment.NewLine + "    is_enabled = " + IsOn.IsOn.ToString().ToLower() + Environment.NewLine + Environment.NewLine);

                    DialogResult dialogResult = MessageBox.Show("Would You Also Like To Delete Current Patch Input?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        PatchName.Text = string.Empty;
                        Desc.Text = string.Empty;
                        Authors.Text = string.Empty;
                        IsOn.IsOn = false;
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Must Enter Info!");
                }
            }
            else
            {
                MessageBox.Show("Main Header Must Be Made First (Please Write XEX Info)");
            }

        }
        #endregion

        #region Functions
        /// <summary>
        /// Find All Type's.
        /// </summary>
        public void GetAllTypes()
        {

            FileInfo fi = new FileInfo(CurrentFullPath);

                //File Requirement: Must Be Larger Than 2kb
                if (fi.Length > 20000)
                {

                    ///improving from what we have
                    ///
                    TitleId.Text = GetTitleID(Data, "Title ID:", "Savegame ID:", 0);
                    HashKey.Text = GetHashKey(Data, "Module hash: ", " for default", 0);
                    MediaId.Text = GetMediaID(Data, "Media ID:", "Title ID:", 0);
                    // Deserialize the DB XML file
                    var titleDB = TitleDB.XmlDeserialize(File.ReadAllText(Path.Combine(Application.StartupPath, "DB.xml"), Encoding.UTF8));

                    // Locate the TitleEntry by the given TitleID and pull out the Title.
                    // If a TitleEntry is not found, the null propagation operator will fall on the "string.Empty" side of the ??s preventing a crash.
                    TitleName.Text = titleDB.Titles.FirstOrDefault(t => t.ID.ToLower() == TitleId.Text.ToLower())?.Title ?? string.Empty;
                    Data = string.Empty; //make sure string is empty
                    CurrentFullName = string.Empty;//make sure string is empty
                    CurrentFullPath = string.Empty; //make sure string is empty
                    return;

                }
                else
                {
                    MessageBox.Show("Incorrect File Size. " + "(" + "File Size = " + fi.Length + ")" + "Must Be Larger Than 2kb");//great check since some logs are plain wrong
                }

        }
        /// <summary>
        /// Holds Data And Sends It To Correct Locations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropBox_DragDrop(object sender, DragEventArgs e)
        {
            Data = File.ReadAllText(string.Join("", CurrentFullPath));
            if (sender.Equals(DropLog))
            {
                //if it's greater or equal than value
                if (Data.Length >= 4600)
                {
                    Data.Substring(0, Data.IndexOf("Savegame ID:")); //makes log shorter
                    GetAllTypes();
                    return;
                }
                else
                {
                    GetAllTypes();
                    return;
                } 
            }
            else
            {
                OutPut.Text = Data;
                return;
            }



        }

        private void DropBox_DragEnter(object sender, DragEventArgs e)
        {
            // See if this is a copy and the data includes text.
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                //File Being Dropped
                string[] CurrentFile = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                //Sets FullPath Path
                CurrentFullPath = Path.GetFullPath(CurrentFile[0]);
                //Sets FullName Path
                CurrentFullName = Path.GetFileName(CurrentFile[0]);
                if (sender.Equals(PatchDrop))
                {
                    if (Path.GetFileName(CurrentFile[0]).Contains(".patch"))
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                    else
                    {
                        // Don't allow any other drop.
                        e.Effect = DragDropEffects.None;
                    }
                }
                if (sender.Equals(DropLog))
                {
                    if (Path.GetFileName(CurrentFile[0]).Contains(".log"))
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                    else
                    {
                        // Don't allow any other drop.
                        e.Effect = DragDropEffects.None;
                    }
                }


            }
            else
            {
                // Don't allow any other drop.
                e.Effect = DragDropEffects.None;
            }
        }


        /// <summary>
        /// Condition Checker
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool IsNullOrEmpty(string s)
        {
            return (s == null || s == string.Empty) ? true : false;
        } 
        #endregion

        #region Controls

        private void Save_Click(object sender, EventArgs e)
        {

            if (OutPut.TextLength > 30)
            {

                using (SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "Xenia Patch File(*.patch;) |*.patch;| All files(*.*) | *.*",
                    Title = "Save Patch File...",
                    FileName = TitleId.Text + " - " + TitleName.Text,
                    DereferenceLinks = true,
                    CheckPathExists = false,
                    CheckFileExists = false

                })


                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // If the file name is not an empty string open it for saving.
                        if (dialog.FileName != string.Empty)
                        {


                            FileStream fParameter = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write);
                            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                            m_WriterParameter.Write(OutPut.Text);
                            m_WriterParameter.Flush();
                            m_WriterParameter.Close();
                            fParameter.Close();
                            MessageBox.Show("File Was Created - " + Environment.NewLine + dialog.FileName);
                        }
                    }

            }
            else
            {
                MessageBox.Show("Must Have Something To Be Saved Otherwise It Won't Work");
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            OutPut.Text = string.Empty;
        }

        private void LoadPatchFile_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Xenia Patch File(*.patch;) |*.patch;| All files(*.*) | *.*",
                Title = "Save Patch File...",
                DereferenceLinks = true,
                CheckPathExists = true,
                CheckFileExists = true
            })


                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    OutPut.Text = File.ReadAllText(dialog.FileName);

                }
        }
        #endregion

        private void AboutAndSettings_Click(object sender, EventArgs e)
        {

            if (settings == null)
            {
                settings = new Settings();
                settings.FormClosed += Settings_FormClosed;  //Add event Handler to cleanup after form closes
            }
            Hide();
            settings.ShowDialog(this);  //Show Form assigning this form as the forms owner


        }
        public  void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
            Show();
        }

        private void OutPut_TextChanged(object sender, EventArgs e)
        {

            try
            {

                CheckKeyword("[[patch]]", Color.FromArgb(74, 139, 197), 0);
                CheckKeyword("\"", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword("title_name =", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword("title_id =", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword("hash =", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword("#media_id =", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword("[[patch." + "be32" + "]]", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword("address = ", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword("value = ", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword(" name = ", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword(" desc = ", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword(" author = ", Color.FromArgb(214, 136, 82), 0);
                CheckKeyword(" is_enabled = ", Color.FromArgb(214, 136, 82), 0);
                if(!IsNullOrEmpty(TitleName.Text))
                {
                    CheckKeyword(TitleName.Text, Color.Green, 0);
                }    
                else if(!IsNullOrEmpty(TitleId.Text))
                {
                    CheckKeyword(TitleId.Text, Color.Green, 0);
                }
                else if(!IsNullOrEmpty(HashKey.Text))
                {
                    CheckKeyword(HashKey.Text, Color.Green, 0);
                }
                else if (!IsNullOrEmpty(MediaId.Text))
                {
                    CheckKeyword(MediaId.Text, Color.Green, 0);
                }

                else if (!IsNullOrEmpty(IsOn.Text))
                {
                    CheckKeyword(IsOn.Text, Color.Green, 0);
                }

                else if (!IsNullOrEmpty(Authors.Text))
                {
                    CheckKeyword(Authors.Text, Color.Green, 0);
                }

                else if (!IsNullOrEmpty(PatchName.Text))
                {
                    CheckKeyword(PatchName.Text, Color.Green, 0);
                }

                else if (!IsNullOrEmpty(Desc.Text))
                {
                    CheckKeyword(Desc.Text, Color.Green, 0);
                }

                else if (!IsNullOrEmpty(PatchAddress.Text))
                {
                    CheckKeyword(PatchAddress.Text, Color.Green, 0);
                }

                else if (!IsNullOrEmpty(PatchValue.Text))
                {
                    CheckKeyword(PatchValue.Text, Color.Green, 0);
                }

                else if (!IsNullOrEmpty(oxadd.Text))
                {
                    CheckKeyword(oxadd.Text, Color.Green, 0);
                }

                else if (!IsNullOrEmpty(oxvalue.Text))
                {
                    CheckKeyword(oxvalue.Text, Color.Green, 0);
                }

                else if (!IsNullOrEmpty(ProvideSizeType.Text))
                {
                    CheckKeyword(ProvideSizeType.Text, Color.Green, 0);
                }
                else
                {
                    return;
                }

            }
            catch
            {
                
            }


        }
        private void CheckKeyword(string word, Color color, int startIndex)
        {
            string outsource = OutPut.Text;
            if (OutPut.Text.Contains(word))
            {
                int index = -1;
                int selectStart = OutPut.SelectionStart;

                while ((index = OutPut.Text.IndexOf(word, (index + 1))) != -1)
                {
                    OutPut.Select((index + startIndex), word.Length);
                    OutPut.SelectionColor = color;
                    OutPut.Select(selectStart, 0);
                    OutPut.SelectionColor = Color.White;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=6n3pFFPSlW4");
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEdit1.Checked == true)
            {
                PatchValue.Text = "60000000";
                oxvalue.Enabled = false;
                PatchValue.Enabled = false;
            }
            else
            {
                PatchValue.Text = "";
                oxvalue.Enabled = true;
                PatchValue.Enabled = true;
            }
        }

        private void richEditControl1_ForeColorChanged(object sender, EventArgs e)
        {
            OutPut.ForeColor = richEditControl1.Appearance.Text.ForeColor;
            OutPut.BackColor = richEditControl1.Views.SimpleView.BackColor;
        }
    }
}
