namespace mesafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = int.Parse(textBox1.Text);
            double x2 = int.Parse(textBox3.Text);
            double y1 = int.Parse(textBox2.Text);
            double y2 = int.Parse(textBox4.Text);
            double a = (x2 - x1) * (x2 - x1);
            double b = (y2 - y1) * (y2 - y1);
            double c = Math.Sqrt(a + b);
            double c1 = Math.Round(c,2);
            label5.Text = "Sonuç = " + c1.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}