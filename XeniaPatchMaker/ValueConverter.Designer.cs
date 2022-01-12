
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
            this.StringValue = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConvertedValue = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.TypeConverter = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.StringValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeConverter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // StringValue
            // 
            this.StringValue.Location = new System.Drawing.Point(105, 12);
            this.StringValue.Name = "StringValue";
            this.StringValue.Size = new System.Drawing.Size(191, 20);
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
            this.ConvertedValue.Size = new System.Drawing.Size(191, 20);
            this.ConvertedValue.TabIndex = 43;
            // 
            // simpleButton2
            // 
            this.simpleButton2.AllowFocus = false;
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton2.Location = new System.Drawing.Point(0, 108);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(308, 23);
            this.simpleButton2.TabIndex = 45;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.AllowFocus = false;
            this.simpleButton7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.simpleButton7.Appearance.Options.UseForeColor = true;
            this.simpleButton7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton7.Location = new System.Drawing.Point(0, 85);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(308, 23);
            this.simpleButton7.TabIndex = 49;
            this.simpleButton7.Text = "Convert";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // TypeConverter
            // 
            this.TypeConverter.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.TypeConverter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TypeConverter.EditValue = "Bytes To Hex";
            this.TypeConverter.Location = new System.Drawing.Point(0, 65);
            this.TypeConverter.Name = "TypeConverter";
            this.TypeConverter.Properties.AllowFocused = false;
            this.TypeConverter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeConverter.Properties.Items.AddRange(new object[] {
            "Bytes To Hex",
            "Double To Hex",
            "Float To Hex",
            "Decimal To Hex"});
            this.TypeConverter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.TypeConverter.Size = new System.Drawing.Size(308, 20);
            this.TypeConverter.TabIndex = 50;
            // 
            // ValueConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 131);
            this.Controls.Add(this.TypeConverter);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertedValue);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.TypeConverter.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit StringValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit ConvertedValue;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.ComboBoxEdit TypeConverter;
    }
}