namespace Barcode
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbc = new System.Windows.Forms.PictureBox();
            this.cbox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbc)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCon
            // 
            this.tbCon.Location = new System.Drawing.Point(24, 41);
            this.tbCon.Multiline = true;
            this.tbCon.Name = "tbCon";
            this.tbCon.Size = new System.Drawing.Size(388, 111);
            this.tbCon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Content";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Label Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(102, 166);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(199, 20);
            this.cbType.TabIndex = 5;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(176, 248);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 10;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picbc);
            this.panel1.Location = new System.Drawing.Point(24, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 160);
            this.panel1.TabIndex = 11;
            // 
            // picbc
            // 
            this.picbc.Location = new System.Drawing.Point(146, 31);
            this.picbc.Name = "picbc";
            this.picbc.Size = new System.Drawing.Size(100, 98);
            this.picbc.TabIndex = 0;
            this.picbc.TabStop = false;
            // 
            // cbox
            // 
            this.cbox.AutoSize = true;
            this.cbox.Location = new System.Drawing.Point(26, 208);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(103, 16);
            this.cbox.TabIndex = 12;
            this.cbox.Text = "Show Label Text";
            this.cbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 479);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picbc;
        private System.Windows.Forms.CheckBox cbox;
    }
}

