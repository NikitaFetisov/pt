using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR15
{
    public partial class Form1 : Form
    {
        double x;
        int n;
        double Ans = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = panelChooseColor.BackColor;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                panelChooseColor.BackColor = dlg.Color;

                textBoxAns.BackColor = dlg.Color;
            }
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;
            dlg.Font = txtChooseFont.Font;
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFont.Font = dlg.Font;
                txtChooseFont.ForeColor = dlg.Color;

                textBoxAns.Font = dlg.Font;
                textBoxAns.ForeColor = dlg.Color;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "txt files (*.txt)| *.txt|" + "Сборки (*.exe)| *.exe";
            dlg.FilterIndex = 3;
            dlg.Title = "Выбор моего файла";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFile.Text = dlg.FileName;
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Выберите папку для демонстрации работы диалога";
            dlg.ShowNewFolderButton = true;
            dlg.SelectedPath = Application.StartupPath;
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFolder.Text = dlg.SelectedPath;
            }
        }

        private void buttonAns_Click(object sender, EventArgs e)
        {

            x = Convert.ToDouble(textBoxX.Text);
            n = Convert.ToInt32(textBoxN.Text);

            for (int i = 2; i <= n; i++){
                if ( i % 2 == 0) 
                {
                    Ans -= (Math.Sin(Math.Pow(x, i))/i);
                }
                else
                {
                    Ans += (Math.Cos(Math.Pow(x, i)) / i);
                }
            }

            textBoxAns.Text = Convert.ToString(Ans);
            Ans = 1;
        }
    }
}
