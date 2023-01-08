using KaizenCase.HelperModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaizenCase
{
    public partial class SoruFirstForm : Form
    {
        public SoruFirstForm()
        {
            InitializeComponent();
        }

        private void SoruFirstForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codeCountAsString = codeCountTextBox.Text;

            if (!string.IsNullOrEmpty(codeCountAsString))
            {
                if (int.TryParse(codeCountAsString, out int codeCount))
                {
                    if (codeCount > 0)
                    {
                        PrintCodes(codeCount);
                    }
                    else
                    {
                        PrintCodes();
                    }
                    ClearMessageLabel();
                }
                else
                {
                    ShowMessage("* Bu alana sadece sayı girile bilir.", Color.Red);
                }
            }
            else
            {
                PrintCodes();
                ShowMessage("* Varsayilan değer 1 olarak ayarlandı.", Color.Orange);
            }
        }

        private void PrintCodes(int codeCount=1)
        {
            CodeGenerator codeGenerator = new CodeGenerator(codeCount);
            foreach (string code in codeGenerator.Generate())
            {
                Display.AppendText(code);
                Display.AppendText(Environment.NewLine);
            }
        }
        private void ShowMessage(string message, Color color)
        {
            messageLable.Text = message;
            messageLable.ForeColor = color;
        }
        private void ClearMessageLabel()
        {
            messageLable.Text = string.Empty;
        }
    }
}
