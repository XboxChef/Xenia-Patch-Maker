
using System;
using System.Windows.Forms;

namespace XeniaPatchMaker
{
    partial class XPM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager LoadingSplashScreen = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::XeniaPatchMaker.Loading_Screen), true, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XPM));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.WXI = new DevExpress.XtraEditors.SimpleButton();
            this.GameInfoHeader = new DevExpress.XtraEditors.GroupControl();
            this.HashKey = new DevExpress.XtraEditors.TextEdit();
            this.TitleId = new DevExpress.XtraEditors.TextEdit();
            this.TitleName = new DevExpress.XtraEditors.TextEdit();
            this.PatchInfoGroup = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.IsOn = new DevExpress.XtraEditors.ToggleSwitch();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Authors = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.PatchName = new DevExpress.XtraEditors.TextEdit();
            this.PatchAddressGroup = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.Types = new DevExpress.XtraEditors.ComboBoxEdit();
            this.UseType = new DevExpress.XtraEditors.CheckEdit();
            this.PlusButton = new DevExpress.XtraEditors.SimpleButton();
            this.MinusButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProvideSizeType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ProvideSizeLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.PatchValue = new DevExpress.XtraEditors.TextEdit();
            this.PatchAddress = new DevExpress.XtraEditors.TextEdit();
            this.BottomManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.skinDropDownButtonItem2 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.Version = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.DropLog = new DevExpress.XtraEditors.GroupControl();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.TopManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.SaveButton = new DevExpress.XtraBars.BarButtonItem();
            this.LoadButton = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.ClearAllData = new DevExpress.XtraBars.BarButtonItem();
            this.ClearMainHeader = new DevExpress.XtraBars.BarButtonItem();
            this.ClearPatchInfo = new DevExpress.XtraBars.BarButtonItem();
            this.ClearPatchAddress = new DevExpress.XtraBars.BarButtonItem();
            this.ClearOutput = new DevExpress.XtraBars.BarButtonItem();
            this.SearchSubItem = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.ViewSubItem = new DevExpress.XtraBars.BarSubItem();
            this.ValueConverter = new DevExpress.XtraBars.BarButtonItem();
            this.SettingsButton = new DevExpress.XtraBars.BarSubItem();
            this.HelpButton = new DevExpress.XtraBars.BarSubItem();
            this.AboutButton = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.GameInfoHeader)).BeginInit();
            this.GameInfoHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HashKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchInfoGroup)).BeginInit();
            this.PatchInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsOn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Authors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchAddressGroup)).BeginInit();
            this.PatchAddressGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Types.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UseType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvideSizeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopManager)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingSplashScreen
            // 
            LoadingSplashScreen.ClosingDelay = 880;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(44, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hash";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // WXI
            // 
            this.WXI.AllowFocus = false;
            this.WXI.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.WXI.Appearance.Options.UseForeColor = true;
            this.WXI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WXI.Location = new System.Drawing.Point(2, 126);
            this.WXI.Name = "WXI";
            this.WXI.Size = new System.Drawing.Size(192, 23);
            this.WXI.TabIndex = 20;
            this.WXI.Text = "Write Xex Info";
            this.WXI.Click += new System.EventHandler(this.XEXInfo_Click);
            // 
            // GameInfoHeader
            // 
            this.GameInfoHeader.Appearance.Options.UseForeColor = true;
            this.GameInfoHeader.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.GameInfoHeader.AppearanceCaption.Options.UseForeColor = true;
            this.GameInfoHeader.Controls.Add(this.label1);
            this.GameInfoHeader.Controls.Add(this.HashKey);
            this.GameInfoHeader.Controls.Add(this.TitleId);
            this.GameInfoHeader.Controls.Add(this.TitleName);
            this.GameInfoHeader.Controls.Add(this.WXI);
            this.GameInfoHeader.Controls.Add(this.label3);
            this.GameInfoHeader.Controls.Add(this.label2);
            this.GameInfoHeader.Location = new System.Drawing.Point(11, 101);
            this.GameInfoHeader.Name = "GameInfoHeader";
            this.GameInfoHeader.Size = new System.Drawing.Size(196, 151);
            this.GameInfoHeader.TabIndex = 21;
            this.GameInfoHeader.Text = "Main Header";
            // 
            // HashKey
            // 
            this.HashKey.Location = new System.Drawing.Point(79, 90);
            this.HashKey.Name = "HashKey";
            this.HashKey.Size = new System.Drawing.Size(100, 20);
            this.HashKey.TabIndex = 23;
            // 
            // TitleId
            // 
            this.TitleId.Location = new System.Drawing.Point(79, 64);
            this.TitleId.Name = "TitleId";
            this.TitleId.Size = new System.Drawing.Size(100, 20);
            this.TitleId.TabIndex = 22;
            // 
            // TitleName
            // 
            this.TitleName.Location = new System.Drawing.Point(79, 40);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(100, 20);
            this.TitleName.TabIndex = 21;
            // 
            // PatchInfoGroup
            // 
            this.PatchInfoGroup.Appearance.Options.UseForeColor = true;
            this.PatchInfoGroup.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.PatchInfoGroup.AppearanceCaption.Options.UseForeColor = true;
            this.PatchInfoGroup.Controls.Add(this.simpleButton2);
            this.PatchInfoGroup.Controls.Add(this.IsOn);
            this.PatchInfoGroup.Controls.Add(this.label11);
            this.PatchInfoGroup.Controls.Add(this.label12);
            this.PatchInfoGroup.Controls.Add(this.Authors);
            this.PatchInfoGroup.Controls.Add(this.label15);
            this.PatchInfoGroup.Controls.Add(this.PatchName);
            this.PatchInfoGroup.Location = new System.Drawing.Point(213, 101);
            this.PatchInfoGroup.Name = "PatchInfoGroup";
            this.PatchInfoGroup.Size = new System.Drawing.Size(196, 151);
            this.PatchInfoGroup.TabIndex = 22;
            this.PatchInfoGroup.Text = "Patch Info";
            // 
            // simpleButton2
            // 
            this.simpleButton2.AllowFocus = false;
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton2.Location = new System.Drawing.Point(2, 126);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(192, 23);
            this.simpleButton2.TabIndex = 25;
            this.simpleButton2.Text = "Add [[patch]] Header";
            this.simpleButton2.Click += new System.EventHandler(this.AddPatchHeader_Click);
            // 
            // IsOn
            // 
            this.IsOn.Location = new System.Drawing.Point(79, 89);
            this.IsOn.Name = "IsOn";
            this.IsOn.Properties.AllowFocused = false;
            this.IsOn.Properties.OffText = "False";
            this.IsOn.Properties.OnText = "True";
            this.IsOn.Size = new System.Drawing.Size(100, 24);
            this.IsOn.TabIndex = 29;
            this.IsOn.Toggled += new System.EventHandler(this.IsOn_Toggled);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label11.Location = new System.Drawing.Point(17, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Is Enabled";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label12.Location = new System.Drawing.Point(29, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Authors";
            // 
            // Authors
            // 
            this.Authors.Location = new System.Drawing.Point(79, 63);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(100, 20);
            this.Authors.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label15.Location = new System.Drawing.Point(10, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Patch Name";
            // 
            // PatchName
            // 
            this.PatchName.Location = new System.Drawing.Point(79, 37);
            this.PatchName.Name = "PatchName";
            this.PatchName.Size = new System.Drawing.Size(100, 20);
            this.PatchName.TabIndex = 25;
            // 
            // PatchAddressGroup
            // 
            this.PatchAddressGroup.Appearance.Options.UseForeColor = true;
            this.PatchAddressGroup.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.PatchAddressGroup.AppearanceCaption.Options.UseForeColor = true;
            this.PatchAddressGroup.Controls.Add(this.label5);
            this.PatchAddressGroup.Controls.Add(this.Types);
            this.PatchAddressGroup.Controls.Add(this.UseType);
            this.PatchAddressGroup.Controls.Add(this.PlusButton);
            this.PatchAddressGroup.Controls.Add(this.MinusButton);
            this.PatchAddressGroup.Controls.Add(this.ProvideSizeType);
            this.PatchAddressGroup.Controls.Add(this.ProvideSizeLabel);
            this.PatchAddressGroup.Controls.Add(this.ValueLabel);
            this.PatchAddressGroup.Controls.Add(this.AddressLabel);
            this.PatchAddressGroup.Controls.Add(this.simpleButton3);
            this.PatchAddressGroup.Controls.Add(this.PatchValue);
            this.PatchAddressGroup.Controls.Add(this.PatchAddress);
            this.PatchAddressGroup.Location = new System.Drawing.Point(415, 101);
            this.PatchAddressGroup.Name = "PatchAddressGroup";
            this.PatchAddressGroup.Size = new System.Drawing.Size(389, 151);
            this.PatchAddressGroup.TabIndex = 22;
            this.PatchAddressGroup.Text = "Patch Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "PPC Opcode";
            // 
            // Types
            // 
            this.Types.EditValue = "ABS";
            this.Types.Location = new System.Drawing.Point(89, 103);
            this.Types.Name = "Types";
            this.Types.Properties.AllowFocused = false;
            this.Types.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Types.Properties.Items.AddRange(new object[] {
            "abs",
            "abso",
            "add",
            "addc",
            "addco",
            "adde",
            "addeo",
            "addi",
            "addic",
            "addis",
            "addme",
            "addmeo",
            "addo",
            "addze",
            "addzeo",
            "and",
            "andc",
            "andi",
            "andis",
            "attn",
            "b",
            "ba",
            "bc",
            "bca",
            "bcctr",
            "bcctrl",
            "bcl",
            "bcla",
            "bclr",
            "bclrl",
            "bctr",
            "bctrl",
            "bdnz",
            "bdnza",
            "bdnzf",
            "bdnzfa",
            "bdnzfl",
            "bdnzfla",
            "bdnzflr",
            "bdnzflrl",
            "bdnzl",
            "bdnzla",
            "bdnzlr",
            "bdnzlrl",
            "bdnzt",
            "bdnzta",
            "bdnztl",
            "bdnztla",
            "bdnztlr",
            "bdnztlrl",
            "bdz",
            "bdza",
            "bdzf",
            "bdzfa",
            "bdzfl",
            "bdzfla",
            "bdzflr",
            "bdzflrl",
            "bdzl",
            "bdzla",
            "bdzlr",
            "bdzlrl",
            "bdzt",
            "bdzta",
            "bdztl",
            "bdztla",
            "bdztlr",
            "bdztlrl",
            "beq",
            "beqa",
            "beqctr",
            "beqctrl",
            "beql",
            "beqla",
            "beqlr",
            "beqlrl",
            "bf",
            "bfa",
            "bfctr",
            "bfctrl",
            "bfl",
            "bfla",
            "bflr",
            "bflrl",
            "bge",
            "bgea",
            "bgectr",
            "bgectrl",
            "bgel",
            "bgela",
            "bgelr",
            "bgelrl",
            "bgt",
            "bgta",
            "bgtctr",
            "bgtctrl",
            "bgtl",
            "bgtla",
            "bgtlr",
            "bgtlrl",
            "bl",
            "bla",
            "ble",
            "blea",
            "blectr",
            "blectrl",
            "blel",
            "blela",
            "blelr",
            "blelrl",
            "blr",
            "blrl",
            "blt",
            "blta",
            "bltctr",
            "bltctrl",
            "bltl",
            "bltla",
            "bltlr",
            "bltlrl",
            "bne",
            "bnea",
            "bnectr",
            "bnectrl",
            "bnel",
            "bnela",
            "bnelr",
            "bnelrl",
            "bng",
            "bnga",
            "bngctr",
            "bngctrl",
            "bngl",
            "bngla",
            "bnglr",
            "bnglrl",
            "bnl",
            "bnla",
            "bnlctr",
            "bnlctrl",
            "bnll",
            "bnlla",
            "bnllr",
            "bnllrl",
            "bns",
            "bnsa",
            "bnsctr",
            "bnsctrl",
            "bnsl",
            "bnsla",
            "bnslr",
            "bnslrl",
            "bnu",
            "bnua",
            "bnuctr",
            "bnuctrl",
            "bnul",
            "bnula",
            "bnulr",
            "bnulrl",
            "bso",
            "bsoa",
            "bsoctr",
            "bsoctrl",
            "bsol",
            "bsola",
            "bsolr",
            "bsolrl",
            "bt",
            "bta",
            "btctr",
            "btctrl",
            "btl",
            "btla",
            "btlr",
            "btlrl",
            "bun",
            "buna",
            "bunctr",
            "bunctrl",
            "bunl",
            "bunla",
            "bunlr",
            "bunlrl",
            "clcs",
            "cmp",
            "cmpd",
            "cmpdi",
            "cmpi",
            "cmpl",
            "cmpld",
            "cmpldi",
            "cmpli",
            "cmplw",
            "cmplwi",
            "cmpw",
            "cmpwi",
            "cntlzd",
            "cntlzw",
            "crand",
            "crandc",
            "creqv",
            "crnand",
            "crnor",
            "cror",
            "crorc",
            "crxor",
            "dcba",
            "dcbf",
            "dcbi",
            "dcbst",
            "dcbt",
            "dcbt128",
            "dcbtst",
            "dcbz",
            "dcbz128",
            "dcbzl",
            "div",
            "divd",
            "divdo",
            "divdu",
            "divduo",
            "divo",
            "divs",
            "divso",
            "divw",
            "divwo",
            "divwu",
            "divwuo",
            "doz",
            "dozi",
            "dozo",
            "dss",
            "dssall",
            "dst",
            "dstst",
            "dststt",
            "dstt",
            "eciwx",
            "ecowx",
            "eieio",
            "eqv",
            "extsb",
            "extsh",
            "extsw",
            "fabs",
            "fadd",
            "fadds",
            "fcfid",
            "fcmpo",
            "fcmpu",
            "fctid",
            "fctidz",
            "fctiw",
            "fctiwz",
            "fdiv",
            "fdivs",
            "fmadd",
            "fmadds",
            "fmr",
            "fmsub",
            "fmsubs",
            "fmul",
            "fmuls",
            "fnabs",
            "fneg",
            "fnmadd",
            "fnmadds",
            "fnmsub",
            "fnmsubs",
            "fres",
            "frsp",
            "frsqrte",
            "fsel",
            "fsqrt",
            "fsqrts",
            "fsub",
            "fsubs",
            "icbi",
            "isync",
            "jbsr",
            "jmp",
            "la",
            "lbz",
            "lbzu",
            "lbzux",
            "lbzx",
            "ld",
            "ldarx",
            "ldu",
            "ldux",
            "ldx",
            "lfd",
            "lfdu",
            "lfdux",
            "lfdx",
            "lfs",
            "lfsu",
            "lfsux",
            "lfsx",
            "lha",
            "lhau",
            "lhaux",
            "lhax",
            "lhbrx",
            "lhz",
            "lhzu",
            "lhzux",
            "lhzx",
            "li",
            "lis",
            "lmw",
            "lscbx",
            "lswi",
            "lswx",
            "lvebx",
            "lvehx",
            "lvewx",
            "lvsl",
            "lvsr",
            "lvx",
            "lvxl",
            "lwa",
            "lwarx",
            "lwaux",
            "lwax",
            "lwbrx",
            "lwsync",
            "lwz",
            "lwzu",
            "lwzux",
            "lwzx",
            "maskg",
            "maskir",
            "mcrf",
            "mcrfs",
            "mcrxr",
            "mfcr",
            "mfctr",
            "mffs",
            "mflr",
            "mfmq",
            "mfmsr",
            "mfocrf",
            "mfrtcl",
            "mfrtcu",
            "mfspr",
            "mfsr",
            "mfsrin",
            "mftb",
            "mftbu",
            "mfvscr",
            "mfxer",
            "mtcrf",
            "mtctr",
            "mtfsb0",
            "mtfsb1",
            "mtfsf",
            "mtfsfi",
            "mtlr",
            "mtmq",
            "mtmsr",
            "mtmsrd",
            "mtocrf",
            "mtrtcl",
            "mtrtcu",
            "mtspr",
            "mtsr",
            "mtsrin",
            "mttbl",
            "mttbu",
            "mtvscr",
            "mtxer",
            "mul",
            "mulhd",
            "mulhdu",
            "mulhw",
            "mulhwu",
            "mull",
            "mulld",
            "mulldo",
            "mulli",
            "mullo",
            "mullw",
            "mullwo",
            "mulo",
            "mulwd",
            "nabs",
            "nabso",
            "nand",
            "neg",
            "nego",
            "nop",
            "nor",
            "or",
            "orc",
            "ori",
            "oris",
            "ptesync",
            "rfi",
            "rfid",
            "rldcl",
            "rldcr",
            "rldic",
            "rldicl",
            "rldicr",
            "rldimi",
            "rlmi",
            "rlwimi",
            "rlwinm",
            "rlwnm",
            "rrib",
            "sc",
            "slbia",
            "slbie",
            "slbmfee",
            "slbmfev",
            "slbmte",
            "sld",
            "sle",
            "sleq",
            "sliq",
            "slliq",
            "sllq",
            "slq",
            "slw",
            "srad",
            "sradi",
            "sraiq",
            "sraq",
            "sraw",
            "srawi",
            "srd",
            "sre",
            "srea",
            "sreq",
            "sriq",
            "srliq",
            "srlq",
            "srq",
            "srw",
            "stb",
            "stbu",
            "stbux",
            "stbx",
            "std",
            "stdcx",
            "stdu",
            "stdux",
            "stdx",
            "stfd",
            "stfdu",
            "stfdux",
            "stfdx",
            "stfiwx",
            "stfs",
            "stfsu",
            "stfsux",
            "stfsx",
            "sth",
            "sthbrx",
            "sthu",
            "sthux",
            "sthx",
            "stmw",
            "stswi",
            "stswx",
            "stvebx",
            "stvehx",
            "stvewx",
            "stvx",
            "stvxl",
            "stw",
            "stwbrx",
            "stwcx",
            "stwu",
            "stwux",
            "stwx",
            "sub",
            "subc",
            "subco",
            "subf",
            "subfc",
            "subfco",
            "subfe",
            "subfeo",
            "subfic",
            "subfme",
            "subfmeo",
            "subfo",
            "subfze",
            "subfzeo",
            "subo",
            "sync",
            "td",
            "tdeq",
            "tdeqi",
            "tdge",
            "tdgei",
            "tdgt",
            "tdgti",
            "tdi",
            "tdle",
            "tdlei",
            "tdlge",
            "tdlgei",
            "tdlgt",
            "tdlgti",
            "tdlle",
            "tdllei",
            "tdllt",
            "tdllti",
            "tdlng",
            "tdlngi",
            "tdlnl",
            "tdlnli",
            "tdlt",
            "tdlti",
            "tdne",
            "tdnei",
            "tdng",
            "tdngi",
            "tdnl",
            "tdnli",
            "tlbia",
            "tlbie",
            "tlbiel",
            "tlbld",
            "tlbli",
            "tlbsync",
            "trap",
            "tw",
            "tweq",
            "tweqi",
            "twge",
            "twgei",
            "twgt",
            "twgti",
            "twi",
            "twle",
            "twlei",
            "twlge",
            "twlgei",
            "twlgt",
            "twlgti",
            "twlle",
            "twllei",
            "twllt",
            "twllti",
            "twlng",
            "twlngi",
            "twlnl",
            "twlnli",
            "twlt",
            "twlti",
            "twne",
            "twnei",
            "twng",
            "twngi",
            "twnl",
            "twnli",
            "vaddcuw",
            "vaddfp",
            "vaddsbs",
            "vaddshs",
            "vaddsws",
            "vaddubm",
            "vaddubs",
            "vadduhm",
            "vadduhs",
            "vadduwm",
            "vadduws",
            "vand",
            "vandc",
            "vavgsb",
            "vavgsh",
            "vavgsw",
            "vavgub",
            "vavguh",
            "vavguw",
            "vcfsx",
            "vcfux",
            "vcmpbfp",
            "vcmpeqfp",
            "vcmpequb",
            "vcmpequh",
            "vcmpequw",
            "vcmpgefp",
            "vcmpgtfp",
            "vcmpgtsb",
            "vcmpgtsh",
            "vcmpgtsw",
            "vcmpgtub",
            "vcmpgtuh",
            "vcmpgtuw",
            "vctsxs",
            "vctuxs",
            "vexptefp",
            "vlogefp",
            "vmaddfp",
            "vmaxfp",
            "vmaxsb",
            "vmaxsh",
            "vmaxsw",
            "vmaxub",
            "vmaxuh",
            "vmaxuw",
            "vmhaddshs",
            "vmhraddshs",
            "vminfp",
            "vminsb",
            "vminsh",
            "vminsw",
            "vminub",
            "vminuh",
            "vminuw",
            "vmladduhm",
            "vmrghb",
            "vmrghh",
            "vmrghw",
            "vmrglb",
            "vmrglh",
            "vmrglw",
            "vmsummbm",
            "vmsumshm",
            "vmsumshs",
            "vmsumubm",
            "vmsumuhm",
            "vmsumuhs",
            "vmulesb",
            "vmulesh",
            "vmuleub",
            "vmuleuh",
            "vmulosb",
            "vmulosh",
            "vmuloub",
            "vmulouh",
            "vnmsubfp",
            "vnor",
            "vor",
            "vperm",
            "vpkpx",
            "vpkshss",
            "vpkshus",
            "vpkswss",
            "vpkswus",
            "vpkuhum",
            "vpkuhus",
            "vpkuwum",
            "vpkuwus",
            "vrefp",
            "vrfim",
            "vrfin",
            "vrfip",
            "vrfiz",
            "vrlb",
            "vrlh",
            "vrlw",
            "vrsqrtefp",
            "vsel",
            "vsl",
            "vslb",
            "vsldoi",
            "vslh",
            "vslo",
            "vslw",
            "vspltb",
            "vsplth",
            "vspltisb",
            "vspltish",
            "vspltisw",
            "vspltw",
            "vsr",
            "vsrab",
            "vsrah",
            "vsraw",
            "vsrb",
            "vsrh",
            "vsro",
            "vsrw",
            "vsubcuw",
            "vsubfp",
            "vsubsbs",
            "vsubshs",
            "vsubsws",
            "vsububm",
            "vsububs",
            "vsubuhm",
            "vsubuhs",
            "vsubuwm",
            "vsubuws",
            "vsum2sws",
            "vsum4sbs",
            "vsum4shs",
            "vsum4ubs",
            "vsumsws",
            "vupkhpx",
            "vupkhsb",
            "vupkhsh",
            "vupklpx",
            "vupklsb",
            "vupklsh",
            "vxor",
            "xor",
            "xori",
            "xoris"});
            this.Types.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Types.Size = new System.Drawing.Size(126, 20);
            this.Types.TabIndex = 41;
            this.Types.SelectedIndexChanged += new System.EventHandler(this.Types_SelectedIndexChanged);
            // 
            // UseType
            // 
            this.UseType.Location = new System.Drawing.Point(217, 104);
            this.UseType.Name = "UseType";
            this.UseType.Properties.AllowFocused = false;
            this.UseType.Properties.Caption = "Use Types";
            this.UseType.Size = new System.Drawing.Size(77, 19);
            this.UseType.TabIndex = 37;
            this.UseType.CheckedChanged += new System.EventHandler(this.Types_SelectedIndexChanged);
            // 
            // PlusButton
            // 
            this.PlusButton.AllowFocus = false;
            this.PlusButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.PlusButton.Appearance.Options.UseForeColor = true;
            this.PlusButton.Location = new System.Drawing.Point(235, 56);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(16, 14);
            this.PlusButton.TabIndex = 40;
            this.PlusButton.Text = "+";
            this.PlusButton.Click += new System.EventHandler(this.AddressMath_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.AllowFocus = false;
            this.MinusButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.MinusButton.Appearance.Options.UseForeColor = true;
            this.MinusButton.Location = new System.Drawing.Point(217, 56);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(16, 14);
            this.MinusButton.TabIndex = 39;
            this.MinusButton.Text = "-";
            this.MinusButton.Click += new System.EventHandler(this.AddressMath_Click);
            // 
            // ProvideSizeType
            // 
            this.ProvideSizeType.EditValue = "be32";
            this.ProvideSizeType.Location = new System.Drawing.Point(89, 27);
            this.ProvideSizeType.Name = "ProvideSizeType";
            this.ProvideSizeType.Properties.AllowFocused = false;
            this.ProvideSizeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProvideSizeType.Properties.Items.AddRange(new object[] {
            "f64",
            "f32",
            "be64",
            "be32",
            "be16",
            "be8"});
            this.ProvideSizeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ProvideSizeType.Size = new System.Drawing.Size(54, 20);
            this.ProvideSizeType.TabIndex = 24;
            // 
            // ProvideSizeLabel
            // 
            this.ProvideSizeLabel.AutoSize = true;
            this.ProvideSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProvideSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.ProvideSizeLabel.Location = new System.Drawing.Point(12, 30);
            this.ProvideSizeLabel.Name = "ProvideSizeLabel";
            this.ProvideSizeLabel.Size = new System.Drawing.Size(71, 13);
            this.ProvideSizeLabel.TabIndex = 36;
            this.ProvideSizeLabel.Text = "Provided Size";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.ValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.ValueLabel.Location = new System.Drawing.Point(50, 82);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(33, 13);
            this.ValueLabel.TabIndex = 35;
            this.ValueLabel.Text = "Value";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.AddressLabel.Location = new System.Drawing.Point(37, 56);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(46, 13);
            this.AddressLabel.TabIndex = 34;
            this.AddressLabel.Text = "Address";
            // 
            // simpleButton3
            // 
            this.simpleButton3.AllowFocus = false;
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton3.Location = new System.Drawing.Point(2, 126);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(385, 23);
            this.simpleButton3.TabIndex = 30;
            this.simpleButton3.Text = "Add [[patch.be]] Header";
            this.simpleButton3.Click += new System.EventHandler(this.AddPokeHeader_Click);
            // 
            // PatchValue
            // 
            this.PatchValue.Location = new System.Drawing.Point(89, 79);
            this.PatchValue.Name = "PatchValue";
            this.PatchValue.Size = new System.Drawing.Size(126, 20);
            this.PatchValue.TabIndex = 31;
            // 
            // PatchAddress
            // 
            this.PatchAddress.Location = new System.Drawing.Point(89, 53);
            this.PatchAddress.Name = "PatchAddress";
            this.PatchAddress.Size = new System.Drawing.Size(126, 20);
            this.PatchAddress.TabIndex = 30;
            // 
            // BottomManager
            // 
            this.BottomManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.BottomManager.DockControls.Add(this.barDockControlTop);
            this.BottomManager.DockControls.Add(this.barDockControlBottom);
            this.BottomManager.DockControls.Add(this.barDockControlLeft);
            this.BottomManager.DockControls.Add(this.barDockControlRight);
            this.BottomManager.Form = this;
            this.BottomManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Version,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem4,
            this.barButtonItem5,
            this.skinDropDownButtonItem1,
            this.skinDropDownButtonItem2});
            this.BottomManager.MaxItemId = 15;
            this.BottomManager.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.bar3.BarAppearance.Normal.Options.UseForeColor = true;
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinDropDownButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.Version)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // skinDropDownButtonItem2
            // 
            this.skinDropDownButtonItem2.Id = 12;
            this.skinDropDownButtonItem2.Name = "skinDropDownButtonItem2";
            // 
            // Version
            // 
            this.Version.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Version.Caption = "Version: ";
            this.Version.Id = 0;
            this.Version.Name = "Version";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 22);
            this.barDockControlTop.Manager = this.BottomManager;
            this.barDockControlTop.Size = new System.Drawing.Size(816, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 708);
            this.barDockControlBottom.Manager = this.BottomManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(816, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.BottomManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 686);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(816, 22);
            this.barDockControlRight.Manager = this.BottomManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 686);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Load Patch File";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LoadPatchFile_Click);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Save Patch File";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SavePatchFile_Click);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Id = 14;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Clear";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearDataTypes_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 11;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // DropLog
            // 
            this.DropLog.AllowDrop = true;
            this.DropLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DropLog.Appearance.Options.UseForeColor = true;
            this.DropLog.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.DropLog.AppearanceCaption.Options.UseForeColor = true;
            this.DropLog.Location = new System.Drawing.Point(8, 30);
            this.DropLog.Name = "DropLog";
            this.DropLog.Size = new System.Drawing.Size(794, 65);
            this.DropLog.TabIndex = 23;
            this.DropLog.Text = "Drop Xenia Log Here: / Drop Patch File Here:";
            this.DropLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropBox_DragDrop);
            this.DropLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropBox_DragEnter);
            // 
            // Output
            // 
            this.Output.AllowDrop = true;
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(0, 270);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(816, 438);
            this.Output.TabIndex = 26;
            this.Output.Text = "";
            this.Output.DragDrop += new System.Windows.Forms.DragEventHandler(this.Output_DragDrop);
            this.Output.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropBox_DragEnter);
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            this.Output.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Output_KeyDown);
            this.Output.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Output_KeyPress);
            this.Output.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Output_KeyUp);
            this.Output.Leave += new System.EventHandler(this.Output_Leave);
            // 
            // TopManager
            // 
            this.TopManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.TopManager.DockControls.Add(this.barDockControl3);
            this.TopManager.DockControls.Add(this.barDockControl4);
            this.TopManager.DockControls.Add(this.barDockControl1);
            this.TopManager.DockControls.Add(this.barDockControl2);
            this.TopManager.Form = this;
            this.TopManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem2,
            this.barSubItem4,
            this.SettingsButton,
            this.AboutButton,
            this.SaveButton,
            this.LoadButton,
            this.ClearAllData,
            this.ViewSubItem,
            this.ValueConverter,
            this.HelpButton,
            this.SearchSubItem,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barSubItem7,
            this.ClearMainHeader,
            this.ClearPatchInfo,
            this.ClearPatchAddress,
            this.ClearOutput});
            this.TopManager.MainMenu = this.bar2;
            this.TopManager.MaxItemId = 21;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.SearchSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.ViewSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.SettingsButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.HelpButton)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "File";
            this.barSubItem2.Id = 0;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.SaveButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.LoadButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem7)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // SaveButton
            // 
            this.SaveButton.Caption = "Save";
            this.SaveButton.Id = 4;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SavePatchFile_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Caption = "Load";
            this.LoadButton.Id = 5;
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LoadPatchFile_Click);
            // 
            // barSubItem7
            // 
            this.barSubItem7.Caption = "Recent Files..";
            this.barSubItem7.Id = 15;
            this.barSubItem7.Name = "barSubItem7";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Edit";
            this.barSubItem4.Id = 1;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ClearAllData),
            new DevExpress.XtraBars.LinkPersistInfo(this.ClearMainHeader),
            new DevExpress.XtraBars.LinkPersistInfo(this.ClearPatchInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.ClearPatchAddress),
            new DevExpress.XtraBars.LinkPersistInfo(this.ClearOutput)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // ClearAllData
            // 
            this.ClearAllData.Caption = "Clear All Data";
            this.ClearAllData.Id = 6;
            this.ClearAllData.Name = "ClearAllData";
            this.ClearAllData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearDataTypes_ItemClick);
            // 
            // ClearMainHeader
            // 
            this.ClearMainHeader.Caption = "Clear Main Header";
            this.ClearMainHeader.Id = 17;
            this.ClearMainHeader.Name = "ClearMainHeader";
            this.ClearMainHeader.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearDataTypes_ItemClick);
            // 
            // ClearPatchInfo
            // 
            this.ClearPatchInfo.Caption = "Clear Patch Info";
            this.ClearPatchInfo.Id = 18;
            this.ClearPatchInfo.Name = "ClearPatchInfo";
            this.ClearPatchInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearDataTypes_ItemClick);
            // 
            // ClearPatchAddress
            // 
            this.ClearPatchAddress.Caption = "Clear Patch Address";
            this.ClearPatchAddress.Id = 19;
            this.ClearPatchAddress.Name = "ClearPatchAddress";
            this.ClearPatchAddress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearDataTypes_ItemClick);
            // 
            // ClearOutput
            // 
            this.ClearOutput.Caption = "Clear Output";
            this.ClearOutput.Id = 20;
            this.ClearOutput.Name = "ClearOutput";
            this.ClearOutput.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearDataTypes_ItemClick);
            // 
            // SearchSubItem
            // 
            this.SearchSubItem.Caption = "Search";
            this.SearchSubItem.Id = 10;
            this.SearchSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11)});
            this.SearchSubItem.Name = "SearchSubItem";
            this.SearchSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Find";
            this.barButtonItem9.Enabled = false;
            this.barButtonItem9.Id = 12;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Replace...";
            this.barButtonItem10.Enabled = false;
            this.barButtonItem10.Id = 13;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Find Again...";
            this.barButtonItem11.Enabled = false;
            this.barButtonItem11.Id = 14;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // ViewSubItem
            // 
            this.ViewSubItem.Caption = "View";
            this.ViewSubItem.Id = 7;
            this.ViewSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ValueConverter)});
            this.ViewSubItem.Name = "ViewSubItem";
            // 
            // ValueConverter
            // 
            this.ValueConverter.Caption = "Value Converter";
            this.ValueConverter.Id = 8;
            this.ValueConverter.Name = "ValueConverter";
            this.ValueConverter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ValueConverter_ItemClick);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Caption = "Settings";
            this.SettingsButton.Id = 2;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OpenForm_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Caption = "Help";
            this.HelpButton.Id = 9;
            this.HelpButton.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.AboutButton)});
            this.HelpButton.Name = "HelpButton";
            // 
            // AboutButton
            // 
            this.AboutButton.Caption = "About";
            this.AboutButton.Id = 3;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OpenForm_Click);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.TopManager;
            this.barDockControl3.Size = new System.Drawing.Size(816, 22);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl4.Location = new System.Drawing.Point(0, 736);
            this.barDockControl4.Manager = this.TopManager;
            this.barDockControl4.Size = new System.Drawing.Size(816, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl1.Location = new System.Drawing.Point(0, 22);
            this.barDockControl1.Manager = this.TopManager;
            this.barDockControl1.Size = new System.Drawing.Size(0, 714);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl2.Location = new System.Drawing.Point(816, 22);
            this.barDockControl2.Manager = this.TopManager;
            this.barDockControl2.Size = new System.Drawing.Size(0, 714);
            // 
            // richEditControl1
            // 
            this.richEditControl1.Location = new System.Drawing.Point(361, 409);
            this.richEditControl1.MenuManager = this.BottomManager;
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(400, 200);
            this.richEditControl1.TabIndex = 35;
            this.richEditControl1.ForeColorChanged += new System.EventHandler(this.richEditControl1_ForeColorChanged);
            // 
            // XPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 736);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.DropLog);
            this.Controls.Add(this.PatchInfoGroup);
            this.Controls.Add(this.PatchAddressGroup);
            this.Controls.Add(this.GameInfoHeader);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.False;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XPM.IconOptions.Icon")));
            this.IconOptions.Image = global::XeniaPatchMaker.Properties.Resources.Asset_1;
            this.IconOptions.LargeImage = global::XeniaPatchMaker.Properties.Resources.Asset_1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(832, 696);
            this.Name = "XPM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xenia Patch Maker By Serenity";
            this.Load += new System.EventHandler(this.XPM_Load);
            this.Shown += new System.EventHandler(this.XPM_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GameInfoHeader)).EndInit();
            this.GameInfoHeader.ResumeLayout(false);
            this.GameInfoHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HashKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchInfoGroup)).EndInit();
            this.PatchInfoGroup.ResumeLayout(false);
            this.PatchInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsOn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Authors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchAddressGroup)).EndInit();
            this.PatchAddressGroup.ResumeLayout(false);
            this.PatchAddressGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Types.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UseType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvideSizeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton WXI;
        private DevExpress.XtraEditors.GroupControl GameInfoHeader;
        private DevExpress.XtraEditors.TextEdit TitleName;
        private DevExpress.XtraEditors.GroupControl PatchInfoGroup;
        private DevExpress.XtraEditors.GroupControl PatchAddressGroup;
        private DevExpress.XtraEditors.TextEdit HashKey;
        private DevExpress.XtraEditors.TextEdit TitleId;
        private DevExpress.XtraEditors.GroupControl DropLog;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ToggleSwitch IsOn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit Authors;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit PatchName;
        private DevExpress.XtraEditors.ComboBoxEdit ProvideSizeType;
        private System.Windows.Forms.Label ProvideSizeLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label AddressLabel;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit PatchAddress;
        public System.Windows.Forms.RichTextBox Output;
        public DevExpress.XtraEditors.TextEdit PatchValue;
        private DevExpress.XtraEditors.SimpleButton PlusButton;
        private DevExpress.XtraEditors.SimpleButton MinusButton;
        private DevExpress.XtraEditors.CheckEdit UseType;
        private DevExpress.XtraBars.BarManager BottomManager;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem Version;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager TopManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem SaveButton;
        private DevExpress.XtraBars.BarButtonItem LoadButton;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarButtonItem ClearAllData;
        private DevExpress.XtraBars.BarSubItem SettingsButton;
        private DevExpress.XtraBars.BarButtonItem AboutButton;
        private DevExpress.XtraBars.BarSubItem ViewSubItem;
        private DevExpress.XtraBars.BarButtonItem ValueConverter;
        private DevExpress.XtraBars.BarSubItem HelpButton;
        private DevExpress.XtraBars.BarSubItem SearchSubItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarSubItem barSubItem7;
        private DevExpress.XtraEditors.ComboBoxEdit Types;
        private Label label5;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarButtonItem ClearMainHeader;
        private DevExpress.XtraBars.BarButtonItem ClearPatchInfo;
        private DevExpress.XtraBars.BarButtonItem ClearPatchAddress;
        private DevExpress.XtraBars.BarButtonItem ClearOutput;
    }
}
