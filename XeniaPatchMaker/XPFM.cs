using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XeniaPatchMaker.Util;
using static XeniaPatchMaker.Util.PatchUtil;
namespace XeniaPatchMaker
{
    public partial class XPFM : Form
    {
        #region PlaceHolders
        public static string CurrentFullPath { get; set; }

        public static string CurrentFullName { get; set; }

        public static string Data { get; set; }

        public static string TitleNameInput { get; set; }
        #endregion

        #region Initialize
        public XPFM()
        {
            InitializeComponent();
            this.Text = "Xenia Patch Maker By TeddyHammer ( Version: " + Application.ProductVersion + " )";
            ProvideSizeType.Text = "be32";
            groupBox3.AllowDrop = true;
        }
        #endregion

        #region Header Info Input
        private void XEXInfo_Click(object sender, EventArgs e)
        {
            //
            if (HashKey.TextLength > 10)
            {
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
                    if (ProvideSizeType.Text == string.Empty)
                    {
                        //If False it will only Write One
                        OutPut.AppendText("    [[patch." + "be32" + "]]" +
        Environment.NewLine + "        address = " + PatchAddress.Text +
        Environment.NewLine + "        value = " + PatchValue.Text +
        Environment.NewLine);
                        PatchValue.Text = string.Empty;
                        PatchAddress.Text = string.Empty;
                    }
                    else
                    {
                        //If False it will only Write One
                        OutPut.AppendText("    [[patch." + ProvideSizeType.Text + "]]" +
        Environment.NewLine + "        address = " + PatchAddress.Text +
        Environment.NewLine + "        value = " + PatchValue.Text +
        Environment.NewLine);
                        PatchValue.Text = string.Empty;
                        PatchAddress.Text = string.Empty;
                    }
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
                    //writes the line with user's input
                    OutPut.AppendText(Environment.NewLine + "[[patch]]" +
            Environment.NewLine + "    name = \"" + PatchName.Text + "\"" +
            Environment.NewLine + "    desc = \"" + Desc.Text + "\"" +
            Environment.NewLine + "    author = \"" + Authors.Text + "\"" +
            Environment.NewLine + "    is_enabled = " + IsOn.Text +
            Environment.NewLine + Environment.NewLine);
                    DialogResult dialogResult = MessageBox.Show("Would You Also Like To Delete Current Patch Input?", "Warning", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        PatchName.Text = string.Empty;
                        Desc.Text = string.Empty;
                        Authors.Text = string.Empty;
                        IsOn.Checked = false;
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
        private void DropBox_DragDrop(object sender, DragEventArgs e)
        {

            try
            {
                Data = File.ReadAllText(string.Join("", CurrentFullPath));
                FileInfo fi = new FileInfo(CurrentFullPath);
                //File Requirement: Must Be Larger Than 2kb
                if (fi.Length > 20000)
                {

                    TitleId.Text = GetTitleID(Data, "Title ID:", "Savegame ID:", 0);
                    HashKey.Text = GetHashKey(Data, "Module hash: ", " for default", 0);
                    MediaId.Text = GetMediaID(Data, "Media ID:", "Title ID:", 0);

                    // Deserialize the DB XML file
                    var titleDB = TitleDB.XmlDeserialize(File.ReadAllText(Path.Combine(Application.StartupPath, "DB.xml"), Encoding.UTF8));

                    // Locate the TitleEntry by the given TitleID and pull out the Title.
                    // If a TitleEntry is not found, the null propagation operator will fall on the "string.Empty" side of the ??s preventing a crash.
                    TitleName.Text = titleDB.Titles.FirstOrDefault(t => t.ID.ToLower() == TitleId.Text.ToLower())?.Title ?? string.Empty;

                    //TitleName.Text = GetTitle(File.ReadAllText(Application.StartupPath + "\\DB.txt"), TitleId.Text,Environment.NewLine, 0);
                    
                }
                else
                {
                    MessageBox.Show("Incorrect File Size. " + "(" + "File Size = " + fi.Length + ")" + "Must Be Larger Than 2kb");
                }
            }
            catch
            {
                MessageBox.Show("Invalid File.");

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
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                // Don't allow any other drop.
                e.Effect = DragDropEffects.None;
            }
        }
        private void IsOn_CheckedChanged(object sender, EventArgs e)
        {
            if (IsOn.Checked == true)
            {
                IsOn.Text = "true";
            }
            else
            {
                IsOn.Text = "false";
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
        private void Credit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This Will Delete Current Output", "Warning", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                OutPut.Text = "TeddyHammer - Aka Serenity Project Manager/Owner, " +
            Environment.NewLine + "Etokapa - Sending Logs Instead Of Nudes," +
            Environment.NewLine + "Billy Blueberry - Emotional Support :P" +
            Environment.NewLine + "Boma - Bug Reporting";
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }

        }

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

    }
}
