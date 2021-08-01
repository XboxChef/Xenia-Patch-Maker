namespace GitHubUpdate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxReleaseNotes = new DevExpress.XtraEditors.CheckButton();
            this.buttonNo = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ReleaseNotesPanel = new System.Windows.Forms.Panel();
            this.ReleaseNotes = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.ReleaseNotesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
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
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Would you like to download it now?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boxReleaseNotes);
            this.panel1.Controls.Add(this.buttonNo);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 90);
            this.panel1.TabIndex = 5;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // boxReleaseNotes
            // 
            this.boxReleaseNotes.Location = new System.Drawing.Point(6, 55);
            this.boxReleaseNotes.Name = "boxReleaseNotes";
            this.boxReleaseNotes.Size = new System.Drawing.Size(75, 23);
            this.boxReleaseNotes.TabIndex = 7;
            this.boxReleaseNotes.Text = "What\'s new?";
            this.boxReleaseNotes.CheckedChanged += new System.EventHandler(this.boxReleaseNotes_CheckedChanged);
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(215, 55);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 5;
            this.buttonNo.Text = "No";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(296, 55);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Yes";
            // 
            // ReleaseNotesPanel
            // 
            this.ReleaseNotesPanel.Controls.Add(this.ReleaseNotes);
            this.ReleaseNotesPanel.Location = new System.Drawing.Point(-1, 89);
            this.ReleaseNotesPanel.Name = "ReleaseNotesPanel";
            this.ReleaseNotesPanel.Size = new System.Drawing.Size(399, 187);
            this.ReleaseNotesPanel.TabIndex = 6;
            this.ReleaseNotesPanel.Visible = false;
            // 
            // ReleaseNotes
            // 
            this.ReleaseNotes.AllowNavigation = false;
            this.ReleaseNotes.AllowWebBrowserDrop = false;
            this.ReleaseNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleaseNotes.IsWebBrowserContextMenuEnabled = false;
            this.ReleaseNotes.Location = new System.Drawing.Point(0, 0);
            this.ReleaseNotes.MinimumSize = new System.Drawing.Size(20, 20);
            this.ReleaseNotes.Name = "ReleaseNotes";
            this.ReleaseNotes.ScriptErrorsSuppressed = true;
            this.ReleaseNotes.Size = new System.Drawing.Size(399, 187);
            this.ReleaseNotes.TabIndex = 0;
            this.ReleaseNotes.WebBrowserShortcutsEnabled = false;
            // 
            // UpdateNotifyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(374, 277);
            this.ControlBox = false;
            this.Controls.Add(this.ReleaseNotesPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(320, 48);
            this.Name = "UpdateNotifyDialog";
            this.Text = "Update available!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ReleaseNotesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ReleaseNotesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser ReleaseNotes;
        private DevExpress.XtraEditors.SimpleButton buttonNo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckButton boxReleaseNotes;
    }
}