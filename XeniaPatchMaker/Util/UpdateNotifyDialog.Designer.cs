namespace XeniaPatchMaker
{
    partial class UpdateNotifyDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxReleaseNotes = new DevExpress.XtraEditors.CheckButton();
            this.buttonNo = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Changes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "There is a new version of {0} available!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Would you like to download it now?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // boxReleaseNotes
            // 
            this.boxReleaseNotes.Location = new System.Drawing.Point(5, 55);
            this.boxReleaseNotes.Name = "boxReleaseNotes";
            this.boxReleaseNotes.Size = new System.Drawing.Size(75, 23);
            this.boxReleaseNotes.TabIndex = 7;
            this.boxReleaseNotes.Text = "What\'s new?";
            this.boxReleaseNotes.CheckedChanged += new System.EventHandler(this.boxReleaseNotes_CheckedChanged);
            // 
            // buttonNo
            // 
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.Location = new System.Drawing.Point(214, 55);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 5;
            this.buttonNo.Text = "No";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.simpleButton1.Location = new System.Drawing.Point(295, 55);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Yes";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Changes
            // 
            this.Changes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Changes.Location = new System.Drawing.Point(0, 50);
            this.Changes.Name = "Changes";
            this.Changes.Size = new System.Drawing.Size(346, 10);
            this.Changes.TabIndex = 8;
            this.Changes.Text = "";
            this.Changes.Visible = false;
            // 
            // UpdateNotifyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(346, 60);
            this.ControlBox = false;
            this.Controls.Add(this.Changes);
            this.Controls.Add(this.boxReleaseNotes);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 156);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 108);
            this.Name = "UpdateNotifyDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update available!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdateNotifyDialog_Load);
            this.Shown += new System.EventHandler(this.UpdateNotifyDialog_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton buttonNo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckButton boxReleaseNotes;
        private System.Windows.Forms.RichTextBox Changes;
    }
}