
namespace XeniaPatchMaker
{
    partial class XPFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XPFM));
            this.OutPut = new System.Windows.Forms.RichTextBox();
            this.TitleName = new System.Windows.Forms.TextBox();
            this.TitleId = new System.Windows.Forms.TextBox();
            this.HashKey = new System.Windows.Forms.TextBox();
            this.MediaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IsOn = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Authors = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PatchName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProvideSizeType = new System.Windows.Forms.ComboBox();
            this.PatchAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PatchValue = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutPut
            // 
            this.OutPut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutPut.Location = new System.Drawing.Point(0, 208);
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(800, 401);
            this.OutPut.TabIndex = 0;
            this.OutPut.Text = "";
            // 
            // TitleName
            // 
            this.TitleName.Location = new System.Drawing.Point(69, 12);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(126, 20);
            this.TitleName.TabIndex = 1;
            // 
            // TitleId
            // 
            this.TitleId.Location = new System.Drawing.Point(69, 38);
            this.TitleId.Name = "TitleId";
            this.TitleId.Size = new System.Drawing.Size(126, 20);
            this.TitleId.TabIndex = 2;
            // 
            // HashKey
            // 
            this.HashKey.Location = new System.Drawing.Point(69, 64);
            this.HashKey.Name = "HashKey";
            this.HashKey.Size = new System.Drawing.Size(126, 20);
            this.HashKey.TabIndex = 3;
            // 
            // MediaId
            // 
            this.MediaId.Location = new System.Drawing.Point(69, 90);
            this.MediaId.Name = "MediaId";
            this.MediaId.Size = new System.Drawing.Size(126, 20);
            this.MediaId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tittle ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Media ID";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save Patch File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.IsOn);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Authors);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PatchName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Desc);
            this.groupBox1.Location = new System.Drawing.Point(215, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 141);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patch Info";
            // 
            // IsOn
            // 
            this.IsOn.AutoSize = true;
            this.IsOn.Location = new System.Drawing.Point(85, 94);
            this.IsOn.Name = "IsOn";
            this.IsOn.Size = new System.Drawing.Size(48, 17);
            this.IsOn.TabIndex = 19;
            this.IsOn.Text = "false";
            this.IsOn.UseVisualStyleBackColor = true;
            this.IsOn.CheckedChanged += new System.EventHandler(this.IsOn_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.Location = new System.Drawing.Point(3, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Add [[patch]] Header";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AddPatchHeader_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Is Enabled";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Authors";
            // 
            // Authors
            // 
            this.Authors.Location = new System.Drawing.Point(85, 66);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(100, 20);
            this.Authors.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Desc";
            // 
            // PatchName
            // 
            this.PatchName.Location = new System.Drawing.Point(85, 14);
            this.PatchName.Name = "PatchName";
            this.PatchName.Size = new System.Drawing.Size(100, 20);
            this.PatchName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(85, 40);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(100, 20);
            this.Desc.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ProvideSizeType);
            this.groupBox2.Controls.Add(this.PatchAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.PatchValue);
            this.groupBox2.Location = new System.Drawing.Point(421, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 141);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patch Location";
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.Location = new System.Drawing.Point(3, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(194, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "Add [[patch.be]] Header";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AddPokeHeader_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Provided Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Value";
            // 
            // ProvideSizeType
            // 
            this.ProvideSizeType.AccessibleDescription = "be32";
            this.ProvideSizeType.AccessibleName = "be32";
            this.ProvideSizeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProvideSizeType.Items.AddRange(new object[] {
            "be64",
            "be32",
            "be16",
            "be8"});
            this.ProvideSizeType.Location = new System.Drawing.Point(87, 34);
            this.ProvideSizeType.MaxLength = 4;
            this.ProvideSizeType.Name = "ProvideSizeType";
            this.ProvideSizeType.Size = new System.Drawing.Size(50, 21);
            this.ProvideSizeType.TabIndex = 20;
            // 
            // PatchAddress
            // 
            this.PatchAddress.Location = new System.Drawing.Point(87, 61);
            this.PatchAddress.Name = "PatchAddress";
            this.PatchAddress.Size = new System.Drawing.Size(100, 20);
            this.PatchAddress.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Address";
            // 
            // PatchValue
            // 
            this.PatchValue.Location = new System.Drawing.Point(87, 87);
            this.PatchValue.Name = "PatchValue";
            this.PatchValue.Size = new System.Drawing.Size(100, 20);
            this.PatchValue.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 44);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drop Xenia Log Here:";
            this.groupBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropBox_DragDrop);
            this.groupBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropBox_DragEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.TitleName);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.TitleId);
            this.groupBox4.Controls.Add(this.HashKey);
            this.groupBox4.Controls.Add(this.MediaId);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 142);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.Location = new System.Drawing.Point(3, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Write Xex Info";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.XEXInfo_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(6, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Clear Output";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(632, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 190);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Patch Controls";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(6, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Load Patch File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LoadPatchFile_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Location = new System.Drawing.Point(6, 75);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 23);
            this.button9.TabIndex = 24;
            this.button9.Text = "About And Contributors";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Credit_Click);
            // 
            // XPFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OutPut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 648);
            this.MinimumSize = new System.Drawing.Size(816, 648);
            this.Name = "XPFM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xenia Patch Maker By TeddyHammer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutPut;
        private System.Windows.Forms.TextBox TitleName;
        private System.Windows.Forms.TextBox TitleId;
        private System.Windows.Forms.TextBox HashKey;
        private System.Windows.Forms.TextBox MediaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Authors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PatchName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PatchAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PatchValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox IsOn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ProvideSizeType;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
    }
}

