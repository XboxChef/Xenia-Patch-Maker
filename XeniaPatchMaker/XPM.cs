using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XeniaPatchMaker.Properties;
using XeniaPatchMaker.Util;
using static XeniaPatchMaker.Util.PatchUtil;
using static XeniaPatchMaker.Program;
namespace XeniaPatchMaker
{
    public partial class XPM : XtraForm
    {
        #region PlaceHolders
        
        
        public static string CurrentFullPath { get; set; }
        public static string CurrentFullName { get; set; }
        public static string Data { get; set; }
        public static string IsUpdateUptoDate { get; set; }
        public bool OutputConditions { get; private set; }

        #endregion

        #region Initialize
        public XPM()
        {
            InitializeComponent();

        }
        private void XPM_Load(object sender, EventArgs e)
        {

            try
            {
                Hide();
                if (!File.Exists(Path.Combine(Application.StartupPath, "DB.xml")))
                {
                    // Create a new file     
                    using (FileStream fs = File.Create(Path.Combine(Application.StartupPath, "DB.xml")))
                    {
                        byte[] author = new UTF8Encoding(true).GetBytes(@Resources.DB);
                        fs.Write(author, 0, author.Length);
                    }
                }
                IsOn.ForeColor = Color.Red;
                Version.Caption = "Version: " + Application.ProductVersion;
                Text = "Xenia Patch Maker By TeddyHammer";
                UpdateChecker checker = new UpdateChecker("TeddyHammer", "XeniaPatchMaker");
                checker.CheckUpdate(locked: UpdateType.Patch).ContinueWith(continuation =>
                {
                    XPM.IsUpdateUptoDate = "Needs Update!";

                    if (continuation.Result != UpdateType.None)
                    {
                        var result = new UpdateNotifyDialog(checker).ShowDialog();
                        if (result == DialogResult.Yes)
                        {
                            checker.DownloadAsset("XeniaPatchMaker.exe");
                            if (File.Exists(Application.StartupPath + "\\XeniaPatchMakerUpdate.exe"))
                            {

                                System.IO.File.Move(Application.StartupPath + "\\XeniaPatchMaker.exe", Application.StartupPath + "\\XeniaPatchMakerold.exe");
                                System.IO.File.Move(Application.StartupPath + "\\XeniaPatchMakerUpdate.exe", Application.StartupPath + "\\XeniaPatchMaker.exe");
                                Process.Start(Application.StartupPath + "\\XeniaPatchMaker.exe");
                                Process.GetCurrentProcess().Kill();


                            }
                            else
                            {

                            }
                        }
                        if (result == DialogResult.No)
                        {
                            Process.GetCurrentProcess().Kill();
                        }

                    }
                    else
                    {
                        XPM.IsUpdateUptoDate = "Up to date!";
                    }
                });
                File.Delete(Application.StartupPath + "\\XeniaPatchMakerold.exe");
                
            }
            finally
            {

                Show();
            }

            

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
                    if(Properties.Settings.Default.AutoDelete == true)
                    {
                        PatchAddress.Text = string.Empty;
                        if (UseType.Checked == true)
                        {
                             
                        }
                        else
                        {
                            PatchValue.Text = string.Empty;
                        }
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
                MessageBox.Show("Patch Header Must Be Made First (Please Write Patch Info)");
            }
        }

        private void AddPatchHeader_Click(object sender, EventArgs e)
        {
            //Safe Guard For Users TO Make Sure Format Is Correct At All Times
            if (OutPut.Text.Contains("#media_id ="))
            {
                //Condition Checks Make Sure User At Least Writes Something
                if (!IsNullOrEmpty(PatchName.Text) && !IsNullOrEmpty(Authors.Text))
                {
                    OutPut.AppendText(Environment.NewLine + "[[patch]]");
                    //writes the line with user's input
                    OutPut.AppendText(Environment.NewLine + "    name = \"" + PatchName.Text + "\"");
                    if (Properties.Settings.Default.DisableDesc == false)
                    {
                        OutPut.AppendText(Environment.NewLine + "    desc = \"" + Desc.Text + "\""); 
                    }
                    if (Properties.Settings.Default.UseDefaultAuthors == true)
                    {
                        OutPut.AppendText(Environment.NewLine + "    author = \"" + Properties.Settings.Default.DefaultAuthors + "\"");
                    }
                    else
                    {
                        OutPut.AppendText(Environment.NewLine + "    author = \"" + Authors.Text + "\"");
                    }
                    OutPut.AppendText(Environment.NewLine + "    is_enabled = " + IsOn.IsOn.ToString().ToLower() + Environment.NewLine + Environment.NewLine);

                    if (Properties.Settings.Default.DisableMessageBox == false)
                    {
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
        private void IsOn_Toggled(object sender, EventArgs e)
        {
            if (IsOn.IsOn)
            {
                IsOn.ForeColor = Color.LightGreen;
            }
            else
            {
                IsOn.ForeColor = Color.Red;
            }
        }

        private void AddressMath_Click(object sender, EventArgs e)
        {
            //We Have To Make Sure We Separate Both Buttons into there own thread
            if (sender.Equals(MinusButton))
            {
                if (!IsNullOrEmpty(PatchAddress.Text))
                {
                    //when minus is clicked the address is grabbed and stored
                    //the address then uses hex math to subtract 4 bytes
                    int decValue = int.Parse(PatchAddress.Text, System.Globalization.NumberStyles.HexNumber) - 4;
                    PatchAddress.Text = decValue.ToString("X");
                }
                return;
            }
            else if (sender.Equals(PlusButton))
            {
                if (!IsNullOrEmpty(PatchAddress.Text))
                {
                    //when adding is clicked the address is grabbed and stored
                    //the address then uses hex math to Add 4 bytes
                    int decValue = int.Parse(PatchAddress.Text, System.Globalization.NumberStyles.HexNumber) + 4;
                    PatchAddress.Text = decValue.ToString("X");
                }
                return;
            }
        }


        private void Types_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UseType.Checked == true)
            {
                PatchValue.Text = Types.Text;
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
        #endregion

        #region Functions
        private void FormOpen_Click(object sender, EventArgs e)
        {
            if (sender.GetType().FullName == "DevExpress.XtraEditors.SimpleButton")
            {
                if (valueConverter == null)
                {
                    valueConverter = new ValueConverter();
                    valueConverter.FormClosed += FormType_FormClosed;  //Add event Handler to cleanup after form closes
                }
                valueConverter.ShowDialog(this); //Show Form assigning this form as the forms owner
            }

        }

        private void BarManagerFormOpen_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sender.GetType().FullName == "DevExpress.XtraBars.BarManager")
            {
                if (Program.Settings == null)
                {
                    Program.Settings = new Settings();
                    Program.Settings.FormClosed += FormType_FormClosed;  //Add event Handler to cleanup after form closes
                }
                Hide();
                Program.Settings.ShowDialog(this);  //Show Form assigning this form as the forms owner
            }
        }
        /// <summary>
        /// Find All Type's.
        /// </summary>
        public void GetAllTypes()
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
        /// <summary>
        /// Use for Various Forms Where Data Needs To be Transfered
        /// </summary>
        /// <param name="Input"></param>
        public void Data_Between(string Input)
        {
            //Check if User Has Checkbox Checked...
            if (!UseType.Checked)
            {
                PatchValue.Text = Input;
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
            if (Path.GetFileName(CurrentFullName).Contains(".log"))
            {
                //makes log shorter
                Data.Substring(0, Data.IndexOf("Savegame ID:"));
                GetAllTypes();
                if(Properties.Settings.Default.WriteInfo == true)
                {
                    if (HashKey.Text.Length > 10)
                    {
                    EmptyString:
                        if (IsNullOrEmpty(OutPut.Text))
                        {
                            OutputConditions = true;
                            OutPut.AppendText("title_name = \"" + TitleName.Text + "\"");
                            OutPut.AppendText(Environment.NewLine);
                            OutPut.AppendText("title_id = \"" + TitleId.Text + "\"");
                            OutPut.AppendText(Environment.NewLine);
                            OutPut.AppendText("hash = \"" + HashKey.Text + "\"");
                            OutPut.AppendText(Environment.NewLine);
                            OutPut.AppendText("#media_id = \"" + MediaId.Text + "\"");
                            OutPut.AppendText(Environment.NewLine);
                            return;
                        }
                        else
                        {
                            OutPut.Text = string.Empty;
                            goto EmptyString;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Must Drop Log File");
                    }
                }
            }
            else if(Path.GetFileName(CurrentFullName).Contains(".patch"))
            {
                string data = Data;
                if (!IsNullOrEmpty(TitleName.Text) && !IsNullOrEmpty(TitleId.Text) && !IsNullOrEmpty(HashKey.Text) && !IsNullOrEmpty(MediaId.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                if (IsNullOrEmpty(TitleName.Text) && IsNullOrEmpty(TitleId.Text) && IsNullOrEmpty(HashKey.Text) && IsNullOrEmpty(MediaId.Text))
                {
                    string getdataheader = Data.Substring(Data.IndexOf("title_name = \"".ToLower()), Data.IndexOf("\n\n"));
                    TitleName.Text = getdataheader.Substring(0, Data.IndexOf("\"\n")).Remove(0,14);

                    TitleId.Text = getdataheader.Substring(data.IndexOf("title_id = \""), Data.IndexOf("\"\n"));//title_id = "
                }
                OutPut.Text = data;
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
                if (Path.GetFileName(CurrentFile[0]).Contains(".patch"))
                {
                    e.Effect = DragDropEffects.Copy;
                    OutputConditions = true;
                }
                else if (Path.GetFileName(CurrentFile[0]).Contains(".log"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    // Don't allow any other drop.
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                // Don't allow any other drop.
                e.Effect = DragDropEffects.None;
            }
        }



        #endregion

        #region Controls

        private void ClearOutput_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsNullOrEmpty(OutPut.Text))
            {
                OutPut.Text = string.Empty;
            }
            else
            {
                return;
            }
        }

        private void SavePatchFile_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void LoadPatchFile_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    OutputConditions = true;
                    OutPut.Text = File.ReadAllText(dialog.FileName);
                    OutputConditions = false;


                }
        }
        public void FormType_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender.GetType().FullName == "XeniaPatchMaker.ValueConverter")
            {
                Program.valueConverter = null;
            }
            else if (sender.GetType().FullName == "XeniaPatchMaker.XPM")
            {
                Program.Load = null;
            }
            else if (sender.GetType().FullName == "XeniaPatchMaker.Settings")
            {
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.DisableDesc == true)
                {
                    Desc.Enabled = false;
                }
                else
                {
                    Desc.Enabled = true;
                }
                if (Properties.Settings.Default.UseDefaultAuthors == true)
                {
                    Authors.Enabled = false;
                    Authors.Text = Properties.Settings.Default.DefaultAuthors;
                }
                else
                {
                    Authors.Enabled = true;
                    Authors.Text = string.Empty;
                }
                Show();
                Program.Settings = null;
            }
        }
        #endregion

        #region Output RichTextBox
        /// <summary>
        /// We Use DevExpress Control to Make Sure Our Colors Change Accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richEditControl1_ForeColorChanged(object sender, EventArgs e)
        {
            OutPut.ForeColor = richEditControl1.Appearance.Text.ForeColor;
            OutPut.BackColor = richEditControl1.Views.SimpleView.BackColor;
        }
        /// <summary>
        /// We Make Sure User Is Finished.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutPut_KeyUp(object sender, KeyEventArgs e)
        {
            OutputConditions = true;
        }
        /// <summary>
        /// We Make Sure User Is Done Typing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutPut_KeyDown(object sender, KeyEventArgs e)
        {
            OutputConditions = false;
        }
        private void OutPut_TextChanged(object sender, EventArgs e)
        {
            //sender.GetType().
            if (Properties.Settings.Default.ColorDisabled == false)
            {
                if (OutputConditions == true)
                {
                    //fix while writing you get glitches

                    //by default
                    CheckKeyword("[[patch]]", Color.FromArgb(74, 139, 197), 0);
                    //by default
                    CheckKeyword("hash =", Color.Coral, 0);
                    //by default
                    if (OutPut.Text.Contains("false"))
                    {
                        CheckKeyword("is_enabled = false".Substring(2), Color.Red, 0);
                    }
                    if (OutPut.Text.Contains("true"))
                    {
                        CheckKeyword("is_enabled = true".Substring(2), Color.Green, 0);
                    }
                    CheckKeyword(" is_enabled = ", Color.FromArgb(126, 59, 188), 0);
                    //by default
                    CheckKeyword("[[patch." + "be32" + "]]", Color.FromArgb(72, 74, 170), 0);
                    CheckKeyword("\"", Color.Red, 0);
                    CheckKeyword("title_name =", Color.Yellow, 0);
                    CheckKeyword("title_id =", Color.Cyan, 0);
                    CheckKeyword("#media_id =", Color.FromArgb(0, 175, 0), 0);

                    CheckKeyword("address = ", Color.FromArgb(214, 136, 82), 0);
                    CheckKeyword("value = ", Color.FromArgb(214, 136, 82), 0);
                    CheckKeyword(" name = ", Color.FromArgb(214, 136, 82), 0);
                    CheckKeyword(" desc = ", Color.FromArgb(214, 136, 82), 0);
                    CheckKeyword(" author = ", Color.FromArgb(214, 136, 82), 0);
                    //Checks User Input's Then Changes Color
                    if (!IsNullOrEmpty(TitleName.Text))
                    {
                        CheckKeyword(TitleName.Text, Color.Green, 0);
                    }
                    else if (!IsNullOrEmpty(TitleId.Text))
                    {
                        CheckKeyword(TitleId.Text, Color.Green, 0);
                    }
                    else if (!IsNullOrEmpty(HashKey.Text))
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
                        CheckKeyword(Desc.Text, Color.FromArgb(214, 136, 82), 0);
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
            }
        }
        #endregion

        private void XPM_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DisableDesc == true)
            {
                Desc.Enabled = false;
            }
            else
            {
                Desc.Enabled = true;
            }
            if (Properties.Settings.Default.UseDefaultAuthors == true)
            {
                Authors.Enabled = false;
                Authors.Text = Properties.Settings.Default.DefaultAuthors;
            }
            else
            {
                Authors.Enabled = true;
                Authors.Text = string.Empty;
            }
        }
    }
}
