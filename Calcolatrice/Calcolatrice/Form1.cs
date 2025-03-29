namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbl.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbl.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbl.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lbl.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lbl.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lbl.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lbl.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lbl.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lbl.Text += "0";
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            lbl.Text += "+";
        }

        private void btnm_Click(object sender, EventArgs e)
        {
            lbl.Text += "-";
        }

        private void btnmol_Click(object sender, EventArgs e)
        {
            lbl.Text += "*";
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            lbl.Text += "/";
        }

        private void btnu_Click(object sender, EventArgs e)
        {
            float somma = 0;
            if (lbl.Text.Contains("+"))
            {
                string[] numeri=lbl.Text.Split('+');
                for (int i = 0; i < numeri.Length; i++)
                {
                    somma += float.Parse(numeri[i]);
                }
                lbl.Text = somma.ToString();
            }
            else if (lbl.Text.Contains("-"))
            {
                string[] numeri = lbl.Text.Split('-');
                for (int i = 0; i < numeri.Length; i++)
                {
                    somma -= float.Parse(numeri[i]);
                }
                lbl.Text = somma.ToString();
            }
            else if (lbl.Text.Contains("*"))
            {
                
                string[] numeri = lbl.Text.Split('*');
                somma = float.Parse(numeri[0]);
                for (int i = 1; i < numeri.Length; i++)
                {
                    somma *= float.Parse(numeri[i]);
                }
                
                lbl.Text = somma.ToString();
            }
            else if (lbl.Text.Contains("/"))
            {
                string[] numeri = lbl.Text.Split('/');
                somma = float.Parse(numeri[0]);
                for (int i = 1; i < numeri.Length; i++)
                {
                    somma /= float.Parse(numeri[i]);
                }
                lbl.Text = somma.ToString();
            }
            else
            {
                lbl.Text = "NON HAI INSERITO OPERATORI";
            }

        }
    }
}
