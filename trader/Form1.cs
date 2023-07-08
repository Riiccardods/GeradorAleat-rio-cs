using System;
using System.Drawing;
using System.Windows.Forms;

namespace trader
{
    public partial class Form1 : Form
    {
        int contador1 = 0;
        int contadorWin = 0;
        int contadorLoss = 0;

        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNumber.Text = "0";  // Inicia o lblNumber com o valor "0"
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Verifica o número atual e muda para o outro número
            lblNumber.Text = lblNumber.Text == "0" ? "1" : "0";
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            contador1++;
            label1.Text = "Contagem: " + contador1;

            string number = lblNumber.Text;

            if (number == "0")
            {
                listBox1.Items.Insert(0, "LOSS");
                contadorLoss++;
            }
            else if (number == "1")
            {
                listBox1.Items.Insert(0, "WIN");
                contadorWin++;
            }

            labelWinCount.Text = "Wins: " + contadorWin;
            labelLossCount.Text = "Losses: " + contadorLoss;
        }

       

    private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string number = lblNumber.Text;

            if (number == "0")
            {
                listBox2.Items.Insert(0, "LOSS");
                contadorLoss++;
            }
            else if (number == "1")
            {
                listBox2.Items.Insert(0, "WIN");
                contadorWin++;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contador1++;
            label1.Text = "Contagem: " + contador1;

            string number = lblNumber.Text;

            if (number == "0")
            {
                listBox1.Items.Insert(0, "LOSS");
                listBox2.Items.Insert(0, "LOSS");
                contadorLoss++;
            }
            else if (number == "1")
            {
                listBox1.Items.Insert(0, "WIN");
                listBox2.Items.Insert(0, "WIN");
                contadorWin++;
            }

            labelWinCount.Text = "Wins: " + contadorWin;
            labelLossCount.Text = "Losses: " + contadorLoss;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            contador1 = 0;
            contadorWin = 0;
            contadorLoss = 0;
            label1.Text = "Contagem: 0";
            labelWinCount.Text = "Contagem: 0";
            labelLossCount.Text = "Contagem: 0";
        }

        private void label1_Click(object sender, EventArgs e)
        {
     

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            contador1++;
            label1.Text = "Contagem: " + contador1;

            string number = lblNumber.Text;

            if (number == "1")
            {
                listBox1.Items.Insert(0, "LOSS");
                contadorLoss++;
            }
            else if (number == "0")
            {
                listBox1.Items.Insert(0, "WIN");
                contadorWin++;
            }

            labelWinCount.Text = "Wins: " + contadorWin;
            labelLossCount.Text = "Losses: " + contadorLoss;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string number = lblNumber.Text;

            if (number == "1")
            {
                listBox2.Items.Insert(0, "LOSS");
                contadorLoss++;
            }
            else if (number == "0")
            {
                listBox2.Items.Insert(0, "WIN");
                contadorWin++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string number = lblNumber.Text;

            if (number == "0")
            {
                listBox3.Items.Insert(0, "LOSS");
                contadorLoss++;
            }
            else if (number == "1")
            {
                listBox3.Items.Insert(0, "WIN");
                contadorWin++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string number = lblNumber.Text;

            if (number == "1")
            {
                listBox3.Items.Insert(0, "LOSS");
                contadorLoss++;
            }
            else if (number == "0")
            {
                listBox3.Items.Insert(0, "WIN");
                contadorWin++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string number = lblNumber.Text;

            if (number == "0")
            {
                listBox2.Items.Insert(0, "LOSS");
                listBox3.Items.Insert(0, "LOSS");
                contadorLoss++;
            }
            else if (number == "1")
            {
                listBox2.Items.Insert(0, "WIN");
                listBox3.Items.Insert(0, "WIN");
                contadorWin++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string number = lblNumber.Text;

            if (number == "0")
            {
                listBox2.Items.Insert(0, "LOSS");
                listBox3.Items.Insert(0, "WIN");
                contadorLoss++;
            }
            else if (number == "1")
            {
                listBox2.Items.Insert(0, "WIN");
                listBox3.Items.Insert(0, "LOSS");
                contadorWin++;
            }
        }
    }
}
