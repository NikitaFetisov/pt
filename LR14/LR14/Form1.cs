using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR14
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        double x;
        double y;
        double z;
        double Ans;
        string Ans2;

        //2 задание

        Vibor dtFormat = Vibor.Vtoroe;
        ToolStripMenuItem currentCheckeditem;
        public Form1()
        {
            InitializeComponent();
            Text = "Лабораторная работа 14 Фетисов";
            CenterToScreen();
            currentCheckeditem = Vtoroy;
            currentCheckeditem.Checked = false;
        }

        public enum Vibor
        {
            Pervoe,
            Vtoroe
        }

        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            if (dtFormat == Vibor.Pervoe)
            {
                Ans2 = Convert.ToString((Math.Pow(x, 2) + Math.Pow(y, 3))/ Math.Abs(Math.Pow(y,3) -x));
            }else
            {
                x = Math.Pow(x, 2);
                y = Math.Pow(y, 2);
                Ans2 = Convert.ToString(string.Format("квадраты координат: X = {0} Y = {1}", x, y));
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Answer2.Text = string.Format("Ответ: {0}", Ans2);
        }

        private void Pervii_Click(object sender, EventArgs e)
        {
            // Утсановка даты 
            currentCheckeditem.Checked = false;
            dtFormat = Vibor.Pervoe;
            currentCheckeditem = Pervii;
            currentCheckeditem.Checked = true;
        }

        private void Vtoroy_Click(object sender, EventArgs e)
        {
            currentCheckeditem.Checked = false;
            dtFormat = Vibor.Vtoroe;
            currentCheckeditem = Vtoroy;
            currentCheckeditem.Checked = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxA.SelectedIndex = 0;
            aToolStripMenuItem.SelectedIndex = 0;
        }

        //2 задание

        //1 задание

        private void aToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ComboBoxA_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxA.Text)
            {
                case "1":; a = 1; break;
                case "2":; a = 2; break;
                case "3":; a = 3; break;
                case "4":; a = 4; break;
                case "5":; a = 5; break;

                default: BackColor = SystemColors.Control; break;
            }
        }
        private void ComboBoxB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxB.Text)
            {
                case "1":; b = 1; break;
                case "2":; b = 2; break;
                case "3":; b = 3; break;
                case "4":; b = 4; break;
                case "5":; b = 5; break;

                default: BackColor = SystemColors.Control; break;
            }
        }

        private void TextBoxY_TextChanged(object sender, EventArgs e)
        {
            y = Convert.ToInt32(TextBoxY.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TextBoxX_TextChanged(object sender, EventArgs e)
        {
            x = Convert.ToInt32(TextBoxX.Text);
        }

        private void TextBoxZ_TextChanged(object sender, EventArgs e)
        {
            z = Convert.ToInt32(TextBoxZ.Text);
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            Ans = (a*(x/y)+b*(y/z)+Math.Sin(z/x));
            this.Text = string.Format("Ответ: {0}", Ans);
        }

        //1 задание

    }
}
