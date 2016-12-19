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
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("oyuna başlamak için ileri tuşuna basınız");
        }

        private void buttonileri_Click(object sender, EventArgs e)
        {
            sorusayısı++;
            if (sorusayısı==1)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Atatürk ün yer aldığı savaşlardan biri değildir ?";
                button1.Text = "çanakkale";
                button2.Text = "büyük taaruz";
                button3.Text = "trablusgarb";
                button4.Text = "ırak";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelyanıt.Text = button1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelyanıt.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelyanıt.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelyanıt.Text = button4.Text;
        }
    }
}
