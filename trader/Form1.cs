using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace trader
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        int contador1 = 0;
        int contadorWin = 0;
        int contadorLoss = 0;
        int contadorExtra = 0;
        int sequenciaLoss = 0;
        int sequenciawin = 0;
        double saldo = 0.0;

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1;  // Intervalo de 1 segundo
            timer.Tick += Timer1_TickEvent;  // Evento que será acionado a cada intervalo de tempo
            timer.Start();  // Inicia o temporizador
        }

        private int numberCounter = 0;

        private void Timer1_TickEvent(object sender, EventArgs e)
        {
            numberCounter = (numberCounter == 0) ? 1 : 0;  // Alterna entre 0 e 1

            lblNumber.Text = numberCounter.ToString();
        }


        private bool saldoCongelado = false;

        private void btnCapture_Click(object sender, EventArgs e)
        {

            string number = lblNumber.Text;

            if (saldoCongelado) // Verificar se o saldo está congelado
            {

                return; // Interromper a atualização do saldo
            }

            if (number == "0")
            {
                listBox1.Items.Insert(0, "LOSS");
                contadorLoss++;
                
                sequenciaLoss++;
                sequenciawin = 0; // Redefinir a sequência de "LOSS"


                if (sequenciaLoss == 9) // Verificar se a sequência de "LOSS" atingiu 10
                {

                    saldoCongelado = true; // Congelar o saldo
                }
                
            }
            else
            {
                listBox1.Items.Insert(0, "WIN");
                contadorWin++;
               
                sequenciawin++;
                sequenciaLoss = 0; // Redefinir a sequência de "LOSS"

                if (sequenciawin == 9) // Verificar se a sequência de "win" atingiu 10
                {

                    saldoCongelado = true; // Congelar o saldo
                }
            }

            contador1++;
            label1.Text = "Contagem: " + contador1;

            labelWinCount.Text = "Wins: " + contadorWin;
            labelLossCount.Text = "Losses: " + contadorLoss;
            lblSaldo.Text = "Saldo: " + saldo.ToString("0.00"); // Atualizar o rótulo do saldo
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
            string number = lblNumber.Text;

            if (saldoCongelado) // Verificar se o saldo está congelado
            {

                return; // Interromper a atualização do saldo
            }

            if (number == "0")
            {
                listBox1.Items.Insert(0, "LOSS");
                listBox2.Items.Insert(0, "LOSS");
                contadorLoss++;
                
                sequenciaLoss++;
                sequenciawin++;

                if (sequenciaLoss == 11) // Verificar se a sequência de "LOSS" atingiu 10
                {

                    saldoCongelado = true; // Congelar o saldo
                }
                if (sequenciawin == 11) // Verificar se a sequência de "win" atingiu 10
                {

                    saldoCongelado = true; // Congelar o saldo
                }
            }
            else
            {
                listBox1.Items.Insert(0, "WIN");
                listBox2.Items.Insert(0, "WIN");
                contadorWin++;
               
                sequenciaLoss = 0; // Redefinir a sequência de "LOSS"
                sequenciawin = 0; // Redefinir a sequência de "LOSS"
            }

            contador1++;
            label1.Text = "Contagem: " + contador1;

            labelWinCount.Text = "Wins: " + contadorWin;
            labelLossCount.Text = "Losses: " + contadorLoss;
            lblSaldo.Text = "Saldo: " + saldo.ToString("0.00"); // Atualizar o rótulo do saldo
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saldoCongelado = false; // Congelar o saldo
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            contador1 = 0;
            contadorWin = 0;
            contadorLoss = 0;
            label1.Text = "Contagem: 0";
            labelWinCount.Text = "Contagem: 0";
            labelLossCount.Text = "Contagem: 0";
            lblSaldo.Text = "0";
            saldo = 0;
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


        private void button8_Click(object sender, EventArgs e)
        {

            string number = lblNumber.Text;

            if (number == "0")
            {
                listBox2.Items.Insert(0, "LOSS");
                contadorWin++;
            }
            else if (number == "1")
            {
                listBox2.Items.Insert(0, "WIN");
                contadorLoss++;
                contadorExtra++;
            }

            labelWinCount.Text = "Wins: " + contadorWin;
            labelLossCount.Text = "Losses: " + contadorLoss;



        }

        private void button9_Click(object sender, EventArgs e)
        {
            string number = lblNumber.Text;

            if (number == "0")
            {
                listBox2.Items.Insert(0, "LOSS");
                contadorLoss++;
                contadorExtra++;
            }
            
            else if (number == "1")
            {
                listBox2.Items.Insert(0, "WIN");
                contadorWin++;
            }

        }

        private void labelLossCount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string number = lblNumber.Text;

            if (saldoCongelado) // Verificar se o saldo está congelado
            {

                return; // Interromper a atualização do saldo
            }

            if (number == "0")
            {
                listBox2.Items.Insert(0, "LOSS");
                contadorLoss++;
                saldo -= 1.00; // Subtrair 1.00 do saldo
                sequenciaLoss++;
                sequenciawin = 0; // Redefinir a sequência de "LOSS"


                if (sequenciaLoss == 5) // Verificar se a sequência de "LOSS" atingiu 10
                {

                    saldoCongelado = true; // Congelar o saldo
                }

            }
            else
            {
                listBox2.Items.Insert(0, "WIN");
                contadorWin++;
                saldo += 0.95; // Adicionar 0.95 ao saldo
                sequenciawin++;
                sequenciaLoss = 0; // Redefinir a sequência de "LOSS"

                if (sequenciawin == 5) // Verificar se a sequência de "win" atingiu 10
                {

                    saldoCongelado = true; // Congelar o saldo
                }
            }
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            saldoCongelado = false; // Congelar o saldo
            contador1 = 0;
            label1.Text = "Contagem: 0";
        }

        private bool button2Clicking = false;
        private int button2ClickCounter = 0;

        private void button2AutoClick_Click(object sender, EventArgs e)
        {
            int totalClicks = 100;
            int delayMilliseconds = 50;

            if (!button2Clicking)
            {
                button2Clicking = true;

                for (int i = 0; i < totalClicks; i++)
                {
                    button2_Click(sender, e);
                    button2ClickCounter++;

                    if (button2ClickCounter >= totalClicks)
                    {
                        button2ClickCounter = 0;
                        button2Clicking = false;
                        break;
                    }

                    Thread.Sleep(delayMilliseconds);
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            string number = lblNumber.Text;

            if (saldoCongelado) // Verificar se o saldo está congelado
            {

                return; // Interromper a atualização do saldo
            }

            if (number == "0")
            {
                listBox3.Items.Insert(0, "LOSS");
                contadorLoss++;
                saldo -= 1.00; // Subtrair 1.00 do saldo
                sequenciaLoss++;
                sequenciawin = 0; // Redefinir a sequência de "LOSS"


                if (sequenciaLoss == 9) // Verificar se a sequência de "LOSS" atingiu 10
                {

                    saldoCongelado = true; // Congelar o saldo
                }

            }
            else
            {
                listBox3.Items.Insert(0, "WIN");
                contadorWin++;
                saldo += 0.95; // Adicionar 0.95 ao saldo
                sequenciawin++;
                sequenciaLoss = 0; // Redefinir a sequência de "LOSS"

                if (sequenciawin == 9) // Verificar se a sequência de "win" atingiu 10
                {

                    saldoCongelado = true; // Congelar o saldo
                }
            }

            contador1++;
            label1.Text = "Contagem: " + contador1;

            labelWinCount.Text = "Wins: " + contadorWin;
            labelLossCount.Text = "Losses: " + contadorLoss;
            lblSaldo.Text = "Saldo: " + saldo.ToString("0.00"); // Atualizar o rótulo do saldo
        }
    



    private void button7_Click(object sender, EventArgs e)
        {
            string number = lblNumber.Text;

            if (saldoCongelado) // Verificar se o saldo está congelado
            {

                return; // Interromper a atualização do saldo
            }

            if (number == "0")
            {
                listBox1.Items.Insert(0, "LOSS");
                listBox2.Items.Insert(0, "LOSS");
                listBox3.Items.Insert(0, "LOSS");
                contadorLoss++;
                saldo -= 0.95; // Adicionar 0.95 ao saldo
                sequenciaLoss++;
                sequenciawin = 0; // Redefinir a sequência de "LOSS"

                if (sequenciaLoss == 10) // Verificar se a sequência de "LOSS" atingiu 10
                {

                    saldoCongelado = true; // Congelar o saldo
                }

            }
            else
            {
                listBox1.Items.Insert(0, "WIN");
                listBox2.Items.Insert(0, "WIN");
                listBox3.Items.Insert(0, "WIN");
                contadorWin++;
                saldo += 1.00; // Adicionar 0.95 ao saldo
                sequenciawin++;
                sequenciaLoss = 0; // Redefinir a sequência de "LOSS"

                if (sequenciawin == 10) // Verificar se a sequência de "win" atingiu 10
                {

                    saldoCongelado = true; // Congelar o saldo
                }
            }

            contador1++;
            label1.Text = "Contagem: " + contador1;

            labelWinCount.Text = "Wins: " + contadorWin;
            labelLossCount.Text = "Losses: " + contadorLoss;
            lblSaldo.Text = "Saldo: " + saldo.ToString("0.00"); // Atualizar o rótulo do saldo
        }
    }
}


