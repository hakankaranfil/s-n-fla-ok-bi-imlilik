using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sorusayısı = 0;
        string dogrucvp;
        int dogrusayısı=0;
        int yanlıssayısı = 0;
        int süre = 20;
        int bossayısı = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("oyuna başlamak için ileri tuşuna basınız");
        }

        private void buttonileri_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            buttonileri.Text = "ileri";
            sorusayısı++;

            if (sorusayısı == 1)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Atatürk ün yer aldığı savaşlardan biri değildir ?";
                button1.Text = "çanakkale";
                button2.Text = "büyük taaruz";
                button3.Text = "trablusgarb";
                button4.Text = "ırak";
                dogrucvp = "ırak";

            }
            if (sorusayısı == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi ege bölgesinde yer almaz ?";
                button1.Text = "izmir";
                button2.Text = "aydın";
                button3.Text = "bursa";
                button4.Text = "muğla";
                dogrucvp = "bursa";

            }
            if (sorusayısı == 3)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi euro2016 futbol şampiyonasını düzenleyen ülkedir  ?";
                button1.Text = "italya";
                button2.Text = "fransa";
                button3.Text = "ispanya";
                button4.Text = "portekiz";
                dogrucvp = "fransa";

            }
            if (sorusayısı == 4)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi 2016 altın kelebekte en iyi dizi seçilmiştir ?";
                button1.Text = "diriliş Ertuğrul";
                button2.Text = "karasevda";
                button3.Text = "hayatımın aşkı";
                button4.Text = "kara sevda";
                dogrucvp = "diriliş Ertuğrul";
            }
            if (sorusayısı == 4)
            {
                richTextBox1.Text = "yerel şeçimler kaç yılda bir yapılır ?";
                button1.Text = "1";
                button2.Text = "2";
                button3.Text = "4";
                button4.Text = "5";
                dogrucvp = "5";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelyanıt.Text = button1.Text;
            if (labelyanıt.Text==dogrucvp)
            {
                button1.BackColor = Color.Green;
                dogrusayısı++;
                labeldogrusayı.Text = dogrusayısı.ToString();
                
            }
            else
            {
                button1.BackColor = Color.Red;
                yanlıssayısı++;
                labelyanlıssayısı.Text = yanlıssayısı.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelyanıt.Text = button2.Text;
            if (labelyanıt.Text == dogrucvp)
            {
                button2.BackColor = Color.Green;
                dogrusayısı++;
                labeldogrusayı.Text = dogrusayısı.ToString();

            }
            else
            {
                button2.BackColor = Color.Red;
                yanlıssayısı++;
                labelyanlıssayısı.Text = yanlıssayısı.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelyanıt.Text = button3.Text;
            if (labelyanıt.Text == dogrucvp)
            {
                button3.BackColor = Color.Green;
                dogrusayısı++;
                labeldogrusayı.Text = dogrusayısı.ToString();

            }
            else
            {
                button3.BackColor = Color.Red;
                yanlıssayısı++;
                labelyanlıssayısı.Text = yanlıssayısı.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelyanıt.Text = button4.Text;
            if (labelyanıt.Text == dogrucvp)
            {
                button4.BackColor = Color.Green;
                dogrusayısı++;
                labeldogrusayı.Text = dogrusayısı.ToString();

            }
            else
            {
                button4.BackColor = Color.Red;
                yanlıssayısı++;
                labelyanlıssayısı.Text = yanlıssayısı.ToString();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelsüre.Text = süre.ToString();
            süre--;
            if (süre==0)
            {
                timer1.Stop();
                MessageBox.Show("süreniz doldu diğer soruya geçiniz");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                
                bossayısı++;
                labelbos.Text = bossayısı.ToString();
                
                süre = 20;
            }
        }
    }
}
