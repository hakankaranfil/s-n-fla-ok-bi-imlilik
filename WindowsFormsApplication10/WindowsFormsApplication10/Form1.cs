using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int red, blue, green;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Height = 30;
                btn.Width = 30;
                btn.Left = btn.Width * i;
                btn.BackColor = renkoluştur();
                btn.Click += buttonclick;

                this.Controls.Add(btn);
            }
        }

        private Color renkoluştur()
        {
            red = rastgele.Next(0, 256);
            blue = rastgele.Next(0, 256);
            green = rastgele.Next(0, 256);
            Color rastgelerenk = Color.FromArgb(red, blue, green);
            return rastgelerenk;
        }
        private void buttonclick(object sender, EventArgs e)
        {
            Button secilenbtn = sender as Button;
            this.BackColor = secilenbtn.BackColor;
        }
    }
}
