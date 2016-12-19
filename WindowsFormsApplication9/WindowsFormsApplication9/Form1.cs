using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random sayıüret = new Random();
        int sayı;

        private void rakam()
        {
            sayı = sayıüret.Next(0, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <10; i++)
            {
                Button btn = new Button();
                btn.Height = 30;
                btn.Width = 30;
                
                btn.Left = btn.Width * i;
                this.Controls.Add(btn);

            }
        }
    }
}
