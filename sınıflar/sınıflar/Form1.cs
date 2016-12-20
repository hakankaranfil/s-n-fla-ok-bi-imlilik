using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ögrenci ögr1 = new ögrenci();
        ögrenci ögr2 = new ögrenci();

        private void Form1_Load(object sender, EventArgs e)
        {
            ögr1.adsoyad = "hakan karanfil";
            ögr2.adsoyad = "emre karafil";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("isim" + ögr1.adsoyad);
            MessageBox.Show("isim" + ögr2.adsoyad);
        }
    }
}
