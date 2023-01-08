using KaizenCase.HelperModels;
using KaizenCase.Models;
using Newtonsoft.Json;
using System.Text;

namespace KaizenCase
{
    public partial class SoruSecondForm : Form
    {
        public SoruSecondForm()
        {
            InitializeComponent();
        }

        private void YazdirBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            OpenFileDialog fo = new();
            OCRHelper ocrHelper = new();
            fo.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            fo.ShowDialog();
            if (File.Exists(fo.FileName))
            {
                using StreamReader reader = new(fo.FileName, Encoding.UTF8);
                string result = reader.ReadToEnd();
                if (!string.IsNullOrEmpty(result))
                {
                    Dictionary<int, string> dic = ocrHelper.GetResponseDictionary(result);
                    foreach (var item in dic)
                    {
                        richTextBox1.AppendText(item.Value);
                        richTextBox1.AppendText(Environment.NewLine);
                    }
                    saveBtn.Show();
                }

            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "response";
            saveFileDialog1.ShowDialog();
            if (!File.Exists(saveFileDialog1.FileName))
                File.Create(saveFileDialog1.FileName).Close();

            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);

        }
    }
}
