using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char d;
        int a;

        private void buttonClick(object sender, EventArgs e)
        {
            Button hesap = sender as Button;
            textBox1.Text += hesap.Text;

            
           
            

        }

        private void islemClick(object sender, EventArgs e)
        {
            Button islem = sender as Button;
            textBox1.Text = islem.Text;
           
            var sonuc = textBox1.Text;
            if (d=='+')
            {
                a = Convert.ToInt32 (textBox1.Text + sonuc);
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(a.ToString());
        }
    }
        }
