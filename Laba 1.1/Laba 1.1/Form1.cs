using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Laba_1._1
{
    public partial class Form1 : Form
    {
        string V;
        double H;
        double E;
        double Q;
        double A;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TextBox3_MouseMove(object sender, MouseEventArgs e) 
        {
            
            textBox3.Clear();
            textBox8.Clear();
            textBox8.AppendText(textBox3.Text = (e.X).ToString());
            textBox9.Clear();
            textBox9.AppendText(textBox3.Text = (e.Y).ToString());
            textBox3.Clear();
            if (((Q + A) <= 0))
            {
                Text = string.Format("Фетисов ЛР1 Вариант 6 Ответ: ERROR");
            }
            else
            {
                double V = ((H - E) / (Q + A)) + Math.Abs(Math.Sin(e.X) + Math.Sqrt(Math.Abs(Math.Sin(e.Y))));
                Text = string.Format("Фетисов ЛР1 Вариант 6 Ответ: {0}", V);
            }
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            int Q = Convert.ToInt32(Console.ReadLine());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            H = Convert.ToDouble(textBox4.Text);
            E = Convert.ToDouble(textBox5.Text);
            Q = Convert.ToDouble(textBox6.Text);
            A = Convert.ToDouble(textBox7.Text);
            
        }
    }
}
