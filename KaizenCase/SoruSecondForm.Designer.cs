namespace KaizenCase
{
    partial class SoruSecondForm
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
            this.Btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(12, 12);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(111, 23);
            this.Btn.TabIndex = 7;
            this.Btn.Text = "Dosya seç";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.YazdirBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(492, 561);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(393, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(111, 23);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SoruSecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 615);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btn);
            this.Name = "SoruSecondForm";
            this.Text = "SoruSecondForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Button Btn;
        private RichTextBox richTextBox1;
        private Button saveBtn;
    }
}