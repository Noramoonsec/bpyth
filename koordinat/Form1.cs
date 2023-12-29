using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koordinat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = int.Parse(richTextBox1.Text);
            double x2 = int.Parse(richTextBox2.Text);
            double y1 = int.Parse(richTextBox3.Text);
            double y2 = int.Parse(richTextBox4.Text);
            double m = (y1 - y2) /(x1 - x2);
            double c =y1 - x1;
            label6.Text =  "y=" + m.ToString() + "x" + c.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
