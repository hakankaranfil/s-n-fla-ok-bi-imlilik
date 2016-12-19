using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rasgele = new Random();
            List<int> sayılar = new List<int>();
           
            for (int i = 0; i <sayılar.Count;  i++)
            {
                sayılar[i] = rasgele.Next(5, 100);

                MessageBox.Show(sayılar[i].ToString());
            }
          
        
        }
    }
}
