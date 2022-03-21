using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double z = 0;
            double x = Convert.ToDouble(textBoxX.Text);
            double p = Convert.ToDouble(textBoxP.Text);
            int n = Convert.ToInt32(comboBoxN.SelectedIndex.ToString());
            int r = Convert.ToInt32(comboBoxR.SelectedIndex.ToString());
            double a = Convert.ToDouble(textBoxA.Text);

            if (radioButton1.Checked)
            {
                n = n + 2;
                int Znamenatel = 2;
                for (int i = 1; i < n; i++)
                {
                    z += ((Math.Pow(-1, i % 2))*((Math.Pow(p, i - 1) * Math.Pow(x, i)) / Znamenatel));
                    Znamenatel = Znamenatel * (i + 2);
                    
                }
            }
            else
            {
                n = n + 1;
                r = r + 1;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= r; j++)
                    {
                        z += ((Math.Pow(i, 2) + a * Math.Pow(j, 2))/(Math.Pow(i, 3) + Math.Pow(j, 3)));
                    }
                }
            }
            textBoxZ.Text = z.ToString();
        }

        private void comboBoxT_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxN_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxN.Items.Clear();
            comboBoxN.Items.Add(1);
            comboBoxN.Items.Add(2);
            comboBoxN.Items.Add(3);
            comboBoxN.Items.Add(4);
            comboBoxN.Items.Add(5);
            comboBoxN.Items.Add(6);
            comboBoxN.Items.Add(7);
        }
        private void comboBoxR_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxR.Items.Clear();
            comboBoxR.Items.Add(1);
            comboBoxR.Items.Add(2);
            comboBoxR.Items.Add(3);
            comboBoxR.Items.Add(4);
        }
    }
}
