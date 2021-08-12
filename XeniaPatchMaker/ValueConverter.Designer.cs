
namespace XeniaPatchMaker
{
    partial class ValueConverter
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
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.StringValue = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ConvertedValue = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.StringValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton6
            // 
            this.simpleButton6.AllowFocus = false;
            this.simpleButton6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.simpleButton6.Appearance.Options.UseForeColor = true;
            this.simpleButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton6.Location = new System.Drawing.Point(0, 112);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(350, 23);
            this.simpleButton6.TabIndex = 40;
            this.simpleButton6.Text = "Decimal To Hex";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // StringValue
            // 
            this.StringValue.Location = new System.Drawing.Point(105, 12);
            this.StringValue.Name = "StringValue";
            this.StringValue.Size = new System.Drawing.Size(233, 20);
            this.StringValue.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(11, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "String Value:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton1.Location = new System.Drawing.Point(0, 89);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(350, 23);
            this.simpleButton1.TabIndex = 42;
            this.simpleButton1.Text = "Float To Hex";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Converted Value:";
            // 
            // ConvertedValue
            // 
            this.ConvertedValue.Location = new System.Drawing.Point(105, 38);
            this.ConvertedValue.Name = "ConvertedValue";
            this.ConvertedValue.Size = new System.Drawing.Size(233, 20);
            this.ConvertedValue.TabIndex = 43;
            this.ConvertedValue.EditValueChanged += new System.EventHandler(this.ConvertedValue_EditValueChanged);
            this.ConvertedValue.TextChanged += new System.EventHandler(this.ConvertedValue_TextChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.AllowFocus = false;
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton2.Location = new System.Drawing.Point(0, 135);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(350, 23);
            this.simpleButton2.TabIndex = 45;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.AllowFocus = false;
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton3.Location = new System.Drawing.Point(0, 66);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(350, 23);
            this.simpleButton3.TabIndex = 46;
            this.simpleButton3.Text = "Double To Hex";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // ValueConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 158);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertedValue);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.StringValue);
            this.Controls.Add(this.simpleButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValueConverter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Value Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ValueConverter_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StringValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.TextEdit StringValue;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit ConvertedValue;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}