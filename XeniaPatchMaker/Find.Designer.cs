
namespace XeniaPatchMaker
{
    partial class Find
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.SearchTextbox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SearchAll = new DevExpress.XtraEditors.SimpleButton();
            this.OK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(474, 132);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.SearchTextbox);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(472, 105);
            this.xtraTabPage1.Text = "Text-String";
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(74, 12);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SearchTextbox.Size = new System.Drawing.Size(265, 20);
            this.SearchTextbox.TabIndex = 2;
            this.SearchTextbox.EditValueChanged += new System.EventHandler(this.SearchTextbox_EditValueChanging);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Search For:";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.checkEdit4);
            this.groupControl2.Controls.Add(this.checkEdit3);
            this.groupControl2.Controls.Add(this.checkEdit2);
            this.groupControl2.Location = new System.Drawing.Point(345, -2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(123, 103);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Search Direction";
            // 
            // checkEdit4
            // 
            this.checkEdit4.Location = new System.Drawing.Point(5, 74);
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.AllowFocused = false;
            this.checkEdit4.Properties.Caption = "Up";
            this.checkEdit4.Size = new System.Drawing.Size(101, 19);
            this.checkEdit4.TabIndex = 3;
            this.checkEdit4.Click += new System.EventHandler(this.checkEdit2_Click);
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(5, 49);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.AllowFocused = false;
            this.checkEdit3.Properties.Caption = "Down";
            this.checkEdit3.Size = new System.Drawing.Size(101, 19);
            this.checkEdit3.TabIndex = 2;
            this.checkEdit3.Click += new System.EventHandler(this.checkEdit2_Click);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(5, 24);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.AllowFocused = false;
            this.checkEdit2.Properties.Caption = "All";
            this.checkEdit2.Size = new System.Drawing.Size(101, 19);
            this.checkEdit2.TabIndex = 1;
            this.checkEdit2.Click += new System.EventHandler(this.checkEdit2_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Location = new System.Drawing.Point(11, 43);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(328, 55);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Options";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(5, 24);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.AllowFocused = false;
            this.checkEdit1.Properties.Caption = "Case Sensitive";
            this.checkEdit1.Size = new System.Drawing.Size(101, 19);
            this.checkEdit1.TabIndex = 1;
            this.checkEdit1.Click += new System.EventHandler(this.checkEdit2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.Location = new System.Drawing.Point(406, 138);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(67, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SearchAll
            // 
            this.SearchAll.AllowFocus = false;
            this.SearchAll.Enabled = false;
            this.SearchAll.Location = new System.Drawing.Point(333, 138);
            this.SearchAll.Name = "SearchAll";
            this.SearchAll.Size = new System.Drawing.Size(67, 23);
            this.SearchAll.TabIndex = 2;
            this.SearchAll.Text = "Search All";
            // 
            // OK
            // 
            this.OK.AllowFocus = false;
            this.OK.Enabled = false;
            this.OK.Location = new System.Drawing.Point(260, 138);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(67, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 163);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.SearchAll);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Find";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit checkEdit4;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton SearchAll;
        private DevExpress.XtraEditors.SimpleButton OK;
        private DevExpress.XtraEditors.ComboBoxEdit SearchTextbox;
    }
}