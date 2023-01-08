namespace KaizenCase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.soruFirstBtn = new System.Windows.Forms.Button();
            this.soruSecondBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // soruFirstBtn
            // 
            this.soruFirstBtn.Location = new System.Drawing.Point(67, 58);
            this.soruFirstBtn.Name = "soruFirstBtn";
            this.soruFirstBtn.Size = new System.Drawing.Size(132, 51);
            this.soruFirstBtn.TabIndex = 0;
            this.soruFirstBtn.Text = "Soru 1";
            this.soruFirstBtn.UseVisualStyleBackColor = true;
            this.soruFirstBtn.Click += new System.EventHandler(this.soruFirstBtn_Click);
            // 
            // soruSecondBtn
            // 
            this.soruSecondBtn.Location = new System.Drawing.Point(260, 58);
            this.soruSecondBtn.Name = "soruSecondBtn";
            this.soruSecondBtn.Size = new System.Drawing.Size(132, 51);
            this.soruSecondBtn.TabIndex = 1;
            this.soruSecondBtn.Text = "Soru 2";
            this.soruSecondBtn.UseVisualStyleBackColor = true;
            this.soruSecondBtn.Click += new System.EventHandler(this.soruSecondBtn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 186);
            this.Controls.Add(this.soruSecondBtn);
            this.Controls.Add(this.soruFirstBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button soruFirstBtn;
        private Button soruSecondBtn;
        private FileSystemWatcher fileSystemWatcher1;
    }
}