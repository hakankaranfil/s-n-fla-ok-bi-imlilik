using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        char z;
        int sonuç = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {


            Button hesap = sender as Button;
            textBox1.Text = textBox1.Text + hesap.Text;
            List<int> sayılar = new List<int>();
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                sayılar.Add(i);
            }

            foreach (var item in sayılar)
            {
                if (z=='+')
                {
                    sonuç = sonuç + item;
                }
            }
            MessageBox.Show(sonuç.ToString());
        }
    }
}


       
