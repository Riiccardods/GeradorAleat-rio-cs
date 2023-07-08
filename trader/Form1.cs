using System;
using System.Drawing;
using System.Windows.Forms;

namespace trader
{
    public partial class Form1 : Form
    {
        int contador1 = 0;
        int contador2 = 0;

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
           
            listBox1.Text = listBox1.Items.Count.ToString();
            string number = lblNumber.Text;
            listBox1.Items.Insert(0,$"-{number}");
        }

       

    private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Text = listBox2.Items.Count.ToString();
            string number = lblNumber.Text;
            listBox2.Items.Insert(0, $"-{number}");
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
            listBox2.Items.Insert(0,lblNumber.Text);
            listBox1.Items.Insert(0,lblNumber.Text);
            string number = "-" + lblNumber.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            contador1 = 0;
            label1.Text = "Contagem: 0";
        }

        private void label1_Click(object sender, EventArgs e)
        {
     

        }
    }
}
