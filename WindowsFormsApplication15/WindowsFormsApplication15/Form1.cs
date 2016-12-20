using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<müsteri> müsteriabone = new List<müsteri>();
        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            müsteri müsterikayıt1 = new müsteri();
            müsteri müsterikayıt2 = new müsteri();
            int ilkkullanım = Convert.ToInt32(textBoxilk.Text);
            int sonkullanım = Convert.ToInt32(textBoxson.Text);
            müsterikayıt1.adsoyad = textBoxad.Text;
            if (radioev.Checked)
            {
                müsterikayıt1.ödeme =  (sonkullanım-ilkkullanım) * 0.3;
            }
            else
            {
                müsterikayıt1.ödeme = müsterikayıt1.ödeme = (sonkullanım-ilkkullanım) * 0.5;

            }
           
        
          

            //müsterikayıt2.adsoyad = textBoxad.Text;
            //müsterikayıt2.ev = radioev.Checked;
            //müsterikayıt2.şirket = radiosirket.Checked;
            müsteriabone.Add(müsterikayıt1);
            listBox1.Items.Add(müsterikayıt1);

            //müsteriabone.Addü(müs)



        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "ödeme yapmak istiyor musunuz?", "Onay Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[i]);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }

                if (result == DialogResult.No)
                {

                }


            }
        }
    }
}
