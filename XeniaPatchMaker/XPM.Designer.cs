
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::XeniaPatchMaker.Loading_Screen), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XPM));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.GameInfoHeader = new DevExpress.XtraEditors.GroupControl();
            this.MediaId = new DevExpress.XtraEditors.TextEdit();
            this.HashKey = new DevExpress.XtraEditors.TextEdit();
            this.TitleId = new DevExpress.XtraEditors.TextEdit();
            this.TitleName = new DevExpress.XtraEditors.TextEdit();
            this.PatchInfoGroup = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.IsOn = new DevExpress.XtraEditors.ToggleSwitch();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Authors = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.Desc = new DevExpress.XtraEditors.TextEdit();
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
            this.OutPut = new System.Windows.Forms.RichTextBox();
            this.TopManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.ValueConverter = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.GameInfoHeader)).BeginInit();
            this.GameInfoHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HashKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchInfoGroup)).BeginInit();
            this.PatchInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsOn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Authors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desc.Properties)).BeginInit();
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
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 900;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(10, 26);
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
            this.label2.Location = new System.Drawing.Point(24, 51);
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
            this.label3.Location = new System.Drawing.Point(36, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Media ID";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton1.Location = new System.Drawing.Point(2, 123);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(192, 23);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Write Xex Info";
            this.simpleButton1.Click += new System.EventHandler(this.XEXInfo_Click);
            // 
            // GameInfoHeader
            // 
            this.GameInfoHeader.Appearance.Options.UseForeColor = true;
            this.GameInfoHeader.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.GameInfoHeader.AppearanceCaption.Options.UseForeColor = true;
            this.GameInfoHeader.Controls.Add(this.label1);
            this.GameInfoHeader.Controls.Add(this.MediaId);
            this.GameInfoHeader.Controls.Add(this.HashKey);
            this.GameInfoHeader.Controls.Add(this.TitleId);
            this.GameInfoHeader.Controls.Add(this.TitleName);
            this.GameInfoHeader.Controls.Add(this.simpleButton1);
            this.GameInfoHeader.Controls.Add(this.label4);
            this.GameInfoHeader.Controls.Add(this.label3);
            this.GameInfoHeader.Controls.Add(this.label2);
            this.GameInfoHeader.Location = new System.Drawing.Point(11, 98);
            this.GameInfoHeader.Name = "GameInfoHeader";
            this.GameInfoHeader.ShowCaption = false;
            this.GameInfoHeader.Size = new System.Drawing.Size(196, 148);
            this.GameInfoHeader.TabIndex = 21;
            this.GameInfoHeader.Text = "Main Header";
            // 
            // MediaId
            // 
            this.MediaId.Location = new System.Drawing.Point(73, 99);
            this.MediaId.Name = "MediaId";
            this.MediaId.Size = new System.Drawing.Size(100, 20);
            this.MediaId.TabIndex = 24;
            // 
            // HashKey
            // 
            this.HashKey.Location = new System.Drawing.Point(73, 73);
            this.HashKey.Name = "HashKey";
            this.HashKey.Size = new System.Drawing.Size(100, 20);
            this.HashKey.TabIndex = 23;
            // 
            // TitleId
            // 
            this.TitleId.Location = new System.Drawing.Point(73, 47);
            this.TitleId.Name = "TitleId";
            this.TitleId.Size = new System.Drawing.Size(100, 20);
            this.TitleId.TabIndex = 22;
            // 
            // TitleName
            // 
            this.TitleName.Location = new System.Drawing.Point(73, 23);
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
            this.PatchInfoGroup.Controls.Add(this.label14);
            this.PatchInfoGroup.Controls.Add(this.Desc);
            this.PatchInfoGroup.Controls.Add(this.label15);
            this.PatchInfoGroup.Controls.Add(this.PatchName);
            this.PatchInfoGroup.Location = new System.Drawing.Point(213, 87);
            this.PatchInfoGroup.Name = "PatchInfoGroup";
            this.PatchInfoGroup.Size = new System.Drawing.Size(196, 158);
            this.PatchInfoGroup.TabIndex = 22;
            this.PatchInfoGroup.Text = "Patch Info";
            // 
            // simpleButton2
            // 
            this.simpleButton2.AllowFocus = false;
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton2.Location = new System.Drawing.Point(2, 133);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(192, 23);
            this.simpleButton2.TabIndex = 25;
            this.simpleButton2.Text = "Add [[patch]] Header";
            this.simpleButton2.Click += new System.EventHandler(this.AddPatchHeader_Click);
            // 
            // IsOn
            // 
            this.IsOn.Location = new System.Drawing.Point(79, 101);
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
            this.label11.Location = new System.Drawing.Point(17, 107);
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
            this.label12.Location = new System.Drawing.Point(31, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Authors";
            // 
            // Authors
            // 
            this.Authors.Location = new System.Drawing.Point(79, 78);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(100, 20);
            this.Authors.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label14.Location = new System.Drawing.Point(42, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Desc";
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(79, 52);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(100, 20);
            this.Desc.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label15.Location = new System.Drawing.Point(39, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Name";
            // 
            // PatchName
            // 
            this.PatchName.Location = new System.Drawing.Point(79, 26);
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
            this.PatchAddressGroup.Location = new System.Drawing.Point(415, 90);
            this.PatchAddressGroup.Name = "PatchAddressGroup";
            this.PatchAddressGroup.Size = new System.Drawing.Size(389, 158);
            this.PatchAddressGroup.TabIndex = 22;
            this.PatchAddressGroup.Text = "Patch Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(10, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "PPC Opcode";
            // 
            // Types
            // 
            this.Types.EditValue = "ABS 0x7C0002D0";
            this.Types.Location = new System.Drawing.Point(82, 103);
            this.Types.Name = "Types";
            this.Types.Properties.AllowFocused = false;
            this.Types.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Types.Properties.Items.AddRange(new object[] {
            "abs 0x7c0002d0",
            "abs 0x7c0002d1",
            "abso 0x7c0006d0",
            "abso 0x7c0006d1",
            "add 0x7c000214",
            "add 0x7c000215",
            "addc 0x7c000014",
            "addc 0x7c000015",
            "addco 0x7c000414",
            "addco 0x7c000415",
            "adde 0x7c000114",
            "adde 0x7c000115",
            "addeo 0x7c000514",
            "addeo 0x7c000515",
            "addi 0x38000000",
            "addic 0x300000",
            "addic 0x340000",
            "addis 0x3c0000",
            "addme 0x7c0001d4",
            "addme 0x7c0001d5",
            "addmeo 0x7c0005d4",
            "addmeo 0x7c0005d5",
            "addo 0x7c000614",
            "addo 0x7c000615",
            "addze 0x7c000194",
            "addze 0x7c000195",
            "addzeo 0x7c000594",
            "addzeo 0x7c000595",
            "and 0x7c000038",
            "and 0x7c000039",
            "andc 0x7c000078",
            "andc 0x7c000079",
            "andi 0x700000",
            "andis 0x740000",
            "attn 0x000002",
            "b 0x428000",
            "b 0x480000",
            "ba 0x42800002",
            "ba 0x48000002",
            "bc 0x400000",
            "bca 0x40000002",
            "bcctr 0x4c000420",
            "bcctrl 0x4c000421",
            "bcl 0x40000001",
            "bcla 0x40000003",
            "bclr 0x4c000020",
            "bclrl 0x4c000021",
            "bctr 0x4c000420",
            "bctr 0x4e800420",
            "bctrl 0x4c000421",
            "bctrl 0x4e800421",
            "bdnz 0x420000",
            "bdnza 0x42000002",
            "bdnzf 0x400000",
            "bdnzfa 0x40000002",
            "bdnzfl 0x40000001",
            "bdnzfla 0x40000003",
            "bdnzflr 0x4c000020",
            "bdnzflrl 0x4c000021",
            "bdnzl 0x42000001",
            "bdnzla 0x42000003",
            "bdnzlr 0x4e000020",
            "bdnzlrl 0x4e000021",
            "bdnzt 0x410000",
            "bdnzta 0x41000002",
            "bdnztl 0x41000001",
            "bdnztla 0x41000003",
            "bdnztlr 0x4d000020",
            "bdnztlrl 0x4d000021",
            "bdz 0x424000",
            "bdza 0x42400002",
            "bdzf 0x404000",
            "bdzfa 0x40400002",
            "bdzfl 0x40400001",
            "bdzfla 0x40400003",
            "bdzflr 0x4c400020",
            "bdzflrl 0x4c400021",
            "bdzl 0x42400001",
            "bdzla 0x42400003",
            "bdzlr 0x4e400020",
            "bdzlrl 0x4e400021",
            "bdzt 0x414000",
            "bdzta 0x41400002",
            "bdztl 0x41400001",
            "bdztla 0x41400003",
            "bdztlr 0x4d400020",
            "bdztlrl 0x4d400021",
            "beq 0x418200",
            "beqa 0x41820002",
            "beqctr 0x4d820420",
            "beqctrl 0x4d820421",
            "beql 0x41820001",
            "beqla 0x41820003",
            "beqlr 0x4d820020",
            "beqlrl 0x4d820021",
            "bf 0x408000",
            "bfa 0x40800002",
            "bfctr 0x4c800420",
            "bfctrl 0x4c800421",
            "bfl 0x40800001",
            "bfla 0x40800003",
            "bflr 0x4c800020",
            "bflrl 0x4c800021",
            "bge 0x408000",
            "bgea 0x40800002",
            "bgectr 0x4c800420",
            "bgectrl 0x4c800421",
            "bgel 0x40800001",
            "bgela 0x40800003",
            "bgelr 0x4c800020",
            "bgelrl 0x4c800021",
            "bgt 0x418100",
            "bgta 0x41810002",
            "bgtctr 0x4d810420",
            "bgtctrl 0x4d810421",
            "bgtl 0x41810001",
            "bgtla 0x41810003",
            "bgtlr 0x4d810020",
            "bgtlrl 0x4d810021",
            "bl 0x42800001",
            "bl 0x48000001",
            "bla 0x42800003",
            "bla 0x48000003",
            "ble 0x408100",
            "blea 0x40810002",
            "blectr 0x4c810420",
            "blectrl 0x4c810421",
            "blel 0x40810001",
            "blela 0x40810003",
            "blelr 0x4c810020",
            "blelrl 0x4c810021",
            "blr 0x4e800020",
            "blrl 0x4e800021",
            "blt 0x418000",
            "blta 0x41800002",
            "bltctr 0x4d800420",
            "bltctrl 0x4d800421",
            "bltl 0x41800001",
            "bltla 0x41800003",
            "bltlr 0x4d800020",
            "bltlrl 0x4d800021",
            "bne 0x408200",
            "bnea 0x40820002",
            "bnectr 0x4c820420",
            "bnectrl 0x4c820421",
            "bnel 0x40820001",
            "bnela 0x40820003",
            "bnelr 0x4c820020",
            "bnelrl 0x4c820021",
            "bng 0x408100",
            "bnga 0x40810002",
            "bngctr 0x4c810420",
            "bngctrl 0x4c810421",
            "bngl 0x40810001",
            "bngla 0x40810003",
            "bnglr 0x4c810020",
            "bnglrl 0x4c810021",
            "bnl 0x408000",
            "bnla 0x40800002",
            "bnlctr 0x4c800420",
            "bnlctrl 0x4c800421",
            "bnll 0x40800001",
            "bnlla 0x40800003",
            "bnllr 0x4c800020",
            "bnllrl 0x4c800021",
            "bns 0x408300",
            "bnsa 0x40830002",
            "bnsctr 0x4c830420",
            "bnsctrl 0x4c830421",
            "bnsl 0x40830001",
            "bnsla 0x40830003",
            "bnslr 0x4c830020",
            "bnslrl 0x4c830021",
            "bnu 0x408300",
            "bnua 0x40830002",
            "bnuctr 0x4c830420",
            "bnuctrl 0x4c830421",
            "bnul 0x40830001",
            "bnula 0x40830003",
            "bnulr 0x4c830020",
            "bnulrl 0x4c830021",
            "bso 0x418300",
            "bsoa 0x41830002",
            "bsoctr 0x4d830420",
            "bsoctrl 0x4d830421",
            "bsol 0x41830001",
            "bsola 0x41830003",
            "bsolr 0x4d830020",
            "bsolrl 0x4d830021",
            "bt 0x418000",
            "bta 0x41800002",
            "btctr 0x4d800420",
            "btctrl 0x4d800421",
            "btl 0x41800001",
            "btla 0x41800003",
            "btlr 0x4d800020",
            "btlrl 0x4d800021",
            "bun 0x418300",
            "buna 0x41830002",
            "bunctr 0x4d830420",
            "bunctrl 0x4d830421",
            "bunl 0x41830001",
            "bunla 0x41830003",
            "bunlr 0x4d830020",
            "bunlrl 0x4d830021",
            "clcs 0x7c000426",
            "cmp 0x7c0000",
            "cmpd 0x7c2000",
            "cmpdi 0x2c2000",
            "cmpi 0x2c0000",
            "cmpl 0x7c000040",
            "cmpld 0x7c200040",
            "cmpldi 0x282000",
            "cmpli 0x280000",
            "cmplw 0x7c000040",
            "cmplwi 0x280000",
            "cmpw 0x7c0000",
            "cmpwi 0x2c0000",
            "cntlzd 0x7c000074",
            "cntlzd 0x7c000075",
            "cntlzw 0x7c000034",
            "cntlzw 0x7c000035",
            "crand 0x4c000202",
            "crandc 0x4c000102",
            "creqv 0x4c000242",
            "crnand 0x4c0001c2",
            "crnor 0x4c000042",
            "cror 0x4c000382",
            "crorc 0x4c000342",
            "crxor 0x4c000182",
            "dcba 0x7c0005ec",
            "dcbf 0x7c0000ac",
            "dcbi 0x7c0003ac",
            "dcbst 0x7c00006c",
            "dcbt 0x7c00022c",
            "dcbt128 0x7c00022c",
            "dcbtst 0x7c0001ec",
            "dcbz 0x7c0007ec",
            "dcbz128 0x7c2007ec",
            "dcbzl 0x7c2007ec",
            "div 0x7c000296",
            "div 0x7c000297",
            "divd 0x7c0003d2",
            "divd 0x7c0003d3",
            "divdo 0x7c0007d2",
            "divdo 0x7c0007d3",
            "divdu 0x7c000392",
            "divdu 0x7c000393",
            "divduo 0x7c000792",
            "divduo 0x7c000793",
            "divo 0x7c000696",
            "divo 0x7c000697",
            "divs 0x7c0002d6",
            "divs 0x7c0002d7",
            "divso 0x7c0006d6",
            "divso 0x7c0006d7",
            "divw 0x7c0003d6",
            "divw 0x7c0003d7",
            "divwo 0x7c0007d6",
            "divwo 0x7c0007d7",
            "divwu 0x7c000396",
            "divwu 0x7c000397",
            "divwuo 0x7c000796",
            "divwuo 0x7c000797",
            "doz 0x7c000210",
            "doz 0x7c000211",
            "dozi 0x240000",
            "dozo 0x7c000610",
            "dozo 0x7c000611",
            "dss 0x7c00066c",
            "dssall 0x7e00066c",
            "dst 0x7c0002ac",
            "dstst 0x7c0002ec",
            "dststt 0x7e0002ec",
            "dstt 0x7e0002ac",
            "eciwx 0x7c00026c",
            "ecowx 0x7c00036c",
            "eieio 0x7c0006ac",
            "eqv 0x7c000238",
            "eqv 0x7c000239",
            "extsb 0x7c000774",
            "extsb 0x7c000775",
            "extsh 0x7c000734",
            "extsh 0x7c000735",
            "extsw 0x7c0007b4",
            "extsw 0x7c0007b5",
            "fabs 0xfc000210",
            "fabs 0xfc000211",
            "fadd 0xfc00002a",
            "fadd 0xfc00002b",
            "fadds 0xec00002a",
            "fadds 0xec00002b",
            "fcfid 0xfc00069c",
            "fcfid 0xfc00069d",
            "fcmpo 0xfc000040",
            "fcmpu 0xfc0000",
            "fctid 0xfc00065c",
            "fctid 0xfc00065d",
            "fctidz 0xfc00065e",
            "fctidz 0xfc00065f",
            "fctiw 0xfc00001c",
            "fctiw 0xfc00001d",
            "fctiwz 0xfc00001e",
            "fctiwz 0xfc00001f",
            "fdiv 0xfc000024",
            "fdiv 0xfc000025",
            "fdivs 0xec000024",
            "fdivs 0xec000025",
            "fmadd 0xfc00003a",
            "fmadd 0xfc00003b",
            "fmadds 0xec00003a",
            "fmadds 0xec00003b",
            "fmr 0xfc000090",
            "fmr 0xfc000091",
            "fmsub 0xfc000038",
            "fmsub 0xfc000039",
            "fmsubs 0xec000038",
            "fmsubs 0xec000039",
            "fmul 0xfc000032",
            "fmul 0xfc000033",
            "fmuls 0xec000032",
            "fmuls 0xec000033",
            "fnabs 0xfc000110",
            "fnabs 0xfc000111",
            "fneg 0xfc000050",
            "fneg 0xfc000051",
            "fnmadd 0xfc00003e",
            "fnmadd 0xfc00003f",
            "fnmadds 0xec00003e",
            "fnmadds 0xec00003f",
            "fnmsub 0xfc00003c",
            "fnmsub 0xfc00003d",
            "fnmsubs 0xec00003c",
            "fnmsubs 0xec00003d",
            "fres 0xec000030",
            "fres 0xec000031",
            "frsp 0xfc000018",
            "frsp 0xfc000019",
            "frsqrte 0xfc000034",
            "frsqrte 0xfc000035",
            "fsel 0xfc00002e",
            "fsel 0xfc00002f",
            "fsqrt 0xfc00002c",
            "fsqrt 0xfc00002d",
            "fsqrts 0xec00002c",
            "fsqrts 0xec00002d",
            "fsub 0xfc000028",
            "fsub 0xfc000029",
            "fsubs 0xec000028",
            "fsubs 0xec000029",
            "icbi 0x7c0007ac",
            "isync 0x4c00012c",
            "jbsr 0x48000001",
            "jmp 0x480000",
            "la 0x380000",
            "lbz 0x880000",
            "lbzu 0x8c0000",
            "lbzux 0x7c0000ee",
            "lbzx 0x7c0000ae",
            "ld 0xe80000",
            "ldarx 0x7c0000a8",
            "ldu 0xe8000001",
            "ldux 0x7c00006a",
            "ldx 0x7c00002a",
            "lfd 0xc80000",
            "lfdu 0xcc0000",
            "lfdux 0x7c0004ee",
            "lfdx 0x7c0004ae",
            "lfs 0xc00000",
            "lfsu 0xc40000",
            "lfsux 0x7c00046e",
            "lfsx 0x7c00042e",
            "lha 0xa80000",
            "lhau 0xac0000",
            "lhaux 0x7c0002ee",
            "lhax 0x7c0002ae",
            "lhbrx 0x7c00062c",
            "lhz 0xa00000",
            "lhzu 0xa40000",
            "lhzux 0x7c00026e",
            "lhzx 0x7c00022e",
            "li 0x380000",
            "lis 0x3c0000",
            "lmw 0xb80000",
            "lscbx 0x7c00022a",
            "lscbx 0x7c00022b",
            "lswi 0x7c0004aa",
            "lswx 0x7c00042a",
            "lvebx 0x7c00000e",
            "lvehx 0x7c00004e",
            "lvewx 0x7c00008e",
            "lvsl 0x7c00000c",
            "lvsr 0x7c00004c",
            "lvx 0x7c0000ce",
            "lvxl 0x7c0002ce",
            "lwa 0xe8000002",
            "lwarx 0x7c000028",
            "lwaux 0x7c0002ea",
            "lwax 0x7c0002aa",
            "lwbrx 0x7c00042c",
            "lwsync 0x7c2004ac",
            "lwz 0x800000",
            "lwzu 0x840000",
            "lwzux 0x7c00006e",
            "lwzx 0x7c00002e",
            "maskg 0x7c00003a",
            "maskg 0x7c00003b",
            "maskir 0x7c00043a",
            "maskir 0x7c00043b",
            "mcrf 0x4c0000",
            "mcrfs 0xfc000080",
            "mcrxr 0x7c0004",
            "mfcr 0x7c000026",
            "mfcr 0x7c100026",
            "mfctr 0x7c0902a6",
            "mffs 0xfc00048e",
            "mffs 0xfc00048f",
            "mflr 0x7c0802a6",
            "mfmq 0x7c0002a6",
            "mfmsr 0x7c0000a6",
            "mfocrf 0x7c100026",
            "mfrtcl 0x7c0502a6",
            "mfrtcu 0x7c0402a6",
            "mfspr 0x7c0002a6",
            "mfsr 0x7c0004a6",
            "mfsrin 0x7c000526",
            "mftb 0x7c0002e6",
            "mftb 0x7c0c42e6",
            "mftbu 0x7c0d42e6",
            "mfvscr 0x10000604",
            "mfxer 0x7c0102a6",
            "mtcrf 0x7c000120",
            "mtctr 0x7c0903a6",
            "mtfsb0 0xfc00008c",
            "mtfsb0 0xfc00008d",
            "mtfsb1 0xfc00004c",
            "mtfsb1 0xfc00004d",
            "mtfsf 0xfc00058e",
            "mtfsf 0xfc00058f",
            "mtfsfi 0xfc00010c",
            "mtfsfi 0xfc00010d",
            "mtlr 0x7c0803a6",
            "mtmq 0x7c0003a6",
            "mtmsr 0x7c000124",
            "mtmsrd 0x7c000164",
            "mtocrf 0x7c000120",
            "mtrtcl 0x7c1503a6",
            "mtrtcu 0x7c1403a6",
            "mtspr 0x7c0003a6",
            "mtsr 0x7c0001a4",
            "mtsrin 0x7c0001e4",
            "mttbl 0x7c1c43a6",
            "mttbu 0x7c1d43a6",
            "mtvscr 0x10000644",
            "mtxer 0x7c0103a6",
            "mul 0x7c0000d6",
            "mul 0x7c0000d7",
            "mulhd 0x7c000092",
            "mulhd 0x7c000093",
            "mulhdu 0x7c000012",
            "mulhdu 0x7c000013",
            "mulhw 0x7c000096",
            "mulhw 0x7c000097",
            "mulhwu 0x7c000016",
            "mulhwu 0x7c000017",
            "mull 0x7c0001d6",
            "mull 0x7c0001d7",
            "mulld 0x7c0001d2",
            "mulld 0x7c0001d3",
            "mulldo 0x7c0005d2",
            "mulldo 0x7c0005d3",
            "mulli 0x1c0000",
            "mullo 0x7c0005d6",
            "mullo 0x7c0005d7",
            "mullw 0x7c0001d6",
            "mullw 0x7c0001d7",
            "mullwo 0x7c0005d6",
            "mullwo 0x7c0005d7",
            "mulo 0x7c0004d6",
            "mulo 0x7c0004d7",
            "mulwd 0x7c000096",
            "mulwd 0x7c000097",
            "nabs 0x7c0003d0",
            "nabs 0x7c0003d1",
            "nabso 0x7c0007d0",
            "nabso 0x7c0007d1",
            "nand 0x7c0003b8",
            "nand 0x7c0003b9",
            "neg 0x7c0000d0",
            "neg 0x7c0000d1",
            "nego 0x7c0004d0",
            "nego 0x7c0004d1",
            "nop 0x600000",
            "nor 0x7c0000f8",
            "nor 0x7c0000f9",
            "or 0x7c000378",
            "or 0x7c000379",
            "orc 0x7c000338",
            "orc 0x7c000339",
            "ori 0x600000",
            "oris 0x640000",
            "ptesync 0x7c4004ac",
            "rfi 0x4c000064",
            "rfid 0x4c000024",
            "rldcl 0x78000010",
            "rldcl 0x78000011",
            "rldcr 0x78000012",
            "rldcr 0x78000013",
            "rldic 0x78000008",
            "rldic 0x78000009",
            "rldicl 0x780000",
            "rldicl 0x78000001",
            "rldicr 0x78000004",
            "rldicr 0x78000005",
            "rldimi 0x7800000c",
            "rldimi 0x7800000d",
            "rlmi 0x580000",
            "rlmi 0x58000001",
            "rlwimi 0x500000",
            "rlwimi 0x50000001",
            "rlwinm 0x540000",
            "rlwinm 0x54000001",
            "rlwnm 0x5c0000",
            "rlwnm 0x5c000001",
            "rrib 0x7c000432",
            "rrib 0x7c000433",
            "sc 0x44000002",
            "slbia 0x7c0003e4",
            "slbie 0x7c000364",
            "slbmfee 0x7c000726",
            "slbmfev 0x7c0006a6",
            "slbmte 0x7c000324",
            "sld 0x7c000036",
            "sld 0x7c000037",
            "sle 0x7c000132",
            "sle 0x7c000133",
            "sleq 0x7c0001b2",
            "sleq 0x7c0001b3",
            "sliq 0x7c000170",
            "sliq 0x7c000171",
            "slliq 0x7c0001f0",
            "slliq 0x7c0001f1",
            "sllq 0x7c0001b0",
            "sllq 0x7c0001b1",
            "slq 0x7c000130",
            "slq 0x7c000131",
            "slw 0x7c000030",
            "slw 0x7c000031",
            "srad 0x7c000634",
            "srad 0x7c000635",
            "sradi 0x7c000674",
            "sradi 0x7c000675",
            "sraiq 0x7c000770",
            "sraiq 0x7c000771",
            "sraq 0x7c000730",
            "sraq 0x7c000731",
            "sraw 0x7c000630",
            "sraw 0x7c000631",
            "srawi 0x7c000670",
            "srawi 0x7c000671",
            "srd 0x7c000436",
            "srd 0x7c000437",
            "sre 0x7c000532",
            "sre 0x7c000533",
            "srea 0x7c000732",
            "srea 0x7c000733",
            "sreq 0x7c0005b2",
            "sreq 0x7c0005b3",
            "sriq 0x7c000570",
            "sriq 0x7c000571",
            "srliq 0x7c0005f0",
            "srliq 0x7c0005f1",
            "srlq 0x7c0005b0",
            "srlq 0x7c0005b1",
            "srq 0x7c000530",
            "srq 0x7c000531",
            "srw 0x7c000430",
            "srw 0x7c000431",
            "stb 0x980000",
            "stbu 0x9c0000",
            "stbux 0x7c0001ee",
            "stbx 0x7c0001ae",
            "std 0xf80000",
            "stdcx 0x7c0001ad",
            "stdu 0xf8000001",
            "stdux 0x7c00016a",
            "stdx 0x7c00012a",
            "stfd 0xd80000",
            "stfdu 0xdc0000",
            "stfdux 0x7c0005ee",
            "stfdx 0x7c0005ae",
            "stfiwx 0x7c0007ae",
            "stfs 0xd00000",
            "stfsu 0xd40000",
            "stfsux 0x7c00056e",
            "stfsx 0x7c00052e",
            "sth 0xb00000",
            "sthbrx 0x7c00072c",
            "sthu 0xb40000",
            "sthux 0x7c00036e",
            "sthx 0x7c00032e",
            "stmw 0xbc0000",
            "stswi 0x7c0005aa",
            "stswx 0x7c00052a",
            "stvebx 0x7c00010e",
            "stvehx 0x7c00014e",
            "stvewx 0x7c00018e",
            "stvx 0x7c0001ce",
            "stvxl 0x7c0003ce",
            "stw 0x900000",
            "stwbrx 0x7c00052c",
            "stwcx 0x7c00012d",
            "stwu 0x940000",
            "stwux 0x7c00016e",
            "stwx 0x7c00012e",
            "sub 0x7c000050",
            "sub 0x7c000051",
            "subc 0x7c000010",
            "subc 0x7c000011",
            "subco 0x7c000410",
            "subco 0x7c000411",
            "subf 0x7c000050",
            "subf 0x7c000051",
            "subfc 0x7c000010",
            "subfc 0x7c000011",
            "subfco 0x7c000410",
            "subfco 0x7c000411",
            "subfe 0x7c000110",
            "subfe 0x7c000111",
            "subfeo 0x7c000510",
            "subfeo 0x7c000511",
            "subfic 0x200000",
            "subfme 0x7c0001d0",
            "subfme 0x7c0001d1",
            "subfmeo 0x7c0005d0",
            "subfmeo 0x7c0005d1",
            "subfo 0x7c000450",
            "subfo 0x7c000451",
            "subfze 0x7c000190",
            "subfze 0x7c000191",
            "subfzeo 0x7c000590",
            "subfzeo 0x7c000591",
            "subo 0x7c000450",
            "subo 0x7c000451",
            "sync 0x7c0004ac",
            "td 0x7c000088",
            "tdeq 0x7c800088",
            "tdeqi 0x088000",
            "tdge 0x7d800088",
            "tdgei 0x098000",
            "tdgt 0x7d000088",
            "tdgti 0x090000",
            "tdi 0x080000",
            "tdle 0x7e800088",
            "tdlei 0x0a8000",
            "tdlge 0x7ca00088",
            "tdlgei 0x08a000",
            "tdlgt 0x7c200088",
            "tdlgti 0x082000",
            "tdlle 0x7cc00088",
            "tdllei 0x08c000",
            "tdllt 0x7c400088",
            "tdllti 0x084000",
            "tdlng 0x7cc00088",
            "tdlngi 0x08c000",
            "tdlnl 0x7ca00088",
            "tdlnli 0x08a000",
            "tdlt 0x7e000088",
            "tdlti 0x0a0000",
            "tdne 0x7f000088",
            "tdnei 0x0b0000",
            "tdng 0x7e800088",
            "tdngi 0x0a8000",
            "tdnl 0x7d800088",
            "tdnli 0x098000",
            "tlbia 0x7c0002e4",
            "tlbie 0x7c000264",
            "tlbiel 0x7c000224",
            "tlbld 0x7c0007a4",
            "tlbli 0x7c0007e4",
            "tlbsync 0x7c00046c",
            "trap 0x7fe00008",
            "tw 0x7c000008",
            "tweq 0x7c800008",
            "tweqi 0x0c8000",
            "twge 0x7d800008",
            "twgei 0x0d8000",
            "twgt 0x7d000008",
            "twgti 0x0d0000",
            "twi 0x0c0000",
            "twle 0x7e800008",
            "twlei 0x0e8000",
            "twlge 0x7ca00008",
            "twlgei 0x0ca000",
            "twlgt 0x7c200008",
            "twlgti 0x0c2000",
            "twlle 0x7cc00008",
            "twllei 0x0cc000",
            "twllt 0x7c400008",
            "twllti 0x0c4000",
            "twlng 0x7cc00008",
            "twlngi 0x0cc000",
            "twlnl 0x7ca00008",
            "twlnli 0x0ca000",
            "twlt 0x7e000008",
            "twlti 0x0e0000",
            "twne 0x7f000008",
            "twnei 0x0f0000",
            "twng 0x7e800008",
            "twngi 0x0e8000",
            "twnl 0x7d800008",
            "twnli 0x0d8000",
            "vaddcuw 0x10000180",
            "vaddfp 0x1000000a",
            "vaddsbs 0x100003",
            "vaddshs 0x10000340",
            "vaddsws 0x10000380",
            "vaddubm 0x100000",
            "vaddubs 0x100002",
            "vadduhm 0x10000040",
            "vadduhs 0x10000240",
            "vadduwm 0x10000080",
            "vadduws 0x10000280",
            "vand 0x10000404",
            "vandc 0x10000444",
            "vavgsb 0x10000502",
            "vavgsh 0x10000542",
            "vavgsw 0x10000582",
            "vavgub 0x10000402",
            "vavguh 0x10000442",
            "vavguw 0x10000482",
            "vcfsx 0x1000034a",
            "vcfux 0x1000030a",
            "vcmpbfp 0x100003c6",
            "vcmpbfp 0x100007c6",
            "vcmpeqfp 0x100000c6",
            "vcmpeqfp 0x100004c6",
            "vcmpequb 0x10000006",
            "vcmpequb 0x10000406",
            "vcmpequh 0x10000046",
            "vcmpequh 0x10000446",
            "vcmpequw 0x10000086",
            "vcmpequw 0x10000486",
            "vcmpgefp 0x100001c6",
            "vcmpgefp 0x100005c6",
            "vcmpgtfp 0x100002c6",
            "vcmpgtfp 0x100006c6",
            "vcmpgtsb 0x10000306",
            "vcmpgtsb 0x10000706",
            "vcmpgtsh 0x10000346",
            "vcmpgtsh 0x10000746",
            "vcmpgtsw 0x10000386",
            "vcmpgtsw 0x10000786",
            "vcmpgtub 0x10000206",
            "vcmpgtub 0x10000606",
            "vcmpgtuh 0x10000246",
            "vcmpgtuh 0x10000646",
            "vcmpgtuw 0x10000286",
            "vcmpgtuw 0x10000686",
            "vctsxs 0x100003ca",
            "vctuxs 0x1000038a",
            "vexptefp 0x1000018a",
            "vlogefp 0x100001ca",
            "vmaddfp 0x1000002e",
            "vmaxfp 0x1000040a",
            "vmaxsb 0x10000102",
            "vmaxsh 0x10000142",
            "vmaxsw 0x10000182",
            "vmaxub 0x10000002",
            "vmaxuh 0x10000042",
            "vmaxuw 0x10000082",
            "vmhaddshs 0x10000020",
            "vmhraddshs 0x10000021",
            "vminfp 0x1000044a",
            "vminsb 0x10000302",
            "vminsh 0x10000342",
            "vminsw 0x10000382",
            "vminub 0x10000202",
            "vminuh 0x10000242",
            "vminuw 0x10000282",
            "vmladduhm 0x10000022",
            "vmrghb 0x1000000c",
            "vmrghh 0x1000004c",
            "vmrghw 0x1000008c",
            "vmrglb 0x1000010c",
            "vmrglh 0x1000014c",
            "vmrglw 0x1000018c",
            "vmsummbm 0x10000025",
            "vmsumshm 0x10000028",
            "vmsumshs 0x10000029",
            "vmsumubm 0x10000024",
            "vmsumuhm 0x10000026",
            "vmsumuhs 0x10000027",
            "vmulesb 0x10000308",
            "vmulesh 0x10000348",
            "vmuleub 0x10000208",
            "vmuleuh 0x10000248",
            "vmulosb 0x10000108",
            "vmulosh 0x10000148",
            "vmuloub 0x10000008",
            "vmulouh 0x10000048",
            "vnmsubfp 0x1000002f",
            "vnor 0x10000504",
            "vor 0x10000484",
            "vperm 0x1000002b",
            "vpkpx 0x1000030e",
            "vpkshss 0x1000018e",
            "vpkshus 0x1000010e",
            "vpkswss 0x100001ce",
            "vpkswus 0x1000014e",
            "vpkuhum 0x1000000e",
            "vpkuhus 0x1000008e",
            "vpkuwum 0x1000004e",
            "vpkuwus 0x100000ce",
            "vrefp 0x1000010a",
            "vrfim 0x100002ca",
            "vrfin 0x1000020a",
            "vrfip 0x1000028a",
            "vrfiz 0x1000024a",
            "vrlb 0x10000004",
            "vrlh 0x10000044",
            "vrlw 0x10000084",
            "vrsqrtefp 0x1000014a",
            "vsel 0x1000002a",
            "vsl 0x100001c4",
            "vslb 0x10000104",
            "vsldoi 0x1000002c",
            "vslh 0x10000144",
            "vslo 0x1000040c",
            "vslw 0x10000184",
            "vspltb 0x1000020c",
            "vsplth 0x1000024c",
            "vspltisb 0x1000030c",
            "vspltish 0x1000034c",
            "vspltisw 0x1000038c",
            "vspltw 0x1000028c",
            "vsr 0x100002c4",
            "vsrab 0x10000304",
            "vsrah 0x10000344",
            "vsraw 0x10000384",
            "vsrb 0x10000204",
            "vsrh 0x10000244",
            "vsro 0x1000044c",
            "vsrw 0x10000284",
            "vsubcuw 0x10000580",
            "vsubfp 0x1000004a",
            "vsubsbs 0x100007",
            "vsubshs 0x10000740",
            "vsubsws 0x10000780",
            "vsububm 0x100004",
            "vsububs 0x100006",
            "vsubuhm 0x10000440",
            "vsubuhs 0x10000640",
            "vsubuwm 0x10000480",
            "vsubuws 0x10000680",
            "vsum2sws 0x10000688",
            "vsum4sbs 0x10000708",
            "vsum4shs 0x10000648",
            "vsum4ubs 0x10000608",
            "vsumsws 0x10000788",
            "vupkhpx 0x1000034e",
            "vupkhsb 0x1000020e",
            "vupkhsh 0x1000024e",
            "vupklpx 0x100003ce",
            "vupklsb 0x1000028e",
            "vupklsh 0x100002ce",
            "vxor 0x100004c4",
            "xor 0x7c000278",
            "xor 0x7c000279",
            "xori 0x680000",
            "xoris 0x6c0000"});
            this.Types.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Types.Size = new System.Drawing.Size(126, 20);
            this.Types.TabIndex = 41;
            this.Types.SelectedIndexChanged += new System.EventHandler(this.Types_SelectedIndexChanged);
            // 
            // UseType
            // 
            this.UseType.Location = new System.Drawing.Point(210, 104);
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
            this.PlusButton.Location = new System.Drawing.Point(228, 56);
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
            this.MinusButton.Location = new System.Drawing.Point(210, 56);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(16, 14);
            this.MinusButton.TabIndex = 39;
            this.MinusButton.Text = "-";
            this.MinusButton.Click += new System.EventHandler(this.AddressMath_Click);
            // 
            // ProvideSizeType
            // 
            this.ProvideSizeType.EditValue = "be32";
            this.ProvideSizeType.Location = new System.Drawing.Point(82, 27);
            this.ProvideSizeType.Name = "ProvideSizeType";
            this.ProvideSizeType.Properties.AllowFocused = false;
            this.ProvideSizeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProvideSizeType.Properties.Items.AddRange(new object[] {
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
            this.ProvideSizeLabel.Location = new System.Drawing.Point(5, 30);
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
            this.ValueLabel.Location = new System.Drawing.Point(43, 82);
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
            this.AddressLabel.Location = new System.Drawing.Point(30, 56);
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
            this.simpleButton3.Location = new System.Drawing.Point(2, 133);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(385, 23);
            this.simpleButton3.TabIndex = 30;
            this.simpleButton3.Text = "Add [[patch.be]] Header";
            this.simpleButton3.Click += new System.EventHandler(this.AddPokeHeader_Click);
            // 
            // PatchValue
            // 
            this.PatchValue.Location = new System.Drawing.Point(82, 79);
            this.PatchValue.Name = "PatchValue";
            this.PatchValue.Size = new System.Drawing.Size(126, 20);
            this.PatchValue.TabIndex = 31;
            // 
            // PatchAddress
            // 
            this.PatchAddress.Location = new System.Drawing.Point(82, 53);
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
            this.BottomManager.MaxItemId = 14;
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
            this.barDockControlTop.Location = new System.Drawing.Point(0, 46);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
            this.barDockControlLeft.Manager = this.BottomManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 662);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(816, 46);
            this.barDockControlRight.Manager = this.BottomManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 662);
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
            this.barButtonItem4.Caption = "Settings";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarManagerFormOpen_Click);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Clear";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearOutput_Click);
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
            this.DropLog.Location = new System.Drawing.Point(10, 27);
            this.DropLog.Name = "DropLog";
            this.DropLog.Size = new System.Drawing.Size(794, 65);
            this.DropLog.TabIndex = 23;
            this.DropLog.Text = "Drop Xenia Log Here: / Drop Patch File Here:";
            this.DropLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropBox_DragDrop);
            this.DropLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropBox_DragEnter);
            // 
            // OutPut
            // 
            this.OutPut.AllowDrop = true;
            this.OutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.OutPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutPut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutPut.ForeColor = System.Drawing.Color.White;
            this.OutPut.Location = new System.Drawing.Point(0, 252);
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(816, 456);
            this.OutPut.TabIndex = 26;
            this.OutPut.Text = "";
            this.OutPut.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutPut_DragDrop);
            this.OutPut.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropBox_DragEnter);
            this.OutPut.TextChanged += new System.EventHandler(this.OutPut_TextChanged);
            this.OutPut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OutPut_KeyDown);
            this.OutPut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutPut_KeyPress);
            this.OutPut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OutPut_KeyUp);
            this.OutPut.Leave += new System.EventHandler(this.OutPut_Leave);
            // 
            // TopManager
            // 
            this.TopManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.TopManager.DockControls.Add(this.barDockControl1);
            this.TopManager.DockControls.Add(this.barDockControl2);
            this.TopManager.DockControls.Add(this.barDockControl3);
            this.TopManager.DockControls.Add(this.barDockControl4);
            this.TopManager.Form = this;
            this.TopManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem2,
            this.barSubItem4,
            this.barSubItem5,
            this.barButtonItem6,
            this.barButtonItem3,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barSubItem1,
            this.ValueConverter,
            this.barSubItem3,
            this.barSubItem6,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barSubItem7});
            this.TopManager.MainMenu = this.bar2;
            this.TopManager.MaxItemId = 16;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3)});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem7)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Save";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SavePatchFile_Click);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Load";
            this.barButtonItem7.Id = 5;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LoadPatchFile_Click);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Clear";
            this.barButtonItem8.Id = 6;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearOutput_Click);
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = "Search";
            this.barSubItem6.Id = 10;
            this.barSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11)});
            this.barSubItem6.Name = "barSubItem6";
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
            // barSubItem1
            // 
            this.barSubItem1.Caption = "View";
            this.barSubItem1.Id = 7;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ValueConverter)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // ValueConverter
            // 
            this.ValueConverter.Caption = "Value Converter";
            this.ValueConverter.Id = 8;
            this.ValueConverter.Name = "ValueConverter";
            this.ValueConverter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ValueConverter_ItemClick);
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "Settings";
            this.barSubItem5.Id = 2;
            this.barSubItem5.Name = "barSubItem5";
            this.barSubItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarManagerFormOpen_Click);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Help";
            this.barSubItem3.Id = 9;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "About";
            this.barButtonItem6.Id = 3;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.TopManager;
            this.barDockControl1.Size = new System.Drawing.Size(816, 46);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 736);
            this.barDockControl2.Manager = this.TopManager;
            this.barDockControl2.Size = new System.Drawing.Size(816, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 46);
            this.barDockControl3.Manager = this.TopManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 690);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(816, 46);
            this.barDockControl4.Manager = this.TopManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 690);
            // 
            // richEditControl1
            // 
            this.richEditControl1.Location = new System.Drawing.Point(376, 282);
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
            this.Controls.Add(this.OutPut);
            this.Controls.Add(this.DropLog);
            this.Controls.Add(this.PatchInfoGroup);
            this.Controls.Add(this.PatchAddressGroup);
            this.Controls.Add(this.GameInfoHeader);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.MediaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HashKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatchInfoGroup)).EndInit();
            this.PatchInfoGroup.ResumeLayout(false);
            this.PatchInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsOn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Authors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desc.Properties)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl GameInfoHeader;
        private DevExpress.XtraEditors.TextEdit TitleName;
        private DevExpress.XtraEditors.GroupControl PatchInfoGroup;
        private DevExpress.XtraEditors.GroupControl PatchAddressGroup;
        private DevExpress.XtraEditors.TextEdit MediaId;
        private DevExpress.XtraEditors.TextEdit HashKey;
        private DevExpress.XtraEditors.TextEdit TitleId;
        private DevExpress.XtraEditors.GroupControl DropLog;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ToggleSwitch IsOn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit Authors;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit Desc;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit PatchName;
        private DevExpress.XtraEditors.ComboBoxEdit ProvideSizeType;
        private System.Windows.Forms.Label ProvideSizeLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label AddressLabel;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit PatchAddress;
        public System.Windows.Forms.RichTextBox OutPut;
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
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem ValueConverter;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarSubItem barSubItem7;
        private DevExpress.XtraEditors.ComboBoxEdit Types;
        private Label label5;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
    }
}

