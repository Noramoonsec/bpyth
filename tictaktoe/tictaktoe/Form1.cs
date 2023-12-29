namespace tictaktoe
{
    public partial class Form1 : Form
    {
        Boolean siraKimde = true;
        public Form1()
        {
            InitializeComponent();
        }
        public void kazananaKontrolu()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label1.Text = "1. Oyuncu kazandý";
            }

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")

            {
                label1.Text = "2. Oyuncu kazandý";
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label1.Text = "1. Oyuncu kazandý";
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")

            {
                label1.Text = "2. Oyuncu kazandý";
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label1.Text = "1. Oyuncu kazandý";
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")

            {
                label1.Text = "2. Oyuncu kazandý";
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label1.Text = "1. Oyuncu kazandý";
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")

            {
                label1.Text = "2. Oyuncu kazandý";
            }
            if (button1.Text == "X" && button4.Text == "X" && button6.Text == "X")
            {
                label1.Text = "1. Oyuncu kazandý";
            }
            if (button1.Text == "O" && button4.Text == "O" && button6.Text == "O")

            {
                label1.Text = "2. Oyuncu kazandý";
            }
            if (button2.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label1.Text = "1. Oyuncu kazandý";
            }
            if (button2.Text == "O" && button5.Text == "O" && button7.Text == "O")

            {
                label1.Text = "2. Oyuncu kazandý";
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label1.Text = "1. Oyuncu kazandý";
            }
            if (button2.Text == "O" && button6.Text == "O" && button9.Text == "O")

            {
                label1.Text = "2. Oyuncu kazandý";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (siraKimde == true)
            {
                button1.Text = "X";
                label1.Text = "sýra 2. oyuncuda";
                siraKimde = false;
            }
            else
            {
                button1.Text = "O";
                label1.Text = "sýra 1. oyuncuda";
                siraKimde = true;
            }
            button1.Enabled = false;
            kazananaKontrolu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (siraKimde == true)
            {
                button2.Text = "X";
                label1.Text = "sýra 2. oyuncuda";
                siraKimde = false;
            }
            else
            {
                button2.Text = "O";
                label1.Text = "sýra 1. oyuncuda";
                siraKimde = true;
            }
            button2.Enabled = false;
            kazananaKontrolu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (siraKimde == true)
            {
                button3.Text = "X";
                label1.Text = "sýra 2. oyuncuda";
                siraKimde = false;
            }
            else
            {
                button3.Text = "O";
                label1.Text = "sýra 1. oyuncuda";
                siraKimde = true;
            }
            button3.Enabled = false;
            kazananaKontrolu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (siraKimde == true)
            {
                button4.Text = "X";
                label1.Text = "sýra 2. oyuncuda";
                siraKimde = false;
            }
            else
            {
                button4.Text = "O";
                label1.Text = "sýra 1. oyuncuda";
                siraKimde = true;
            }
            button4.Enabled = false;
            kazananaKontrolu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (siraKimde == true)
            {
                button5.Text = "X";
                label1.Text = "sýra 2. oyuncuda";
                siraKimde = false;
            }
            else
            {
                button5.Text = "O";
                label1.Text = "sýra 1. oyuncuda";
                siraKimde = true;
            }
            button5.Enabled = false;
            kazananaKontrolu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (siraKimde == true)
            {
                button6.Text = "X";
                label1.Text = "sýra 2. oyuncuda";
                siraKimde = false;
            }
            else
            {
                button6.Text = "O";
                label1.Text = "sýra 1. oyuncuda";
                siraKimde = true;
            }
            button6.Enabled = false;
            kazananaKontrolu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (siraKimde == true)
            {
                button7.Text = "X";
                label1.Text = "sýra 2. oyuncuda";
                siraKimde = false;
            }
            else
            {
                button7.Text = "O";
                label1.Text = "sýra 1. oyuncuda";
                siraKimde = true;
            }
            button7.Enabled = false;
            kazananaKontrolu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (siraKimde == true)
            {
                button8.Text = "X";
                label1.Text = "sýra 2. oyuncuda";
                siraKimde = false;
            }
            else
            {
                button8.Text = "O";
                label1.Text = "sýra 1. oyuncuda";
                siraKimde = true;
            }
            button8.Enabled = false;
            kazananaKontrolu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (siraKimde == true)
            {
                button9.Text = "X";
                label1.Text = "sýra 2. oyuncuda";
                siraKimde = false;
            }
            else
            {
                button9.Text = "O";
                label1.Text = "sýra 1. oyuncuda";
                siraKimde = true;
            }
            button9.Enabled = false;
            kazananaKontrolu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (siraKimde == true || siraKimde == false)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

            }
        }
    }
}