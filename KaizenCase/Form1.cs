namespace KaizenCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void soruFirstBtn_Click(object sender, EventArgs e)
        {
            SoruFirstForm soruFirstForm = new SoruFirstForm();
            soruFirstForm.Show();
        }

        private void soruSecondBtn_Click(object sender, EventArgs e)
        {
            SoruSecondForm soruSecondForm = new SoruSecondForm();
            soruSecondForm.Show();
        }
    }
}