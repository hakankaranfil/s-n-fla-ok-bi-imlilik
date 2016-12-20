using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıflar_otobüs_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<musteri> musterilistesi = new List<musteri>();
        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            musteri müsteri1 = new musteri();
            müsteri1.adsoyad = textBoxad.Text;
            müsteri1.cinsiyet = radioerkek.Checked == false ? true : false;
            müsteri1.otobüstürü = cboxotobüstürü.SelectedItem.ToString();
            musterilistesi.Add(müsteri1);
            listBoxmüsteriler.Items.Add(müsteri1);
            textBoxad.Clear();
        }
    }
}
