using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XeniaPatchMaker.Properties;
using XeniaPatchMaker.Util;
using static XeniaPatchMaker.Program;
using static XeniaPatchMaker.Util.PatchUtil;

namespace XeniaPatchMaker
{
    public partial class XPM : XtraForm
    {
        #region Place Holders
        public static Dictionary<string, string> PPCOpcodes = new Dictionary<string, string>();
        public static string OpcodeType;
        public static string CurrentFullPath { get; set; }
        public static string CurrentFullName { get; set; }
        public static string Data { get; set; }
        public static string IsUpdateUptoDate { get; set; }
        public bool OutputConditions { get; private set; }

        #endregion

        #region Initialize
        public XPM(string[] args)
        {
            InitializeComponent();
            // If a file was dropped..
            if (args.Length > 0)
            {
                if (!args[0].Equals(string.Empty))
                {
                    if (args[0].Contains(".patch.toml"))
                    {
                        LoadPatchData(args[0]);
                    }
                    else if (args[0].Contains(".log"))
                    {
                        Data = File.ReadAllText(args[0]);
                        GetAllTypes(Data.Substring(0, Data.IndexOf("Savegame ID:") + "Savegame ID:".Length));
                        if (Properties.Settings.Default.WriteInfo == true)
                        {
                            if (HashKey.Text.Length > 10)
                            {
                            EmptyString:
                                if (IsNullOrEmpty(Output.Text))
                                {
                                    OutputConditions = true;
                                    Output.AppendText("title_name = \"" + TitleName.Text + "\"");
                                    Output.AppendText(Environment.NewLine);
                                    Output.AppendText("title_id = \"" + TitleId.Text + "\"");
                                    Output.AppendText(Environment.NewLine);
                                    Output.AppendText("hash = \"" + HashKey.Text + "\"");
                                    Output.AppendText(Environment.NewLine);
                                    return;
                                }
                                else
                                {
                                    Output.Text = string.Empty;
                                    goto EmptyString;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Must be a log file.");
                            }
                        }
                    }
                }
            }
        }
        private void XPM_Load(object sender, EventArgs e)
        {
            OutputConditions = true;
            try
            {
                Hide();
                CreateDictonary();
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
                Text = "Xenia Patch Maker by Serenity";
                UpdateChecker checker = new UpdateChecker("TeddyHammer", "XeniaPatchMaker");
                checker.CheckUpdate(locked: UpdateType.Patch).ContinueWith(continuation =>
                {
                    IsUpdateUptoDate = "Needs update!";

                    if (continuation.Result != UpdateType.None)
                    {
                        if (new UpdateNotifyDialog(checker).ShowDialog() == DialogResult.Yes)
                        {
                            MainForm.Enabled = false;
                            Enabled = false;
                            checker.DownloadAsset("XeniaPatchMaker.exe");
                            if (File.Exists(Application.StartupPath + "\\XeniaPatchMakerUpdate.exe"))
                            {
                                File.Move(Application.StartupPath + "\\XeniaPatchMaker.exe", Application.StartupPath + "\\XeniaPatchMakerold.exe");
                                File.Move(Application.StartupPath + "\\XeniaPatchMakerUpdate.exe", Application.StartupPath + "\\XeniaPatchMaker.exe");
                                Process.Start(Application.StartupPath + "\\XeniaPatchMaker.exe");
                                Process.GetCurrentProcess().Kill();
                            }
                        }
                        else
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                    }
                    else
                    {
                        IsUpdateUptoDate = "Up to date!";
                    }
                });
                File.Delete(Application.StartupPath + "\\XeniaPatchMakerold.exe");
            }
            finally
            {
                Show();
            }
        }

        private void CreateDictonary()
        {
            PPCOpcodes.Add("abs",        OpcodeType = "0x7c");
            //PPCOpcodes.Add("abs",        OpcodeType = "0x7c0002d1");
            //PPCOpcodes.Add("abso",       OpcodeType = "0x7c0006d0");
            PPCOpcodes.Add("abso",       OpcodeType = "0x7c0006d1");
            //PPCOpcodes.Add("add",        OpcodeType = "0x7c000214");
            PPCOpcodes.Add("add",        OpcodeType = "0x7c000215");
            //PPCOpcodes.Add("addc",       OpcodeType = "0x7c000014");
            PPCOpcodes.Add("addc",       OpcodeType = "0x7c000015");
            //PPCOpcodes.Add("addco",      OpcodeType = "0x7c000414");
            PPCOpcodes.Add("addco",      OpcodeType = "0x7c000415");
            //PPCOpcodes.Add("adde",       OpcodeType = "0x7c000114");
            PPCOpcodes.Add("adde",       OpcodeType = "0x7c000115");
            //PPCOpcodes.Add("addeo",      OpcodeType = "0x7c000514");
            PPCOpcodes.Add("addeo",      OpcodeType = "0x7c000515");
            PPCOpcodes.Add("addi",       OpcodeType = "0x38");
            PPCOpcodes.Add("addic",      OpcodeType = "0x300000");
            //PPCOpcodes.Add("addic",      OpcodeType = "0x340000");
            PPCOpcodes.Add("addis",      OpcodeType = "0x3c0000");
            PPCOpcodes.Add("addme",      OpcodeType = "0x7c0001d4");
            //PPCOpcodes.Add("addme",      OpcodeType = "0x7c0001d5");
            //PPCOpcodes.Add("addmeo",     OpcodeType = "0x7c0005d4");
            PPCOpcodes.Add("addmeo",     OpcodeType = "0x7c0005d5");
            //PPCOpcodes.Add("addo",       OpcodeType = "0x7c000614");
            PPCOpcodes.Add("addo",       OpcodeType = "0x7c000615");
            //PPCOpcodes.Add("addze",      OpcodeType = "0x7c000194");
            PPCOpcodes.Add("addze",      OpcodeType = "0x7c000195");
            // PPCOpcodes.Add("addzeo",    OpcodeType = "0x7c000594");
            PPCOpcodes.Add("addzeo",     OpcodeType = "0x7c000595");
            //PPCOpcodes.Add("and",        OpcodeType = "0x7c000038");
            PPCOpcodes.Add("and",        OpcodeType = "0x7c000039");
            //PPCOpcodes.Add("andc",       OpcodeType = "0x7c000078");
            PPCOpcodes.Add("andc",       OpcodeType = "0x7c000079");
            PPCOpcodes.Add("andi",       OpcodeType = "0x700000");
            PPCOpcodes.Add("andis",      OpcodeType = "0x740000");
            PPCOpcodes.Add("attn",       OpcodeType = "0x000002");
            PPCOpcodes.Add("b",          OpcodeType = "0x428000");
            //PPCOpcodes.Add("b",          OpcodeType = "0x480000");
            PPCOpcodes.Add("ba",         OpcodeType = "0x42800002");
            //PPCOpcodes.Add("ba",         OpcodeType = "0x48000002");
            PPCOpcodes.Add("bc",         OpcodeType = "0x400000");
            PPCOpcodes.Add("bca",        OpcodeType = "0x40000002");
            PPCOpcodes.Add("bcctr",      OpcodeType = "0x4c000420");
            PPCOpcodes.Add("bcctrl",     OpcodeType = "0x4c000421");
            PPCOpcodes.Add("bcl",        OpcodeType = "0x40000001");
            PPCOpcodes.Add("bcla",       OpcodeType = "0x40000003");
            PPCOpcodes.Add("bclr",       OpcodeType = "0x4c000020");
            PPCOpcodes.Add("bclrl",      OpcodeType = "0x4c000021");
            PPCOpcodes.Add("bctr",       OpcodeType = "0x4c000420");
            //PPCOpcodes.Add("bctr",       OpcodeType = "0x4e800420");
            PPCOpcodes.Add("bctrl",      OpcodeType = "0x4c000421");
            //PPCOpcodes.Add("bctrl",      OpcodeType = "0x4e800421");
            PPCOpcodes.Add("bdnz",       OpcodeType = "0x420000");
            PPCOpcodes.Add("bdnza",      OpcodeType = "0x42000002");
            PPCOpcodes.Add("bdnzf",      OpcodeType = "0x400000");
            PPCOpcodes.Add("bdnzfa",     OpcodeType = "0x40000002");
            PPCOpcodes.Add("bdnzfl",     OpcodeType = "0x40000001");
            PPCOpcodes.Add("bdnzfla",    OpcodeType = "0x40000003");
            PPCOpcodes.Add("bdnzflr",    OpcodeType = "0x4c000020");
            PPCOpcodes.Add("bdnzflrl",   OpcodeType = "0x4c000021");
            PPCOpcodes.Add("bdnzl",      OpcodeType = "0x42000001");
            PPCOpcodes.Add("bdnzla",     OpcodeType = "0x42000003");
            PPCOpcodes.Add("bdnzlr",     OpcodeType = "0x4e000020");
            PPCOpcodes.Add("bdnzlrl",    OpcodeType = "0x4e000021");
            PPCOpcodes.Add("bdnzt",      OpcodeType = "0x410000");
            PPCOpcodes.Add("bdnzta",     OpcodeType = "0x41000002");
            PPCOpcodes.Add("bdnztl",     OpcodeType = "0x41000001");
            PPCOpcodes.Add("bdnztla",    OpcodeType = "0x41000003");
            PPCOpcodes.Add("bdnztlr",    OpcodeType = "0x4d000020");
            PPCOpcodes.Add("bdnztlrl",   OpcodeType = "0x4d000021");
            PPCOpcodes.Add("bdz",        OpcodeType = "0x424000");
            PPCOpcodes.Add("bdza",       OpcodeType = "0x42400002");
            PPCOpcodes.Add("bdzf",       OpcodeType = "0x404000");
            PPCOpcodes.Add("bdzfa",      OpcodeType = "0x40400002");
            PPCOpcodes.Add("bdzfl",      OpcodeType = "0x40400001");
            PPCOpcodes.Add("bdzfla",     OpcodeType = "0x40400003");
            PPCOpcodes.Add("bdzflr",     OpcodeType = "0x4c400020");
            PPCOpcodes.Add("bdzflrl",    OpcodeType = "0x4c400021");
            PPCOpcodes.Add("bdzl",       OpcodeType = "0x42400001");
            PPCOpcodes.Add("bdzla",      OpcodeType = "0x42400003");
            PPCOpcodes.Add("bdzlr",      OpcodeType = "0x4e400020");
            PPCOpcodes.Add("bdzlrl",     OpcodeType = "0x4e400021");
            PPCOpcodes.Add("bdzt",       OpcodeType = "0x414000");
            PPCOpcodes.Add("bdzta",      OpcodeType = "0x41400002");
            PPCOpcodes.Add("bdztl",      OpcodeType = "0x41400001");
            PPCOpcodes.Add("bdztla",     OpcodeType = "0x41400003");
            PPCOpcodes.Add("bdztlr",     OpcodeType = "0x4d400020");
            PPCOpcodes.Add("bdztlrl",    OpcodeType = "0x4d400021");
            PPCOpcodes.Add("beq",        OpcodeType = "0x418200");
            PPCOpcodes.Add("beqa",       OpcodeType = "0x41820002");
            PPCOpcodes.Add("beqctr",     OpcodeType = "0x4d820420");
            PPCOpcodes.Add("beqctrl",    OpcodeType = "0x4d820421");
            PPCOpcodes.Add("beql",       OpcodeType = "0x41820001");
            PPCOpcodes.Add("beqla",      OpcodeType = "0x41820003");
            PPCOpcodes.Add("beqlr",      OpcodeType = "0x4d820020");
            PPCOpcodes.Add("beqlrl",     OpcodeType = "0x4d820021");
            PPCOpcodes.Add("bf",         OpcodeType = "0x408000");
            PPCOpcodes.Add("bfa",        OpcodeType = "0x40800002");
            PPCOpcodes.Add("bfctr",      OpcodeType = "0x4c800420");
            PPCOpcodes.Add("bfctrl",     OpcodeType = "0x4c800421");
            PPCOpcodes.Add("bfl",        OpcodeType = "0x40800001");
            PPCOpcodes.Add("bfla",       OpcodeType = "0x40800003");
            PPCOpcodes.Add("bflr",       OpcodeType = "0x4c800020");
            PPCOpcodes.Add("bflrl",      OpcodeType = "0x4c800021");
            PPCOpcodes.Add("bge",        OpcodeType = "0x408000");
            PPCOpcodes.Add("bgea",       OpcodeType = "0x40800002");
            PPCOpcodes.Add("bgectr",     OpcodeType = "0x4c800420");
            PPCOpcodes.Add("bgectrl",    OpcodeType = "0x4c800421");
            PPCOpcodes.Add("bgel",       OpcodeType = "0x40800001");
            PPCOpcodes.Add("bgela",      OpcodeType = "0x40800003");
            PPCOpcodes.Add("bgelr",      OpcodeType = "0x4c800020");
            PPCOpcodes.Add("bgelrl",     OpcodeType = "0x4c800021");
            PPCOpcodes.Add("bgt",        OpcodeType = "0x418100");
            PPCOpcodes.Add("bgta",       OpcodeType = "0x41810002");
            PPCOpcodes.Add("bgtctr",     OpcodeType = "0x4d810420");
            PPCOpcodes.Add("bgtctrl",    OpcodeType = "0x4d810421");
            PPCOpcodes.Add("bgtl",       OpcodeType = "0x41810001");
            PPCOpcodes.Add("bgtla",      OpcodeType = "0x41810003");
            PPCOpcodes.Add("bgtlr",      OpcodeType = "0x4d810020");
            PPCOpcodes.Add("bgtlrl",     OpcodeType = "0x4d810021");
            PPCOpcodes.Add("bl",         OpcodeType = "0x42800001");
            //PPCOpcodes.Add("bl",         OpcodeType = "0x48000001");
            PPCOpcodes.Add("bla",        OpcodeType = "0x42800003");
            //PPCOpcodes.Add("bla",        OpcodeType = "0x48000003");
            //PPCOpcodes.Add("ble",        OpcodeType = "0x408100");
            PPCOpcodes.Add("blea",       OpcodeType = "0x40810002");
            PPCOpcodes.Add("blectr",     OpcodeType = "0x4c810420");
            PPCOpcodes.Add("blectrl",    OpcodeType = "0x4c810421");
            PPCOpcodes.Add("blel",       OpcodeType = "0x40810001");
            PPCOpcodes.Add("blela",      OpcodeType = "0x40810003");
            PPCOpcodes.Add("blelr",      OpcodeType = "0x4c810020");
            PPCOpcodes.Add("blelrl",     OpcodeType = "0x4c810021");
            PPCOpcodes.Add("blr",        OpcodeType = "0x4e800020");
            PPCOpcodes.Add("blrl",       OpcodeType = "0x4e800021");
            PPCOpcodes.Add("blt",        OpcodeType = "0x418000");
            PPCOpcodes.Add("blta",       OpcodeType = "0x41800002");
            PPCOpcodes.Add("bltctr",     OpcodeType = "0x4d800420");
            PPCOpcodes.Add("bltctrl",    OpcodeType = "0x4d800421");
            PPCOpcodes.Add("bltl",       OpcodeType = "0x41800001");
            PPCOpcodes.Add("bltla",      OpcodeType = "0x41800003");
            PPCOpcodes.Add("bltlr",      OpcodeType = "0x4d800020");
            PPCOpcodes.Add("bltlrl",     OpcodeType = "0x4d800021");
            PPCOpcodes.Add("bne",        OpcodeType = "0x408200");
            PPCOpcodes.Add("bnea",       OpcodeType = "0x40820002");
            PPCOpcodes.Add("bnectr",     OpcodeType = "0x4c820420");
            PPCOpcodes.Add("bnectrl",    OpcodeType = "0x4c820421");
            PPCOpcodes.Add("bnel",       OpcodeType = "0x40820001");
            PPCOpcodes.Add("bnela",      OpcodeType = "0x40820003");
            PPCOpcodes.Add("bnelr",      OpcodeType = "0x4c820020");
            PPCOpcodes.Add("bnelrl",     OpcodeType = "0x4c820021");
            PPCOpcodes.Add("bng",        OpcodeType = "0x408100");
            PPCOpcodes.Add("bnga",       OpcodeType = "0x40810002");
            PPCOpcodes.Add("bngctr",     OpcodeType = "0x4c810420");
            PPCOpcodes.Add("bngctrl",    OpcodeType = "0x4c810421");
            PPCOpcodes.Add("bngl",       OpcodeType = "0x40810001");
            PPCOpcodes.Add("bngla",      OpcodeType = "0x40810003");
            PPCOpcodes.Add("bnglr",      OpcodeType = "0x4c810020");
            PPCOpcodes.Add("bnglrl",     OpcodeType = "0x4c810021");
            PPCOpcodes.Add("bnl",        OpcodeType = "0x408000");
            PPCOpcodes.Add("bnla",       OpcodeType = "0x40800002");
            PPCOpcodes.Add("bnlctr",     OpcodeType = "0x4c800420");
            PPCOpcodes.Add("bnlctrl",    OpcodeType = "0x4c800421");
            PPCOpcodes.Add("bnll",       OpcodeType = "0x40800001");
            PPCOpcodes.Add("bnlla",      OpcodeType = "0x40800003");
            PPCOpcodes.Add("bnllr",      OpcodeType = "0x4c800020");
            PPCOpcodes.Add("bnllrl",     OpcodeType = "0x4c800021");
            PPCOpcodes.Add("bns",        OpcodeType = "0x408300");
            PPCOpcodes.Add("bnsa",       OpcodeType = "0x40830002");
            PPCOpcodes.Add("bnsctr",     OpcodeType = "0x4c830420");
            PPCOpcodes.Add("bnsctrl",    OpcodeType = "0x4c830421");
            PPCOpcodes.Add("bnsl",       OpcodeType = "0x40830001");
            PPCOpcodes.Add("bnsla",      OpcodeType = "0x40830003");
            PPCOpcodes.Add("bnslr",      OpcodeType = "0x4c830020");
            PPCOpcodes.Add("bnslrl",     OpcodeType = "0x4c830021");
            PPCOpcodes.Add("bnu",        OpcodeType = "0x408300");
            PPCOpcodes.Add("bnua",       OpcodeType = "0x40830002");
            PPCOpcodes.Add("bnuctr",     OpcodeType = "0x4c830420");
            PPCOpcodes.Add("bnuctrl",    OpcodeType = "0x4c830421");
            PPCOpcodes.Add("bnul",       OpcodeType = "0x40830001");
            PPCOpcodes.Add("bnula",      OpcodeType = "0x40830003");
            PPCOpcodes.Add("bnulr",      OpcodeType = "0x4c830020");
            PPCOpcodes.Add("bnulrl",     OpcodeType = "0x4c830021");
            PPCOpcodes.Add("bso",        OpcodeType = "0x418300");
            PPCOpcodes.Add("bsoa",       OpcodeType = "0x41830002");
            PPCOpcodes.Add("bsoctr",     OpcodeType = "0x4d830420");
            PPCOpcodes.Add("bsoctrl",    OpcodeType = "0x4d830421");
            PPCOpcodes.Add("bsol",       OpcodeType = "0x41830001");
            PPCOpcodes.Add("bsola",      OpcodeType = "0x41830003");
            PPCOpcodes.Add("bsolr",      OpcodeType = "0x4d830020");
            PPCOpcodes.Add("bsolrl",     OpcodeType = "0x4d830021");
            PPCOpcodes.Add("bt",         OpcodeType = "0x418000");
            PPCOpcodes.Add("bta",        OpcodeType = "0x41800002");
            PPCOpcodes.Add("btctr",      OpcodeType = "0x4d800420");
            PPCOpcodes.Add("btctrl",     OpcodeType = "0x4d800421");
            PPCOpcodes.Add("btl",        OpcodeType = "0x41800001");
            PPCOpcodes.Add("btla",       OpcodeType = "0x41800003");
            PPCOpcodes.Add("btlr",       OpcodeType = "0x4d800020");
            PPCOpcodes.Add("btlrl",      OpcodeType = "0x4d800021");
            PPCOpcodes.Add("bun",        OpcodeType = "0x418300");
            PPCOpcodes.Add("buna",       OpcodeType = "0x41830002");
            PPCOpcodes.Add("bunctr",     OpcodeType = "0x4d830420");
            PPCOpcodes.Add("bunctrl",    OpcodeType = "0x4d830421");
            PPCOpcodes.Add("bunl",       OpcodeType = "0x41830001");
            PPCOpcodes.Add("bunla",      OpcodeType = "0x41830003");
            PPCOpcodes.Add("bunlr",      OpcodeType = "0x4d830020");
            PPCOpcodes.Add("bunlrl",     OpcodeType = "0x4d830021");
            PPCOpcodes.Add("clcs",       OpcodeType = "0x7c000426");
            PPCOpcodes.Add("cmp",        OpcodeType = "0x7c0000");
            PPCOpcodes.Add("cmpd",       OpcodeType = "0x7c2000");
            PPCOpcodes.Add("cmpdi",      OpcodeType = "0x2c2000");
            PPCOpcodes.Add("cmpi",       OpcodeType = "0x2c0000");
            PPCOpcodes.Add("cmpl",       OpcodeType = "0x7c000040");
            PPCOpcodes.Add("cmpld",      OpcodeType = "0x7c200040");
            PPCOpcodes.Add("cmpldi",     OpcodeType = "0x282000");
            PPCOpcodes.Add("cmpli",      OpcodeType = "0x280000");
            PPCOpcodes.Add("cmplw",      OpcodeType = "0x7c000040");
            PPCOpcodes.Add("cmplwi",     OpcodeType = "0x280000");
            PPCOpcodes.Add("cmpw",       OpcodeType = "0x7c0000");
            PPCOpcodes.Add("cmpwi",      OpcodeType = "0x2c0000");
            PPCOpcodes.Add("cntlzd",     OpcodeType = "0x7c000074");
            //PPCOpcodes.Add("cntlzd",     OpcodeType = "0x7c000075");
            //PPCOpcodes.Add("cntlzw",     OpcodeType = "0x7c000034");
            PPCOpcodes.Add("cntlzw",     OpcodeType = "0x7c000035");
            PPCOpcodes.Add("crand",      OpcodeType = "0x4c000202");
            PPCOpcodes.Add("crandc",     OpcodeType = "0x4c000102");
            PPCOpcodes.Add("creqv",      OpcodeType = "0x4c000242");
            PPCOpcodes.Add("crnand",     OpcodeType = "0x4c0001c2");
            PPCOpcodes.Add("crnor",      OpcodeType = "0x4c000042");
            PPCOpcodes.Add("cror",       OpcodeType = "0x4c000382");
            PPCOpcodes.Add("crorc",      OpcodeType = "0x4c000342");
            PPCOpcodes.Add("crxor",      OpcodeType = "0x4c000182");
            PPCOpcodes.Add("dcba",       OpcodeType = "0x7c0005ec");
            PPCOpcodes.Add("dcbf",       OpcodeType = "0x7c0000ac");
            PPCOpcodes.Add("dcbi",       OpcodeType = "0x7c0003ac");
            PPCOpcodes.Add("dcbst",      OpcodeType = "0x7c00006c");
            PPCOpcodes.Add("dcbt",       OpcodeType = "0x7c00022c");
            PPCOpcodes.Add("dcbt128",    OpcodeType = "0x7c00022c");
            PPCOpcodes.Add("dcbtst",     OpcodeType = "0x7c0001ec");
            PPCOpcodes.Add("dcbz",       OpcodeType = "0x7c0007ec");
            PPCOpcodes.Add("dcbz128",    OpcodeType = "0x7c2007ec");
            PPCOpcodes.Add("dcbzl",      OpcodeType = "0x7c2007ec");
            PPCOpcodes.Add("div",        OpcodeType = "0x7c000296");
            //PPCOpcodes.Add("div",        OpcodeType = "0x7c000297");
            PPCOpcodes.Add("divd",       OpcodeType = "0x7c0003d2");
            //PPCOpcodes.Add("divd",       OpcodeType = "0x7c0003d3");
            //PPCOpcodes.Add("divdo",      OpcodeType = "0x7c0007d2");
            PPCOpcodes.Add("divdo",      OpcodeType = "0x7c0007d3");
            PPCOpcodes.Add("divdu",      OpcodeType = "0x7c000392");
            //PPCOpcodes.Add("divdu",      OpcodeType = "0x7c000393");
            //PPCOpcodes.Add("divduo",     OpcodeType = "0x7c000792");
            PPCOpcodes.Add("divduo",     OpcodeType = "0x7c000793");
            PPCOpcodes.Add("divo",       OpcodeType = "0x7c000696");
            //PPCOpcodes.Add("divo",       OpcodeType = "0x7c000697");
            PPCOpcodes.Add("divs",       OpcodeType = "0x7c0002d6");
            //PPCOpcodes.Add("divs",       OpcodeType = "0x7c0002d7");
            //PPCOpcodes.Add("divso",      OpcodeType = "0x7c0006d6");
            PPCOpcodes.Add("divso",      OpcodeType = "0x7c0006d7");
            //PPCOpcodes.Add("divw",       OpcodeType = "0x7c0003d6");
            PPCOpcodes.Add("divw",       OpcodeType = "0x7c0003d7");
            PPCOpcodes.Add("divwo",      OpcodeType = "0x7c0007d6");
            //PPCOpcodes.Add("divwo",      OpcodeType = "0x7c0007d7");
            PPCOpcodes.Add("divwu",      OpcodeType = "0x7c000396");
            //PPCOpcodes.Add("divwu",      OpcodeType = "0x7c000397");
            PPCOpcodes.Add("divwuo",     OpcodeType = "0x7c000796");
            //PPCOpcodes.Add("divwuo",     OpcodeType = "0x7c000797");
            PPCOpcodes.Add("doz",        OpcodeType = "0x7c000210");
            //PPCOpcodes.Add("doz",        OpcodeType = "0x7c000211");
            PPCOpcodes.Add("dozi",       OpcodeType = "0x240000");
            //PPCOpcodes.Add("dozo",       OpcodeType = "0x7c000610");
            PPCOpcodes.Add("dozo",       OpcodeType = "0x7c000611");
            PPCOpcodes.Add("dss",        OpcodeType = "0x7c00066c");
            PPCOpcodes.Add("dssall",     OpcodeType = "0x7e00066c");
            PPCOpcodes.Add("dst",        OpcodeType = "0x7c0002ac");
            PPCOpcodes.Add("dstst",      OpcodeType = "0x7c0002ec");
            PPCOpcodes.Add("dststt",     OpcodeType = "0x7e0002ec");
            PPCOpcodes.Add("dstt",       OpcodeType = "0x7e0002ac");
            PPCOpcodes.Add("eciwx",      OpcodeType = "0x7c00026c");
            PPCOpcodes.Add("ecowx",      OpcodeType = "0x7c00036c");
            PPCOpcodes.Add("eieio",      OpcodeType = "0x7c0006ac");
            PPCOpcodes.Add("eqv",        OpcodeType = "0x7c000238");
            //PPCOpcodes.Add("eqv",        OpcodeType = "0x7c000239");
            PPCOpcodes.Add("extsb",      OpcodeType = "0x7c000774");
            // PPCOpcodes.Add("extsb",     OpcodeType = "0x7c000775");
            PPCOpcodes.Add("extsh",      OpcodeType = "0x7c000734");
            //PPCOpcodes.Add("extsh",      OpcodeType = "0x7c000735");
            PPCOpcodes.Add("extsw",      OpcodeType = "0x7c0007b4");
            //PPCOpcodes.Add("extsw",      OpcodeType = "0x7c0007b5");
            //PPCOpcodes.Add("fabs",       OpcodeType = "0xfc000210");
            PPCOpcodes.Add("fabs",       OpcodeType = "0xfc000211");
            //PPCOpcodes.Add("fadd",       OpcodeType = "0xfc00002a");
            PPCOpcodes.Add("fadd",       OpcodeType = "0xfc00002b");
            //PPCOpcodes.Add("fadds",      OpcodeType = "0xec00002a");
            PPCOpcodes.Add("fadds",      OpcodeType = "0xec00002b");
            //PPCOpcodes.Add("fcfid",      OpcodeType = "0xfc00069c");
            PPCOpcodes.Add("fcfid",      OpcodeType = "0xfc00069d");
            PPCOpcodes.Add("fcmpo",      OpcodeType = "0xfc000040");
            PPCOpcodes.Add("fcmpu",      OpcodeType = "0xfc0000");
            //PPCOpcodes.Add("fctid",      OpcodeType = "0xfc00065c");
            PPCOpcodes.Add("fctid",      OpcodeType = "0xfc00065d");
            //PPCOpcodes.Add("fctidz",     OpcodeType = "0xfc00065e");
            PPCOpcodes.Add("fctidz",     OpcodeType = "0xfc00065f");
            //PPCOpcodes.Add("fctiw",      OpcodeType = "0xfc00001c");
            PPCOpcodes.Add("fctiw",      OpcodeType = "0xfc00001d");
            //PPCOpcodes.Add("fctiwz",     OpcodeType = "0xfc00001e");
            PPCOpcodes.Add("fctiwz",     OpcodeType = "0xfc00001f");
            //PPCOpcodes.Add("fdiv",       OpcodeType = "0xfc000024");
            PPCOpcodes.Add("fdiv",       OpcodeType = "0xfc000025");
            //PPCOpcodes.Add("fdivs",      OpcodeType = "0xec000024");
            PPCOpcodes.Add("fdivs",      OpcodeType = "0xec000025");
            //PPCOpcodes.Add("fmadd",      OpcodeType = "0xfc00003a");
            PPCOpcodes.Add("fmadd",      OpcodeType = "0xfc00003b");
            //PPCOpcodes.Add("fmadds",     OpcodeType = "0xec00003a");
            PPCOpcodes.Add("fmadds",     OpcodeType = "0xec00003b");
            PPCOpcodes.Add("fmr",        OpcodeType = "0xfc000090");
            //PPCOpcodes.Add("fmr",        OpcodeType = "0xfc000091");
            PPCOpcodes.Add("fmsub",      OpcodeType = "0xfc000038");
            //PPCOpcodes.Add("fmsub",      OpcodeType = "0xfc000039");
            //PPCOpcodes.Add("fmsubs",     OpcodeType = "0xec000038");
            PPCOpcodes.Add("fmsubs",     OpcodeType = "0xec000039");
            //PPCOpcodes.Add("fmul",       OpcodeType = "0xfc000032");
            PPCOpcodes.Add("fmul",       OpcodeType = "0xfc000033");
            //PPCOpcodes.Add("fmuls",      OpcodeType = "0xec000032");
            PPCOpcodes.Add("fmuls",      OpcodeType = "0xec000033");
            //PPCOpcodes.Add("fnabs",      OpcodeType = "0xfc000110");
            PPCOpcodes.Add("fnabs",      OpcodeType = "0xfc000111");
            //PPCOpcodes.Add("fneg",       OpcodeType = "0xfc000050");
            PPCOpcodes.Add("fneg",       OpcodeType = "0xfc000051");
            PPCOpcodes.Add("fnmadd",     OpcodeType = "0xfc00003e");
            //PPCOpcodes.Add("fnmadd",     OpcodeType = "0xfc00003f");
            PPCOpcodes.Add("fnmadds",    OpcodeType = "0xec00003e");
            //PPCOpcodes.Add("fnmadds",    OpcodeType = "0xec00003f");
            PPCOpcodes.Add("fnmsub",     OpcodeType = "0xfc00003c");
            //PPCOpcodes.Add("fnmsub",     OpcodeType = "0xfc00003d");
            PPCOpcodes.Add("fnmsubs",    OpcodeType = "0xec00003c");
            //PPCOpcodes.Add("fnmsubs",    OpcodeType = "0xec00003d");
            PPCOpcodes.Add("fres",       OpcodeType = "0xec000030");
            //PPCOpcodes.Add("fres",       OpcodeType = "0xec000031");
            PPCOpcodes.Add("frsp",       OpcodeType = "0xfc000018");
            //PPCOpcodes.Add("frsp",       OpcodeType = "0xfc000019");
            PPCOpcodes.Add("frsqrte",    OpcodeType = "0xfc000034");
            //PPCOpcodes.Add("frsqrte",    OpcodeType = "0xfc000035");
            PPCOpcodes.Add("fsel",       OpcodeType = "0xfc00002e");
            //PPCOpcodes.Add("fsel",       OpcodeType = "0xfc00002f");
            PPCOpcodes.Add("fsqrt",      OpcodeType = "0xfc00002c");
            //PPCOpcodes.Add("fsqrt",      OpcodeType = "0xfc00002d");
            PPCOpcodes.Add("fsqrts",     OpcodeType = "0xec00002c");
            //PPCOpcodes.Add("fsqrts",     OpcodeType = "0xec00002d");
            PPCOpcodes.Add("fsub",       OpcodeType = "0xfc000028");
            //PPCOpcodes.Add("fsub",       OpcodeType = "0xfc000029");
            PPCOpcodes.Add("fsubs",      OpcodeType = "0xec000028");
            //PPCOpcodes.Add("fsubs",      OpcodeType = "0xec000029");
            PPCOpcodes.Add("icbi",       OpcodeType = "0x7c0007ac");
            PPCOpcodes.Add("isync",      OpcodeType = "0x4c00012c");
            PPCOpcodes.Add("jbsr",       OpcodeType = "0x48000001");
            PPCOpcodes.Add("jmp",        OpcodeType = "0x480000");
            PPCOpcodes.Add("la",         OpcodeType = "0x380000");
            PPCOpcodes.Add("lbz",        OpcodeType = "0x880000");
            PPCOpcodes.Add("lbzu",       OpcodeType = "0x8c0000");
            PPCOpcodes.Add("lbzux",      OpcodeType = "0x7c0000ee");
            PPCOpcodes.Add("lbzx",       OpcodeType = "0x7c0000ae");
            PPCOpcodes.Add("ld",         OpcodeType = "0xe80000");
            PPCOpcodes.Add("ldarx",      OpcodeType = "0x7c0000a8");
            PPCOpcodes.Add("ldu",        OpcodeType = "0xe8000001");
            PPCOpcodes.Add("ldux",       OpcodeType = "0x7c00006a");
            PPCOpcodes.Add("ldx",        OpcodeType = "0x7c00002a");
            PPCOpcodes.Add("lfd",        OpcodeType = "0xc80000");
            PPCOpcodes.Add("lfdu",       OpcodeType = "0xcc0000");
            PPCOpcodes.Add("lfdux",      OpcodeType = "0x7c0004ee");
            PPCOpcodes.Add("lfdx",       OpcodeType = "0x7c0004ae");
            PPCOpcodes.Add("lfs",        OpcodeType = "0xc00000");
            PPCOpcodes.Add("lfsu",       OpcodeType = "0xc40000");
            PPCOpcodes.Add("lfsux",      OpcodeType = "0x7c00046e");
            PPCOpcodes.Add("lfsx",       OpcodeType = "0x7c00042e");
            PPCOpcodes.Add("lha",        OpcodeType = "0xa80000");
            PPCOpcodes.Add("lhau",       OpcodeType = "0xac0000");
            PPCOpcodes.Add("lhaux",      OpcodeType = "0x7c0002ee");
            PPCOpcodes.Add("lhax",       OpcodeType = "0x7c0002ae");
            PPCOpcodes.Add("lhbrx",      OpcodeType = "0x7c00062c");
            PPCOpcodes.Add("lhz",        OpcodeType = "0xa00000");
            PPCOpcodes.Add("lhzu",       OpcodeType = "0xa40000");
            PPCOpcodes.Add("lhzux",      OpcodeType = "0x7c00026e");
            PPCOpcodes.Add("lhzx",       OpcodeType = "0x7c00022e");
            PPCOpcodes.Add("li",         OpcodeType = "0x380000");
            PPCOpcodes.Add("lis",        OpcodeType = "0x3c0000");
            PPCOpcodes.Add("lmw",        OpcodeType = "0xb80000");
            PPCOpcodes.Add("lscbx",      OpcodeType = "0x7c00022a");
            //PPCOpcodes.Add("lscbx",      OpcodeType = "0x7c00022b");
            PPCOpcodes.Add("lswi",       OpcodeType = "0x7c0004aa");
            PPCOpcodes.Add("lswx",       OpcodeType = "0x7c00042a");
            PPCOpcodes.Add("lvebx",      OpcodeType = "0x7c00000e");
            PPCOpcodes.Add("lvehx",      OpcodeType = "0x7c00004e");
            PPCOpcodes.Add("lvewx",      OpcodeType = "0x7c00008e");
            PPCOpcodes.Add("lvsl",       OpcodeType = "0x7c00000c");
            PPCOpcodes.Add("lvsr",       OpcodeType = "0x7c00004c");
            PPCOpcodes.Add("lvx",        OpcodeType = "0x7c0000ce");
            PPCOpcodes.Add("lvxl",       OpcodeType = "0x7c0002ce");
            PPCOpcodes.Add("lwa",        OpcodeType = "0xe8000002");
            PPCOpcodes.Add("lwarx",      OpcodeType = "0x7c000028");
            PPCOpcodes.Add("lwaux",      OpcodeType = "0x7c0002ea");
            PPCOpcodes.Add("lwax",       OpcodeType = "0x7c0002aa");
            PPCOpcodes.Add("lwbrx",      OpcodeType = "0x7c00042c");
            PPCOpcodes.Add("lwsync",     OpcodeType = "0x7c2004ac");
            PPCOpcodes.Add("lwz",        OpcodeType = "0x800000");
            PPCOpcodes.Add("lwzu",       OpcodeType = "0x840000");
            PPCOpcodes.Add("lwzux",      OpcodeType = "0x7c00006e");
            PPCOpcodes.Add("lwzx",       OpcodeType = "0x7c00002e");
            PPCOpcodes.Add("maskg",      OpcodeType = "0x7c00003a");
            //PPCOpcodes.Add("maskg",      OpcodeType = "0x7c00003b");
            PPCOpcodes.Add("maskir",     OpcodeType = "0x7c00043a");
            //PPCOpcodes.Add("maskir",     OpcodeType = "0x7c00043b");
            PPCOpcodes.Add("mcrf",       OpcodeType = "0x4c0000");
            PPCOpcodes.Add("mcrfs",      OpcodeType = "0xfc000080");
            PPCOpcodes.Add("mcrxr",      OpcodeType = "0x7c0004");
            PPCOpcodes.Add("mfcr",       OpcodeType = "0x7c000026");
            //PPCOpcodes.Add("mfcr",       OpcodeType = "0x7c100026");
            PPCOpcodes.Add("mfctr",      OpcodeType = "0x7c0902a6");
            PPCOpcodes.Add("mffs",       OpcodeType = "0xfc00048e");
            //PPCOpcodes.Add("mffs",       OpcodeType = "0xfc00048f");
            PPCOpcodes.Add("mflr",       OpcodeType = "0x7c0802a6");
            PPCOpcodes.Add("mfmq",       OpcodeType = "0x7c0002a6");
            PPCOpcodes.Add("mfmsr",      OpcodeType = "0x7c0000a6");
            PPCOpcodes.Add("mfocrf",     OpcodeType = "0x7c100026");
            PPCOpcodes.Add("mfrtcl",     OpcodeType = "0x7c0502a6");
            PPCOpcodes.Add("mfrtcu",     OpcodeType = "0x7c0402a6");
            PPCOpcodes.Add("mfspr",      OpcodeType = "0x7c0002a6");
            PPCOpcodes.Add("mfsr",       OpcodeType = "0x7c0004a6");
            PPCOpcodes.Add("mfsrin",     OpcodeType = "0x7c000526");
            PPCOpcodes.Add("mftb",       OpcodeType = "0x7c0002e6");
            //PPCOpcodes.Add("mftb",       OpcodeType = "0x7c0c42e6");
            PPCOpcodes.Add("mftbu",      OpcodeType = "0x7c0d42e6");
            PPCOpcodes.Add("mfvscr",     OpcodeType = "0x10000604");
            PPCOpcodes.Add("mfxer",      OpcodeType = "0x7c0102a6");
            PPCOpcodes.Add("mtcrf",      OpcodeType = "0x7c000120");
            PPCOpcodes.Add("mtctr",      OpcodeType = "0x7c0903a6");
            PPCOpcodes.Add("mtfsb0",     OpcodeType = "0xfc00008c");
            //PPCOpcodes.Add("mtfsb0",     OpcodeType = "0xfc00008d");
            PPCOpcodes.Add("mtfsb1",     OpcodeType = "0xfc00004c");
            //PPCOpcodes.Add("mtfsb1",     OpcodeType = "0xfc00004d");
            PPCOpcodes.Add("mtfsf",      OpcodeType = "0xfc00058e");
            //PPCOpcodes.Add("mtfsf",      OpcodeType = "0xfc00058f");
            PPCOpcodes.Add("mtfsfi",     OpcodeType = "0xfc00010c");
            //PPCOpcodes.Add("mtfsfi",     OpcodeType = "0xfc00010d");
            PPCOpcodes.Add("mtlr",       OpcodeType = "0x7c0803a6");
            PPCOpcodes.Add("mtmq",       OpcodeType = "0x7c0003a6");
            PPCOpcodes.Add("mtmsr",      OpcodeType = "0x7c000124");
            PPCOpcodes.Add("mtmsrd",     OpcodeType = "0x7c000164");
            PPCOpcodes.Add("mtocrf",     OpcodeType = "0x7c000120");
            PPCOpcodes.Add("mtrtcl",     OpcodeType = "0x7c1503a6");
            PPCOpcodes.Add("mtrtcu",     OpcodeType = "0x7c1403a6");
            PPCOpcodes.Add("mtspr",      OpcodeType = "0x7c0003a6");
            PPCOpcodes.Add("mtsr",       OpcodeType = "0x7c0001a4");
            PPCOpcodes.Add("mtsrin",     OpcodeType = "0x7c0001e4");
            PPCOpcodes.Add("mttbl",      OpcodeType = "0x7c1c43a6");
            PPCOpcodes.Add("mttbu",      OpcodeType = "0x7c1d43a6");
            PPCOpcodes.Add("mtvscr",     OpcodeType = "0x10000644");
            PPCOpcodes.Add("mtxer",      OpcodeType = "0x7c0103a6");
            PPCOpcodes.Add("mul",        OpcodeType = "0x7c0000d6");
            //PPCOpcodes.Add("mul",        OpcodeType = "0x7c0000d7");
            PPCOpcodes.Add("mulhd",      OpcodeType = "0x7c000092");
            //PPCOpcodes.Add("mulhd",      OpcodeType = "0x7c000093");
            PPCOpcodes.Add("mulhdu",     OpcodeType = "0x7c000012");
            //PPCOpcodes.Add("mulhdu",     OpcodeType = "0x7c000013");
            PPCOpcodes.Add("mulhw",      OpcodeType = "0x7c000096");
            //PPCOpcodes.Add("mulhw",      OpcodeType = "0x7c000097");
            PPCOpcodes.Add("mulhwu",     OpcodeType = "0x7c000016");
            //PPCOpcodes.Add("mulhwu",     OpcodeType = "0x7c000017");
            //PPCOpcodes.Add("mull",       OpcodeType = "0x7c0001d6");
            PPCOpcodes.Add("mull",       OpcodeType = "0x7c0001d7");
            PPCOpcodes.Add("mulld",      OpcodeType = "0x7c0001d2");
            //PPCOpcodes.Add("mulld",      OpcodeType = "0x7c0001d3");
            PPCOpcodes.Add("mulldo",     OpcodeType = "0x7c0005d2");
            //PPCOpcodes.Add("mulldo",     OpcodeType = "0x7c0005d3");
            PPCOpcodes.Add("mulli",      OpcodeType = "0x1c0000");
            PPCOpcodes.Add("mullo",      OpcodeType = "0x7c0005d6");
            //PPCOpcodes.Add("mullo",      OpcodeType = "0x7c0005d7");
            //PPCOpcodes.Add("mullw",      OpcodeType = "0x7c0001d6");
            PPCOpcodes.Add("mullw",      OpcodeType = "0x7c0001d7");
            PPCOpcodes.Add("mullwo",     OpcodeType = "0x7c0005d6");
            //PPCOpcodes.Add("mullwo",     OpcodeType = "0x7c0005d7");
            PPCOpcodes.Add("mulo",       OpcodeType = "0x7c0004d6");
            //PPCOpcodes.Add("mulo",       OpcodeType = "0x7c0004d7");
            PPCOpcodes.Add("mulwd",      OpcodeType = "0x7c000096");
            //PPCOpcodes.Add("mulwd",      OpcodeType = "0x7c000097");
            //PPCOpcodes.Add("nabs",       OpcodeType = "0x7c0003d0");
            PPCOpcodes.Add("nabs",       OpcodeType = "0x7c0003d1");
            //PPCOpcodes.Add("nabso",      OpcodeType = "0x7c0007d0");
            PPCOpcodes.Add("nabso",      OpcodeType = "0x7c0007d1");
            //PPCOpcodes.Add("nand",       OpcodeType = "0x7c0003b8");
            PPCOpcodes.Add("nand",       OpcodeType = "0x7c0003b9");
            //PPCOpcodes.Add("neg",        OpcodeType = "0x7c0000d0");
            PPCOpcodes.Add("neg",        OpcodeType = "0x7c0000d1");
            //PPCOpcodes.Add("nego",       OpcodeType = "0x7c0004d0");
            PPCOpcodes.Add("nego",       OpcodeType = "0x7c0004d1");
            PPCOpcodes.Add("nop",        OpcodeType = "0x600000");
            //PPCOpcodes.Add("nor",        OpcodeType = "0x7c0000f8");
            PPCOpcodes.Add("nor",        OpcodeType = "0x7c0000f9");
            //PPCOpcodes.Add("or",         OpcodeType = "0x7c000378");
            PPCOpcodes.Add("or",         OpcodeType = "0x7c000379");
            //PPCOpcodes.Add("orc",        OpcodeType = "0x7c000338");
            PPCOpcodes.Add("orc",        OpcodeType = "0x7c000339");
            PPCOpcodes.Add("ori",        OpcodeType = "0x600000");
            PPCOpcodes.Add("oris",       OpcodeType = "0x640000");
            PPCOpcodes.Add("ptesync",    OpcodeType = "0x7c4004ac");
            PPCOpcodes.Add("rfi",        OpcodeType = "0x4c000064");
            PPCOpcodes.Add("rfid",       OpcodeType = "0x4c000024");
            //PPCOpcodes.Add("rldcl",      OpcodeType = "0x78000010");
            PPCOpcodes.Add("rldcl",      OpcodeType = "0x78000011");
            PPCOpcodes.Add("rldcr",      OpcodeType = "0x78000012");
            //PPCOpcodes.Add("rldcr",      OpcodeType = "0x78000013");
            PPCOpcodes.Add("rldic",      OpcodeType = "0x78000008");
            //PPCOpcodes.Add("rldic",      OpcodeType = "0x78000009");
            PPCOpcodes.Add("rldicl",     OpcodeType = "0x780000");
            //PPCOpcodes.Add("rldicl",     OpcodeType = "0x78000001");
            PPCOpcodes.Add("rldicr",     OpcodeType = "0x78000004");
            //PPCOpcodes.Add("rldicr",     OpcodeType = "0x78000005");
            PPCOpcodes.Add("rldimi",     OpcodeType = "0x7800000c");
            //PPCOpcodes.Add("rldimi",     OpcodeType = "0x7800000d");
            PPCOpcodes.Add("rlmi",       OpcodeType = "0x580000");
            //PPCOpcodes.Add("rlmi",       OpcodeType = "0x58000001");
            //PPCOpcodes.Add("rlwimi",     OpcodeType = "0x500000");
            PPCOpcodes.Add("rlwimi",     OpcodeType = "0x50000001");
            PPCOpcodes.Add("rlwinm",     OpcodeType = "0x540000");
            //PPCOpcodes.Add("rlwinm",     OpcodeType = "0x54000001");
            PPCOpcodes.Add("rlwnm",      OpcodeType = "0x5c0000");
            //PPCOpcodes.Add("rlwnm",      OpcodeType = "0x5c000001");
            //PPCOpcodes.Add("rrib",       OpcodeType = "0x7c000432");
            PPCOpcodes.Add("rrib",       OpcodeType = "0x7c000433");
            PPCOpcodes.Add("sc",         OpcodeType = "0x44000002");
            PPCOpcodes.Add("slbia",      OpcodeType = "0x7c0003e4");
            PPCOpcodes.Add("slbie",      OpcodeType = "0x7c000364");
            PPCOpcodes.Add("slbmfee",    OpcodeType = "0x7c000726");
            PPCOpcodes.Add("slbmfev",    OpcodeType = "0x7c0006a6");
            PPCOpcodes.Add("slbmte",     OpcodeType = "0x7c000324");
            PPCOpcodes.Add("sld",        OpcodeType = "0x7c000036");
            //PPCOpcodes.Add("sld",        OpcodeType = "0x7c000037");
            //PPCOpcodes.Add("sle",        OpcodeType = "0x7c000132");
            PPCOpcodes.Add("sle",        OpcodeType = "0x7c000133");
            //PPCOpcodes.Add("sleq",       OpcodeType = "0x7c0001b2");
            PPCOpcodes.Add("sleq",       OpcodeType = "0x7c0001b3");
            PPCOpcodes.Add("sliq",       OpcodeType = "0x7c000170");
            //PPCOpcodes.Add("sliq",       OpcodeType = "0x7c000171");
            //PPCOpcodes.Add("slliq",      OpcodeType = "0x7c0001f0");
            PPCOpcodes.Add("slliq",      OpcodeType = "0x7c0001f1");
            //PPCOpcodes.Add("sllq",       OpcodeType = "0x7c0001b0");
            PPCOpcodes.Add("sllq",       OpcodeType = "0x7c0001b1");
            //PPCOpcodes.Add("slq",        OpcodeType = "0x7c000130");
            PPCOpcodes.Add("slq",        OpcodeType = "0x7c000131");
            PPCOpcodes.Add("slw",        OpcodeType = "0x7c000030");
            //PPCOpcodes.Add("slw",        OpcodeType = "0x7c000031");
            //PPCOpcodes.Add("srad",       OpcodeType = "0x7c000634");
            PPCOpcodes.Add("srad",       OpcodeType = "0x7c000635");
            PPCOpcodes.Add("sradi",      OpcodeType = "0x7c000674");
            //PPCOpcodes.Add("sradi",      OpcodeType = "0x7c000675");
            PPCOpcodes.Add("sraiq",      OpcodeType = "0x7c000770");
            //PPCOpcodes.Add("sraiq",      OpcodeType = "0x7c000771");
            PPCOpcodes.Add("sraq",       OpcodeType = "0x7c000730");
            //PPCOpcodes.Add("sraq",       OpcodeType = "0x7c000731");
            PPCOpcodes.Add("sraw",       OpcodeType = "0x7c000630");
            //PPCOpcodes.Add("sraw",       OpcodeType = "0x7c000631");
            PPCOpcodes.Add("srawi",      OpcodeType = "0x7c000670");
            //PPCOpcodes.Add("srawi",      OpcodeType = "0x7c000671");
            PPCOpcodes.Add("srd",        OpcodeType = "0x7c000436");
            //PPCOpcodes.Add("srd",        OpcodeType = "0x7c000437");
            PPCOpcodes.Add("sre",        OpcodeType = "0x7c000532");
            //PPCOpcodes.Add("sre",        OpcodeType = "0x7c000533");
            //PPCOpcodes.Add("srea",       OpcodeType = "0x7c000732");
            PPCOpcodes.Add("srea",       OpcodeType = "0x7c000733");
            //PPCOpcodes.Add("sreq",       OpcodeType = "0x7c0005b2");
            PPCOpcodes.Add("sreq",       OpcodeType = "0x7c0005b3");
            //PPCOpcodes.Add("sriq",       OpcodeType = "0x7c000570");
            PPCOpcodes.Add("sriq",       OpcodeType = "0x7c000571");
            //PPCOpcodes.Add("srliq",      OpcodeType = "0x7c0005f0");
            PPCOpcodes.Add("srliq",      OpcodeType = "0x7c0005f1");
            //PPCOpcodes.Add("srlq",       OpcodeType = "0x7c0005b0");
            PPCOpcodes.Add("srlq",       OpcodeType = "0x7c0005b1");
            PPCOpcodes.Add("srq",        OpcodeType = "0x7c000530");
            //PPCOpcodes.Add("srq",        OpcodeType = "0x7c000531");
            //PPCOpcodes.Add("srw",        OpcodeType = "0x7c000430");
            PPCOpcodes.Add("srw",        OpcodeType = "0x7c000431");
            PPCOpcodes.Add("stb",        OpcodeType = "0x980000");
            PPCOpcodes.Add("stbu",       OpcodeType = "0x9c0000");
            PPCOpcodes.Add("stbux",      OpcodeType = "0x7c0001ee");
            PPCOpcodes.Add("stbx",       OpcodeType = "0x7c0001ae");
            PPCOpcodes.Add("std",        OpcodeType = "0xf80000");
            PPCOpcodes.Add("stdcx",      OpcodeType = "0x7c0001ad");
            PPCOpcodes.Add("stdu",       OpcodeType = "0xf8000001");
            PPCOpcodes.Add("stdux",      OpcodeType = "0x7c00016a");
            PPCOpcodes.Add("stdx",       OpcodeType = "0x7c00012a");
            PPCOpcodes.Add("stfd",       OpcodeType = "0xd80000");
            PPCOpcodes.Add("stfdu",      OpcodeType = "0xdc0000");
            PPCOpcodes.Add("stfdux",     OpcodeType = "0x7c0005ee");
            PPCOpcodes.Add("stfdx",      OpcodeType = "0x7c0005ae");
            PPCOpcodes.Add("stfiwx",     OpcodeType = "0x7c0007ae");
            PPCOpcodes.Add("stfs",       OpcodeType = "0xd00000");
            PPCOpcodes.Add("stfsu",      OpcodeType = "0xd40000");
            PPCOpcodes.Add("stfsux",     OpcodeType = "0x7c00056e");
            PPCOpcodes.Add("stfsx",      OpcodeType = "0x7c00052e");
            PPCOpcodes.Add("sth",        OpcodeType = "0xb00000");
            PPCOpcodes.Add("sthbrx",     OpcodeType = "0x7c00072c");
            PPCOpcodes.Add("sthu",       OpcodeType = "0xb40000");
            PPCOpcodes.Add("sthux",      OpcodeType = "0x7c00036e");
            PPCOpcodes.Add("sthx",       OpcodeType = "0x7c00032e");
            PPCOpcodes.Add("stmw",       OpcodeType = "0xbc0000");
            PPCOpcodes.Add("stswi",      OpcodeType = "0x7c0005aa");
            PPCOpcodes.Add("stswx",      OpcodeType = "0x7c00052a");
            PPCOpcodes.Add("stvebx",     OpcodeType = "0x7c00010e");
            PPCOpcodes.Add("stvehx",     OpcodeType = "0x7c00014e");
            PPCOpcodes.Add("stvewx",     OpcodeType = "0x7c00018e");
            PPCOpcodes.Add("stvx",       OpcodeType = "0x7c0001ce");
            PPCOpcodes.Add("stvxl",      OpcodeType = "0x7c0003ce");
            PPCOpcodes.Add("stw",        OpcodeType = "0x900000");
            PPCOpcodes.Add("stwbrx",     OpcodeType = "0x7c00052c");
            PPCOpcodes.Add("stwcx",      OpcodeType = "0x7c00012d");
            PPCOpcodes.Add("stwu",       OpcodeType = "0x940000");
            PPCOpcodes.Add("stwux",      OpcodeType = "0x7c00016e");
            PPCOpcodes.Add("stwx",       OpcodeType = "0x7c00012e");
            PPCOpcodes.Add("sub",        OpcodeType = "0x7c000050");
            //PPCOpcodes.Add("sub",        OpcodeType = "0x7c000051");
            PPCOpcodes.Add("subc",       OpcodeType = "0x7c000010");
            //PPCOpcodes.Add("subc",       OpcodeType = "0x7c000011");
            //PPCOpcodes.Add("subco",      OpcodeType = "0x7c000410");
            PPCOpcodes.Add("subco",      OpcodeType = "0x7c000411");
            //PPCOpcodes.Add("subf",       OpcodeType = "0x7c000050");
            PPCOpcodes.Add("subf",       OpcodeType = "0x7c000051");
            //PPCOpcodes.Add("subfc",      OpcodeType = "0x7c000010");
            PPCOpcodes.Add("subfc",      OpcodeType = "0x7c000011");
            PPCOpcodes.Add("subfco",     OpcodeType = "0x7c000410");
            //PPCOpcodes.Add("subfco",     OpcodeType = "0x7c000411");
            //PPCOpcodes.Add("subfe",      OpcodeType = "0x7c000110");
            PPCOpcodes.Add("subfe",      OpcodeType = "0x7c000111");
            //PPCOpcodes.Add("subfeo",     OpcodeType = "0x7c000510");
            PPCOpcodes.Add("subfeo",     OpcodeType = "0x7c000511");
            PPCOpcodes.Add("subfic",     OpcodeType = "0x200000");
            //PPCOpcodes.Add("subfme",     OpcodeType = "0x7c0001d0");
            PPCOpcodes.Add("subfme",     OpcodeType = "0x7c0001d1");
            //PPCOpcodes.Add("subfmeo",    OpcodeType = "0x7c0005d0");
            PPCOpcodes.Add("subfmeo",    OpcodeType = "0x7c0005d1");
            PPCOpcodes.Add("subfo",      OpcodeType = "0x7c000450");
            //PPCOpcodes.Add("subfo",      OpcodeType = "0x7c000451");
            //PPCOpcodes.Add("subfze",     OpcodeType = "0x7c000190");
            PPCOpcodes.Add("subfze",     OpcodeType = "0x7c000191");
            PPCOpcodes.Add("subfzeo",    OpcodeType = "0x7c000590");
            //PPCOpcodes.Add("subfzeo",    OpcodeType = "0x7c000591");
            //PPCOpcodes.Add("subo",       OpcodeType = "0x7c000450");
            PPCOpcodes.Add("subo",       OpcodeType = "0x7c000451");
            PPCOpcodes.Add("sync",       OpcodeType = "0x7c0004ac");
            PPCOpcodes.Add("td",         OpcodeType = "0x7c000088");
            PPCOpcodes.Add("tdeq",       OpcodeType = "0x7c800088");
            PPCOpcodes.Add("tdeqi",      OpcodeType = "0x088000");
            PPCOpcodes.Add("tdge",       OpcodeType = "0x7d800088");
            PPCOpcodes.Add("tdgei",      OpcodeType = "0x098000");
            PPCOpcodes.Add("tdgt",       OpcodeType = "0x7d000088");
            PPCOpcodes.Add("tdgti",      OpcodeType = "0x090000");
            PPCOpcodes.Add("tdi",        OpcodeType = "0x080000");
            PPCOpcodes.Add("tdle",       OpcodeType = "0x7e800088");
            PPCOpcodes.Add("tdlei",      OpcodeType = "0x0a8000");
            PPCOpcodes.Add("tdlge",      OpcodeType = "0x7ca00088");
            PPCOpcodes.Add("tdlgei",     OpcodeType = "0x08a000");
            PPCOpcodes.Add("tdlgt",      OpcodeType = "0x7c200088");
            PPCOpcodes.Add("tdlgti",     OpcodeType = "0x082000");
            PPCOpcodes.Add("tdlle",      OpcodeType = "0x7cc00088");
            PPCOpcodes.Add("tdllei",     OpcodeType = "0x08c000");
            PPCOpcodes.Add("tdllt",      OpcodeType = "0x7c400088");
            PPCOpcodes.Add("tdllti",     OpcodeType = "0x084000");
            PPCOpcodes.Add("tdlng",      OpcodeType = "0x7cc00088");
            PPCOpcodes.Add("tdlngi",     OpcodeType = "0x08c000");
            PPCOpcodes.Add("tdlnl",      OpcodeType = "0x7ca00088");
            PPCOpcodes.Add("tdlnli",     OpcodeType = "0x08a000");
            PPCOpcodes.Add("tdlt",       OpcodeType = "0x7e000088");
            PPCOpcodes.Add("tdlti",      OpcodeType = "0x0a0000");
            PPCOpcodes.Add("tdne",       OpcodeType = "0x7f000088");
            PPCOpcodes.Add("tdnei",      OpcodeType = "0x0b0000");
            PPCOpcodes.Add("tdng",       OpcodeType = "0x7e800088");
            PPCOpcodes.Add("tdngi",      OpcodeType = "0x0a8000");
            PPCOpcodes.Add("tdnl",       OpcodeType = "0x7d800088");
            PPCOpcodes.Add("tdnli",      OpcodeType = "0x098000");
            PPCOpcodes.Add("tlbia",      OpcodeType = "0x7c0002e4");
            PPCOpcodes.Add("tlbie",      OpcodeType = "0x7c000264");
            PPCOpcodes.Add("tlbiel",     OpcodeType = "0x7c000224");
            PPCOpcodes.Add("tlbld",      OpcodeType = "0x7c0007a4");
            PPCOpcodes.Add("tlbli",      OpcodeType = "0x7c0007e4");
            PPCOpcodes.Add("tlbsync",    OpcodeType = "0x7c00046c");
            PPCOpcodes.Add("trap",       OpcodeType = "0x7fe00008");
            PPCOpcodes.Add("tw",         OpcodeType = "0x7c000008");
            PPCOpcodes.Add("tweq",       OpcodeType = "0x7c800008");
            PPCOpcodes.Add("tweqi",      OpcodeType = "0x0c8000");
            PPCOpcodes.Add("twge",       OpcodeType = "0x7d800008");
            PPCOpcodes.Add("twgei",      OpcodeType = "0x0d8000");
            PPCOpcodes.Add("twgt",       OpcodeType = "0x7d000008");
            PPCOpcodes.Add("twgti",      OpcodeType = "0x0d0000");
            PPCOpcodes.Add("twi",        OpcodeType = "0x0c0000");
            PPCOpcodes.Add("twle",       OpcodeType = "0x7e800008");
            PPCOpcodes.Add("twlei",      OpcodeType = "0x0e8000");
            PPCOpcodes.Add("twlge",      OpcodeType = "0x7ca00008");
            PPCOpcodes.Add("twlgei",     OpcodeType = "0x0ca000");
            PPCOpcodes.Add("twlgt",      OpcodeType = "0x7c200008");
            PPCOpcodes.Add("twlgti",     OpcodeType = "0x0c2000");
            PPCOpcodes.Add("twlle",      OpcodeType = "0x7cc00008");
            PPCOpcodes.Add("twllei",     OpcodeType = "0x0cc000");
            PPCOpcodes.Add("twllt",      OpcodeType = "0x7c400008");
            PPCOpcodes.Add("twllti",     OpcodeType = "0x0c4000");
            PPCOpcodes.Add("twlng",      OpcodeType = "0x7cc00008");
            PPCOpcodes.Add("twlngi",     OpcodeType = "0x0cc000");
            PPCOpcodes.Add("twlnl",      OpcodeType = "0x7ca00008");
            PPCOpcodes.Add("twlnli",     OpcodeType = "0x0ca000");
            PPCOpcodes.Add("twlt",       OpcodeType = "0x7e000008");
            PPCOpcodes.Add("twlti",      OpcodeType = "0x0e0000");
            PPCOpcodes.Add("twne",       OpcodeType = "0x7f000008");
            PPCOpcodes.Add("twnei",      OpcodeType = "0x0f0000");
            PPCOpcodes.Add("twng",       OpcodeType = "0x7e800008");
            PPCOpcodes.Add("twngi",      OpcodeType = "0x0e8000");
            PPCOpcodes.Add("twnl",       OpcodeType = "0x7d800008");
            PPCOpcodes.Add("twnli",      OpcodeType = "0x0d8000");
            PPCOpcodes.Add("vaddcuw",    OpcodeType = "0x10000180");
            PPCOpcodes.Add("vaddfp",     OpcodeType = "0x1000000a");
            PPCOpcodes.Add("vaddsbs",    OpcodeType = "0x100003");
            PPCOpcodes.Add("vaddshs",    OpcodeType = "0x10000340");
            PPCOpcodes.Add("vaddsws",    OpcodeType = "0x10000380");
            PPCOpcodes.Add("vaddubm",    OpcodeType = "0x100000");
            PPCOpcodes.Add("vaddubs",    OpcodeType = "0x100002");
            PPCOpcodes.Add("vadduhm",    OpcodeType = "0x10000040");
            PPCOpcodes.Add("vadduhs",    OpcodeType = "0x10000240");
            PPCOpcodes.Add("vadduwm",    OpcodeType = "0x10000080");
            PPCOpcodes.Add("vadduws",    OpcodeType = "0x10000280");
            PPCOpcodes.Add("vand",       OpcodeType = "0x10000404");
            PPCOpcodes.Add("vandc",      OpcodeType = "0x10000444");
            PPCOpcodes.Add("vavgsb",     OpcodeType = "0x10000502");
            PPCOpcodes.Add("vavgsh",     OpcodeType = "0x10000542");
            PPCOpcodes.Add("vavgsw",     OpcodeType = "0x10000582");
            PPCOpcodes.Add("vavgub",     OpcodeType = "0x10000402");
            PPCOpcodes.Add("vavguh",     OpcodeType = "0x10000442");
            PPCOpcodes.Add("vavguw",     OpcodeType = "0x10000482");
            PPCOpcodes.Add("vcfsx",      OpcodeType = "0x1000034a");
            PPCOpcodes.Add("vcfux",      OpcodeType = "0x1000030a");
            PPCOpcodes.Add("vcmpbfp",    OpcodeType = "0x100003c6");
            //PPCOpcodes.Add("vcmpbfp",    OpcodeType = "0x100007c6");
            PPCOpcodes.Add("vcmpeqfp",   OpcodeType = "0x100000c6");
            //PPCOpcodes.Add("vcmpeqfp",   OpcodeType = "0x100004c6");
            PPCOpcodes.Add("vcmpequb",   OpcodeType = "0x10000006");
            //PPCOpcodes.Add("vcmpequb",   OpcodeType = "0x10000406");
            //PPCOpcodes.Add("vcmpequh",   OpcodeType = "0x10000046");
            PPCOpcodes.Add("vcmpequh",   OpcodeType = "0x10000446");
            //PPCOpcodes.Add("vcmpequw",   OpcodeType = "0x10000086");
            PPCOpcodes.Add("vcmpequw",   OpcodeType = "0x10000486");
            PPCOpcodes.Add("vcmpgefp",   OpcodeType = "0x100001c6");
            //PPCOpcodes.Add("vcmpgefp",   OpcodeType = "0x100005c6");
            PPCOpcodes.Add("vcmpgtfp",   OpcodeType = "0x100002c6");
            //PPCOpcodes.Add("vcmpgtfp",   OpcodeType = "0x100006c6");
            //PPCOpcodes.Add("vcmpgtsb",   OpcodeType = "0x10000306");
            PPCOpcodes.Add("vcmpgtsb",   OpcodeType = "0x10000706");
            //PPCOpcodes.Add("vcmpgtsh",   OpcodeType = "0x10000346");
            PPCOpcodes.Add("vcmpgtsh",   OpcodeType = "0x10000746");
            PPCOpcodes.Add("vcmpgtsw",   OpcodeType = "0x10000386");
            //PPCOpcodes.Add("vcmpgtsw",   OpcodeType = "0x10000786");
            PPCOpcodes.Add("vcmpgtub",   OpcodeType = "0x10000206");
            //PPCOpcodes.Add("vcmpgtub",   OpcodeType = "0x10000606");
            //PPCOpcodes.Add("vcmpgtuh",   OpcodeType = "0x10000246");
            PPCOpcodes.Add("vcmpgtuh",   OpcodeType = "0x10000646");
            //PPCOpcodes.Add("vcmpgtuw",   OpcodeType = "0x10000286");
            PPCOpcodes.Add("vcmpgtuw",   OpcodeType = "0x10000686");
            //PPCOpcodes.Add("vctsxs",     OpcodeType = "0x100003ca");
            PPCOpcodes.Add("vctuxs",     OpcodeType = "0x1000038a");
            PPCOpcodes.Add("vexptefp",   OpcodeType = "0x1000018a");
            PPCOpcodes.Add("vlogefp",    OpcodeType = "0x100001ca");
            PPCOpcodes.Add("vmaddfp",    OpcodeType = "0x1000002e");
            PPCOpcodes.Add("vmaxfp",     OpcodeType = "0x1000040a");
            PPCOpcodes.Add("vmaxsb",     OpcodeType = "0x10000102");
            PPCOpcodes.Add("vmaxsh",     OpcodeType = "0x10000142");
            PPCOpcodes.Add("vmaxsw",     OpcodeType = "0x10000182");
            PPCOpcodes.Add("vmaxub",     OpcodeType = "0x10000002");
            PPCOpcodes.Add("vmaxuh",     OpcodeType = "0x10000042");
            PPCOpcodes.Add("vmaxuw",     OpcodeType = "0x10000082");
            PPCOpcodes.Add("vmhaddshs",  OpcodeType = "0x10000020");
            PPCOpcodes.Add("vmhraddshs", OpcodeType = "0x10000021");
            PPCOpcodes.Add("vminfp",     OpcodeType = "0x1000044a");
            PPCOpcodes.Add("vminsb",     OpcodeType = "0x10000302");
            PPCOpcodes.Add("vminsh",     OpcodeType = "0x10000342");
            PPCOpcodes.Add("vminsw",     OpcodeType = "0x10000382");
            PPCOpcodes.Add("vminub",     OpcodeType = "0x10000202");
            PPCOpcodes.Add("vminuh",     OpcodeType = "0x10000242");
            PPCOpcodes.Add("vminuw",     OpcodeType = "0x10000282");
            PPCOpcodes.Add("vmladduhm",  OpcodeType = "0x10000022");
            PPCOpcodes.Add("vmrghb",     OpcodeType = "0x1000000c");
            PPCOpcodes.Add("vmrghh",     OpcodeType = "0x1000004c");
            PPCOpcodes.Add("vmrghw",     OpcodeType = "0x1000008c");
            PPCOpcodes.Add("vmrglb",     OpcodeType = "0x1000010c");
            PPCOpcodes.Add("vmrglh",     OpcodeType = "0x1000014c");
            PPCOpcodes.Add("vmrglw",     OpcodeType = "0x1000018c");
            PPCOpcodes.Add("vmsummbm",   OpcodeType = "0x10000025");
            PPCOpcodes.Add("vmsumshm",   OpcodeType = "0x10000028");
            PPCOpcodes.Add("vmsumshs",   OpcodeType = "0x10000029");
            PPCOpcodes.Add("vmsumubm",   OpcodeType = "0x10000024");
            PPCOpcodes.Add("vmsumuhm",   OpcodeType = "0x10000026");
            PPCOpcodes.Add("vmsumuhs",   OpcodeType = "0x10000027");
            PPCOpcodes.Add("vmulesb",    OpcodeType = "0x10000308");
            PPCOpcodes.Add("vmulesh",    OpcodeType = "0x10000348");
            PPCOpcodes.Add("vmuleub",    OpcodeType = "0x10000208");
            PPCOpcodes.Add("vmuleuh",    OpcodeType = "0x10000248");
            PPCOpcodes.Add("vmulosb",    OpcodeType = "0x10000108");
            PPCOpcodes.Add("vmulosh",    OpcodeType = "0x10000148");
            PPCOpcodes.Add("vmuloub",    OpcodeType = "0x10000008");
            PPCOpcodes.Add("vmulouh",    OpcodeType = "0x10000048");
            PPCOpcodes.Add("vnmsubfp",   OpcodeType = "0x1000002f");
            PPCOpcodes.Add("vnor",       OpcodeType = "0x10000504");
            PPCOpcodes.Add("vor",        OpcodeType = "0x10000484");
            PPCOpcodes.Add("vperm",      OpcodeType = "0x1000002b");
            PPCOpcodes.Add("vpkpx",      OpcodeType = "0x1000030e");
            PPCOpcodes.Add("vpkshss",    OpcodeType = "0x1000018e");
            PPCOpcodes.Add("vpkshus",    OpcodeType = "0x1000010e");
            PPCOpcodes.Add("vpkswss",    OpcodeType = "0x100001ce");
            PPCOpcodes.Add("vpkswus",    OpcodeType = "0x1000014e");
            PPCOpcodes.Add("vpkuhum",    OpcodeType = "0x1000000e");
            PPCOpcodes.Add("vpkuhus",    OpcodeType = "0x1000008e");
            PPCOpcodes.Add("vpkuwum",    OpcodeType = "0x1000004e");
            PPCOpcodes.Add("vpkuwus",    OpcodeType = "0x100000ce");
            PPCOpcodes.Add("vrefp",      OpcodeType = "0x1000010a");
            PPCOpcodes.Add("vrfim",      OpcodeType = "0x100002ca");
            PPCOpcodes.Add("vrfin",      OpcodeType = "0x1000020a");
            PPCOpcodes.Add("vrfip",      OpcodeType = "0x1000028a");
            PPCOpcodes.Add("vrfiz",      OpcodeType = "0x1000024a");
            PPCOpcodes.Add("vrlb",       OpcodeType = "0x10000004");
            PPCOpcodes.Add("vrlh",       OpcodeType = "0x10000044");
            PPCOpcodes.Add("vrlw",       OpcodeType = "0x10000084");
            PPCOpcodes.Add("vrsqrtefp",  OpcodeType = "0x1000014a");
            PPCOpcodes.Add("vsel",       OpcodeType = "0x1000002a");
            PPCOpcodes.Add("vsl",        OpcodeType = "0x100001c4");
            PPCOpcodes.Add("vslb",       OpcodeType = "0x10000104");
            PPCOpcodes.Add("vsldoi",     OpcodeType = "0x1000002c");
            PPCOpcodes.Add("vslh",       OpcodeType = "0x10000144");
            PPCOpcodes.Add("vslo",       OpcodeType = "0x1000040c");
            PPCOpcodes.Add("vslw",       OpcodeType = "0x10000184");
            PPCOpcodes.Add("vspltb",     OpcodeType = "0x1000020c");
            PPCOpcodes.Add("vsplth",     OpcodeType = "0x1000024c");
            PPCOpcodes.Add("vspltisb",   OpcodeType = "0x1000030c");
            PPCOpcodes.Add("vspltish",   OpcodeType = "0x1000034c");
            PPCOpcodes.Add("vspltisw",   OpcodeType = "0x1000038c");
            PPCOpcodes.Add("vspltw",     OpcodeType = "0x1000028c");
            PPCOpcodes.Add("vsr",        OpcodeType = "0x100002c4");
            PPCOpcodes.Add("vsrab",      OpcodeType = "0x10000304");
            PPCOpcodes.Add("vsrah",      OpcodeType = "0x10000344");
            PPCOpcodes.Add("vsraw",      OpcodeType = "0x10000384");
            PPCOpcodes.Add("vsrb",       OpcodeType = "0x10000204");
            PPCOpcodes.Add("vsrh",       OpcodeType = "0x10000244");
            PPCOpcodes.Add("vsro",       OpcodeType = "0x1000044c");
            PPCOpcodes.Add("vsrw",       OpcodeType = "0x10000284");
            PPCOpcodes.Add("vsubcuw",    OpcodeType = "0x10000580");
            PPCOpcodes.Add("vsubfp",     OpcodeType = "0x1000004a");
            PPCOpcodes.Add("vsubsbs",    OpcodeType = "0x100007");
            PPCOpcodes.Add("vsubshs",    OpcodeType = "0x10000740");
            PPCOpcodes.Add("vsubsws",    OpcodeType = "0x10000780");
            PPCOpcodes.Add("vsububm",    OpcodeType = "0x100004");
            PPCOpcodes.Add("vsububs",    OpcodeType = "0x100006");
            PPCOpcodes.Add("vsubuhm",    OpcodeType = "0x10000440");
            PPCOpcodes.Add("vsubuhs",    OpcodeType = "0x10000640");
            PPCOpcodes.Add("vsubuwm",    OpcodeType = "0x10000480");
            PPCOpcodes.Add("vsubuws",    OpcodeType = "0x10000680");
            PPCOpcodes.Add("vsum2sws",   OpcodeType = "0x10000688");
            PPCOpcodes.Add("vsum4sbs",   OpcodeType = "0x10000708");
            PPCOpcodes.Add("vsum4shs",   OpcodeType = "0x10000648");
            PPCOpcodes.Add("vsum4ubs",   OpcodeType = "0x10000608");
            PPCOpcodes.Add("vsumsws",    OpcodeType = "0x10000788");
            PPCOpcodes.Add("vupkhpx",    OpcodeType = "0x1000034e");
            PPCOpcodes.Add("vupkhsb",    OpcodeType = "0x1000020e");
            PPCOpcodes.Add("vupkhsh",    OpcodeType = "0x1000024e");
            PPCOpcodes.Add("vupklpx",    OpcodeType = "0x100003ce");
            PPCOpcodes.Add("vupklsb",    OpcodeType = "0x1000028e");
            PPCOpcodes.Add("vupklsh",    OpcodeType = "0x100002ce");
            PPCOpcodes.Add("vxor",       OpcodeType = "0x100004c4");
            PPCOpcodes.Add("xor",        OpcodeType = "0x7c000278");
            //PPCOpcodes.Add("xor",        OpcodeType = "0x7c000279");
            PPCOpcodes.Add("xori",       OpcodeType = "0x680000");
            PPCOpcodes.Add("xoris",      OpcodeType = "0x6c0000");
        }
        #endregion

        #region Header Info Input
        private void XEXInfo_Click(object sender, EventArgs e)
        {
            if (Output.Text == string.Empty)
            {
                Output.AppendText("title_name = \"" + TitleName.Text + "\"");
                Output.AppendText(Environment.NewLine);
                Output.AppendText("title_id = \"" + TitleId.Text + "\"");
                Output.AppendText(Environment.NewLine);
                Output.AppendText("hash = \"" + HashKey.Text + "\"");
                Output.AppendText(Environment.NewLine);
                OutputConditions = false;
                WXI.Enabled = false;
            }
            else
            {
                MessageBox.Show("Output must be empty!");
            }
        }
        public static bool SelectedOpcodeCheck(string Opcode)
        {
            if (PPCOpcodes.ContainsKey(Opcode) && PPCOpcodes.TryGetValue(Opcode, out OpcodeType))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AddPokeHeader_Click(object sender, EventArgs e)
        {
            // Todo: Check for Double or Single Float
            bool writepatchvalue = false;
            switch (PatchValue.Text.Length)
            {
                case 2: // be8
                    if (ProvideSizeType.Text == "be8")
                    {
                        writepatchvalue = true;
                    }
                    break;
                case 4: // be16
                    if (ProvideSizeType.Text == "be16")
                    {
                        writepatchvalue = true;
                    }
                    break;
                case 8: // be32
                    if (ProvideSizeType.Text == "be32")
                    {
                        writepatchvalue = true;
                    }
                    break;
                case 16: // be64
                    if (ProvideSizeType.Text == "be64")
                    {
                        writepatchvalue = true;
                    }
                    break;
                default:
                    writepatchvalue = false;
                    break;
            }

            // Safe guard for users to make sure format is correct at all times
            if (Output.Text.Contains("[[patch]]") && writepatchvalue == true)
            {
                OutputConditions = true;
                Output.AppendText("    [[patch." + ProvideSizeType.Text + "]]");
                Output.AppendText(Environment.NewLine);
                Output.AppendText("        address = " + "0x" + PatchAddress.Text.ToUpper());
                Output.AppendText(Environment.NewLine);
                Output.AppendText("        value = " + "0x" + PatchValue.Text.ToUpper());
                Output.AppendText(Environment.NewLine);

                if (Properties.Settings.Default.AutoDelete == true)
                {
                    PatchAddress.Text = string.Empty;
                    if (UseType.Checked != true)
                    {
                        PatchValue.Text = string.Empty;
                    }
                }
                OutputConditions = false;
            }
            else
            {
                if (writepatchvalue == false)
                {
                    MessageBox.Show("Incorrect patch length.");
                }
                else if (!Output.Text.Contains("[[patch]]"))
                {
                    MessageBox.Show("Patch header must be made first; Please write patch Info.");
                }
            }
        }

        private void AddPatchHeader_Click(object sender, EventArgs e)
        {
            OutputConditions = true;
            // Safe guard for users to make sure format is correct at all times
            if (Output.Text.Contains("hash = \""))
            {
                // Condition checks make sure user writes something
                if (!IsNullOrEmpty(PatchName.Text) && !IsNullOrEmpty(Authors.Text))
                {
                    Output.AppendText(Environment.NewLine + "[[patch]]");
                    // Writes the line with user's input
                    Output.AppendText(Environment.NewLine + "    name = \"" + PatchName.Text + "\"");
                    if (Properties.Settings.Default.UseDefaultAuthors == true)
                    {
                        Output.AppendText(Environment.NewLine + "    author = \"" + Properties.Settings.Default.DefaultAuthors + "\"");
                    }
                    else
                    {
                        Output.AppendText(Environment.NewLine + "    author = \"" + Authors.Text + "\"");
                    }
                    Output.AppendText(Environment.NewLine + "    is_enabled = " + IsOn.IsOn.ToString().ToLower() + Environment.NewLine + Environment.NewLine);
                    // Condition checks make sure the current user has the proper settings applied.
                    if (Properties.Settings.Default.DisableMessageBox == false)
                    {
                        DialogResult dialogResult = MessageBox.Show("Would you like to delete the current patch input?", "Warning", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            PatchName.Text = string.Empty;
                            Authors.Text = string.Empty;
                            IsOn.IsOn = false;
                        }
                    }
                    OutputConditions = false;
                }
                else
                {
                    MessageBox.Show("Must enter info!");
                }
            }
            else
            {
                MessageBox.Show("Main header must be made first; Please write XEX info.");
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
            // We have to make sure we separate both buttons into their own thread
            switch((sender as SimpleButton).Text)
            {
                case "-":
                    if (PatchAddress.Text != string.Empty)
                    {
                        // When minus is clicked the address is grabbed and stored
                        // The address then uses hex math to subtract 4 bytes
                        int decValue = int.Parse(PatchAddress.Text, System.Globalization.NumberStyles.HexNumber) - Properties.Settings.Default.AddressMath;
                        PatchAddress.Text = decValue.ToString("X");
                    }
                    break;
                    case "+":
                    if (PatchAddress.Text != string.Empty)
                    {
                        // When adding is clicked the address is grabbed and stored
                        // The address than uses hex math to add 4 bytes
                        int IncreaseValue = int.Parse(PatchAddress.Text, System.Globalization.NumberStyles.HexNumber) + Properties.Settings.Default.AddressMath;
                        PatchAddress.Text = IncreaseValue.ToString("X");
                    }
                    break;
            }
        }

        private void Types_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UseType.Checked == true)
            {
                if (SelectedOpcodeCheck(Types.SelectedItem.ToString()))
                {
                    PatchValue.Text = OpcodeType.ToUpper().Substring(2);
                    PatchValue.Enabled = false;
                }
                else
                {
                    PatchValue.Text = "";
                    PatchValue.Enabled = true;
                }
            }
            else
            {
                PatchValue.Text = "";
                PatchValue.Enabled = true;
            }
        }
        #endregion

        #region Functions

        private void OpenForm_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch(e.Item.Caption)
            {
                case "Settings":
                    if (Program.Settings == null)
                    {
                        Program.Settings = new Settings();
                        Program.Settings.AboutTab.PageVisible = false;
                        Program.Settings.FormClosed += CloseForm_Click; // Add event Handler to cleanup after form closes
                    }
                    Hide();
                    Program.Settings.ShowDialog(this); // Show Form assigning this form as the forms owner
                    break;
                case "About":
                    if (Program.Settings == null)
                    {
                        Program.Settings = new Settings();
                        Program.Settings.AboutTab.Show();
                        Program.Settings.GeneralTab.PageVisible = false;
                        Program.Settings.Text = "About Us";
                        Program.Settings.FormClosed += CloseForm_Click; // Add event handler to cleanup after form closes
                    }
                    Hide();
                    Program.Settings.ShowDialog(this); // Show Form assigning this form as the forms owner
                    break;
            }
        }
        /// <summary>
        /// Find all types.
        /// </summary>
        public void GetAllTypes(string data)
        {
            // Improving what we have
            TitleId.Text = GetTitleID(data, "Title ID:", "Savegame ID:", 0);
            HashKey.Text = GetHashKey(data, "Module hash: ", " for default", 0);
            // Deserialize the DB XML file
            var titleDB = TitleDB.XmlDeserialize(File.ReadAllText(Path.Combine(Application.StartupPath, "DB.xml"), Encoding.UTF8));

            // Locate the TitleEntry by the given TitleID and pull out the Title.
            // If a TitleEntry is not found, the null propagation operator will fall on the "string.Empty" side of the ??s preventing a crash.
            TitleName.Text = titleDB.Titles.FirstOrDefault(t => t.ID.ToLower() == TitleId.Text.ToLower())?.Title ?? string.Empty;
            Data = string.Empty; // Make sure string is empty
            CurrentFullName = string.Empty; // Make sure string is empty
            CurrentFullPath = string.Empty; // Make sure string is empty
            return;
        }
        /// <summary>
        /// Used for various forms where data needs to be transferred.
        /// </summary>
        /// <param name="Input"></param>
        public void Data_Between(string Input)
        {
            // Check if user has checkbox checked...
            if (!UseType.Checked)
            {
                PatchValue.Text = Input;
            }
        }

        /// <summary>
        /// Holds data and sends it to the correct locations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropBox_DragDrop(object sender, DragEventArgs e)
        {
            // Condition Check: verify if user has dropped a log file in.
            if (Path.GetFileName(CurrentFullName).Contains(".log"))
            {
                Data = File.ReadAllText(string.Join("", CurrentFullPath));
                GetAllTypes(Data.Substring(0, Data.IndexOf("Savegame ID:") + "Savegame ID:".Length));
                if (Properties.Settings.Default.WriteInfo == true)
                {
                    if (HashKey.Text.Length > 10)
                    {
                    EmptyString:
                        if (IsNullOrEmpty(Output.Text))
                        {
                            OutputConditions = true;
                            Output.AppendText("title_name = \"" + TitleName.Text + "\"");
                            Output.AppendText(Environment.NewLine);
                            Output.AppendText("title_id = \"" + TitleId.Text + "\"");
                            Output.AppendText(Environment.NewLine);
                            Output.AppendText("hash = \"" + HashKey.Text + "\"");
                            Output.AppendText(Environment.NewLine);
                            return;
                        }
                        else
                        {
                            Output.Text = string.Empty;
                            goto EmptyString;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Must be a log file.");
                    }
                }
            }
            else if (Path.GetFileName(CurrentFullName).Contains(".patch.toml"))
            {
                if(Output.Text == string.Empty && TitleName.Text == string.Empty && TitleId.Text == string.Empty && HashKey.Text == string.Empty)
                {
                    LoadPatchData(string.Join("", CurrentFullPath));
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("This will delete any unsaved data.\r\nWould you like to continue?", "Load Patch File.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LoadPatchData(string.Join("", CurrentFullPath));
                    }
                }
                return;
            }
        }

        private void LoadPatchData(string Path)
        {
            foreach (string lines in File.ReadAllLines(Path))
            {
                if (lines.StartsWith("title_name = "))
                {
                    TitleName.Text = lines.Substring("title_name = ".Length).Replace("\"", string.Empty);
                }
                else if (lines.StartsWith("title_id = "))
                {
                    TitleId.Text = lines.Substring("title_id = ".Length).Replace("\"", string.Empty);
                }
                else if (lines.StartsWith("hash = "))
                {
                    HashKey.Text = lines.Substring("hash = ".Length).Replace("\"", string.Empty);
                }
            }
            Output.Text = File.ReadAllText(Path);
        }

        private void DropBox_DragEnter(object sender, DragEventArgs e)
        {
            // See if this is a copy and the data includes text.
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // File being dropped
                string[] CurrentFile = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                // Sets FullPath Path
                CurrentFullPath = Path.GetFullPath(CurrentFile[0]);
                // Sets FullName Path
                CurrentFullName = Path.GetFileName(CurrentFile[0]);
                if (Path.GetFileName(CurrentFile[0]).Contains(".patch.toml"))
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

        private void SavePatchFile_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Output.TextLength > 30)
            {
                using (SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "Xenia patch file(*.patch.toml;) |*.patch.toml;| All files(*.*) | *.*",
                    Title = "Save patch file...",
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
                            m_WriterParameter.Write(Output.Text);
                            m_WriterParameter.Flush();
                            m_WriterParameter.Close();
                            fParameter.Close();
                            MessageBox.Show("File was created - " + Environment.NewLine + dialog.FileName);
                        }
                    }
            }
            else
            {
                MessageBox.Show("Must have something to be saved.");
            }
        }

        private void LoadPatchFile_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Xenia patch file(*.patch.toml;) |*.patch.toml;| All files(*.*) | *.*",
                Title = "Save patch file...",
                DereferenceLinks = true,
                CheckPathExists = true,
                CheckFileExists = true
            })
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    OutputConditions = true;
                    LoadPatchData(dialog.FileName);
                    OutputConditions = false;
                }
        }
        public void CloseForm_Click(object sender, FormClosedEventArgs e)
        {
            switch(sender.GetType().FullName.Substring("XeniaPatchMaker.".Length))
            {
                case "ValueConverter":
                    valueConverter = null;
                    break;
                case "XPM":
                    Program.Load = null;
                    break;
                case "Settings":
                    Properties.Settings.Default.Save();
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
                    break;
                default:
                    return;
            }
        }
        #endregion

        #region Output RichTextBox
        /// <summary>
        /// We use DevExpress Control to make sure our colors change accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richEditControl1_ForeColorChanged(object sender, EventArgs e)
        {
            Output.ForeColor = richEditControl1.Appearance.Text.ForeColor;
            Output.BackColor = richEditControl1.Views.SimpleView.BackColor;
        }
        /// <summary>
        /// Make sure user is finished.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Output_KeyUp(object sender, KeyEventArgs e)
        {
            OutputConditions = true;
        }
        /// <summary>
        /// Make sure user is done typing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Output_KeyDown(object sender, KeyEventArgs e)
        {
            OutputConditions = false;
        }
        private void Output_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if string isn't empty.
                if (Output.Text.Equals(string.Empty))
                {
                    barButtonItem11.Enabled = false;
                    barButtonItem10.Enabled = false;
                    barButtonItem9.Enabled = false;
                    WXI.Enabled = true;
                }
                else
                {
                    WXI.Enabled = true;
                    barButtonItem11.Enabled = true;
                    barButtonItem10.Enabled = true;
                    barButtonItem9.Enabled = true;

                    if (Properties.Settings.Default.ColorDisabled == false)
                    {
                        if (OutputConditions == true)
                        {
                            foreach (string text in Output.Lines)
                            {
                                switch (text)
                                {
                                    case "true":
                                        CheckKeyword("is_enabled = false".Substring(2), Color.Green, 0);
                                        break;
                                    case "false":
                                        CheckKeyword("is_enabled = false".Substring(2), Color.Green, 0);
                                        break;
                                    case " is_enabled = ":
                                        CheckKeyword(" is_enabled = ", Color.FromArgb(126, 59, 188), 0);
                                        break;
                                    case "[[patch]]":
                                        CheckKeyword("[[patch]]", Color.FromArgb(74, 139, 197), 0);
                                        break;
                                    case "hash =":
                                        CheckKeyword("hash =", Color.Coral, 0);
                                        break;
                                    case "[[patch." + "be32" + "]]":
                                        CheckKeyword("[[patch." + "be32" + "]]", Properties.Settings.Default.PatchAddressColor1, 0);
                                        break;
                                    case "\"":
                                        CheckKeyword("\"", Color.Red, 0);
                                        break;
                                    case "title_name =":
                                        CheckKeyword("title_name =", Properties.Settings.Default.PatchAddressColor2, 0);
                                        break;
                                    case "title_id =":
                                        CheckKeyword("title_id =", Properties.Settings.Default.PatchAddressColor3, 0);
                                        break;
                                    case "address = ":
                                        CheckKeyword("address = ", Color.FromArgb(214, 136, 82), 0);
                                        break;
                                    case "value = ":
                                        CheckKeyword("value = ", Color.FromArgb(214, 136, 82), 0);
                                        break;
                                    case " name = ":
                                        CheckKeyword(" name = ", Color.FromArgb(214, 136, 82), 0);
                                        break;
                                    case " author = ":
                                        CheckKeyword(" author = ", Color.FromArgb(214, 136, 82), 0);
                                        break;
                                }
                            }
                            // Check user inputs then change color
                            if (TitleName.Text != string.Empty)
                            {
                                CheckKeyword(TitleName.Text, Color.Green, 0);
                            }
                            else if (TitleId.Text != string.Empty)
                            {
                                CheckKeyword(TitleId.Text, Color.Green, 0);
                            }
                            else if (HashKey.Text != string.Empty)
                            {
                                CheckKeyword(HashKey.Text, Color.Green, 0);
                            }
                            else if (IsOn.Text != string.Empty)
                            {
                                CheckKeyword(IsOn.Text, Color.Green, 0);
                            }

                            else if (Authors.Text != string.Empty)
                            {
                                CheckKeyword(Authors.Text, Color.Green, 0);
                            }

                            else if (PatchName.Text != string.Empty)
                            {
                                CheckKeyword(PatchName.Text, Color.Green, 0);
                            }

                            else if (PatchAddress.Text != string.Empty)
                            {
                                CheckKeyword(PatchAddress.Text, Color.Green, 0);
                            }

                            else if (PatchValue.Text != string.Empty)
                            {
                                CheckKeyword(PatchValue.Text, Color.Green, 0);
                            }
                            else if (ProvideSizeType.Text != string.Empty)
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
            }
            catch
            {
            }
        }
        #endregion
        private void XPM_Shown(object sender, EventArgs e)
        {
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

        private void Output_DragDrop(object sender, DragEventArgs e)
        {
            if (CurrentFullName.EndsWith(".patch.toml"))
            {
                LoadPatchData(CurrentFullPath);
            }
        }
        private void ValueConverter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (valueConverter == null)
            {
                valueConverter = new ValueConverter();
                valueConverter.FormClosed += CloseForm_Click; // Add event Handler to cleanup after form closes
            }
            valueConverter.ShowDialog(this); // Show Form assigning this form as the forms owner
        }

        private void Output_KeyPress(object sender, KeyPressEventArgs e) => OutputConditions = false;

        private void Output_Leave(object sender, EventArgs e) => OutputConditions = true;

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Finder == null)
            {
                Finder = new Find();
                Finder.FormClosed += CloseForm_Click; // Add event Handler to cleanup after form closes
            }
            Finder.ShowDialog(this); // Show Form assigning this form as the forms owner
        }

        private void ClearDataTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch(e.Item.Caption)
            {
                case "Clear All Data":
                    if (Output.Text != string.Empty)
                    {
                        DialogResult dialogResult = MessageBox.Show("This will clear any unsaved data.\r\nWould you like to continue?", "Clear Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Output.Text = string.Empty;
                            TitleId.Text = string.Empty;
                            TitleName.Text = string.Empty;
                            HashKey.Text = string.Empty;
                            PatchName.Text = string.Empty;
                            Authors.Text = string.Empty;
                            IsOn.IsOn = false;
                            ProvideSizeType.Text = "be32";
                            PatchAddress.Text = string.Empty;
                            PatchValue.Text = string.Empty;
                            Types.Text = "ABS";
                            UseType.Checked = false;
                        }
                    }
                    break;
                case "Clear Main Header":
                    TitleId.Text = string.Empty;
                    TitleName.Text = string.Empty;
                    HashKey.Text = string.Empty;
                    break;
                case "Clear Patch Info":
                    PatchName.Text = string.Empty;
                    Authors.Text = string.Empty;
                    IsOn.IsOn = false;
                    break;
                case "Clear Patch Address":
                    ProvideSizeType.Text = "be32";
                    PatchAddress.Text = string.Empty;
                    PatchValue.Text = string.Empty;
                    Types.Text = "ABS";
                    UseType.Checked = false;
                    break;
                case "Clear Output":
                    Output.Text = string.Empty;
                    break;
            }
        }
    }
}
