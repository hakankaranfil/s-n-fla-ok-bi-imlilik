using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int saniye = 0;
        int dakika = 0;
        int tahmin1;
        int yatan;
        
      

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label2.Text = saniye.ToString();
            if (saniye>=60)
            {
                dakika++;
                saniye = 0;
            }
            label1.Text = dakika.ToString();
            int genislik = Form1.ActiveForm.Width;
            birinciat.Left = birinciat.Left + rnd.Next(5, 15);
            //ikinciat.Left = ikinciat.Left + rnd.Next(5, 15);
            //üçüncüat.Left = üçüncüat.Left + rnd.Next(5, 15);
            //dördüncüat.Left = dördüncüat.Left + rnd.Next(5, 15);
            if (birinciat.Left >= genislik - birinciat.Width)
            {
                timer1.Stop();
                MessageBox.Show("yarışı birinci at kazandı");
                tahmin1 = Convert.ToInt32(tahmin.Text);
                yatan = Convert.ToInt32(yatanpara.Text);
                if (tahmin1==1)
                {
                    yatan = yatan * 3;
                    MessageBox.Show("kazancınız:" + yatan);
                }

            }
            else if (ikinciat.Left >= genislik - ikinciat.Width)
            {
                timer1.Stop();
                MessageBox.Show("ikinci at kazandı");

            }
            else if (üçüncüat.Left >= genislik - üçüncüat.Width)
            {
                timer1.Stop();
                MessageBox.Show("üçüncü at kazandı");

            }
            else if (dördüncüat.Left >= genislik - dördüncüat.Width)
            {
                timer1.Stop();
                MessageBox.Show("dördüncü at kazandı");

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}





