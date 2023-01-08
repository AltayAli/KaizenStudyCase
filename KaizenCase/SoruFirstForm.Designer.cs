namespace KaizenCase
{
    partial class SoruFirstForm
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
            this.codeCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.messageLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codeCountTextBox
            // 
            this.codeCountTextBox.Location = new System.Drawing.Point(161, 11);
            this.codeCountTextBox.Name = "codeCountTextBox";
            this.codeCountTextBox.Size = new System.Drawing.Size(140, 23);
            this.codeCountTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üretilecek Kodların sayısı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(18, 60);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Display.Size = new System.Drawing.Size(423, 259);
            this.Display.TabIndex = 3;
            // 
            // errorLabel
            // 
            this.messageLable.AutoSize = true;
            this.messageLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.messageLable.Location = new System.Drawing.Point(161, 37);
            this.messageLable.Name = "errorLabel";
            this.messageLable.Size = new System.Drawing.Size(0, 15);
            this.messageLable.TabIndex = 4;
            // 
            // SoruFirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 331);
            this.Controls.Add(this.messageLable);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeCountTextBox);
            this.Name = "SoruFirstForm";
            this.Text = "SoruFirstForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox codeCountTextBox;
        private Label label1;
        private Button button1;
        private TextBox Display;
        private Label messageLable;
    }
}