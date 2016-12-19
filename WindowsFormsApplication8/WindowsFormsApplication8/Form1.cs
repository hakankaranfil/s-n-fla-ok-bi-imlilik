using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
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
            for (int i = 0; i < 12; i++)
            {
                TextBox btn = new TextBox();
                btn.Width = 80;
                btn.Height = 80;
                btn.BackColor = rastgelerenkoluştur();
                btn.Left = btn.Width * i;
                btn.Click += TextClick;
                this.Controls.Add(btn);

            }
        }

        private Color rastgelerenkoluştur()
        {
            red = rastgele.Next(0, 256);
            blue = rastgele.Next(0, 256);
            green = rastgele.Next(0, 256);
            Color rastgelerenk = Color.FromArgb(red, green, blue);

            return rastgelerenk;
            
        }

        private void TextClick(object sender,EventArgs e)
        {
            TextBox text = sender as TextBox;
            this.BackColor = text.BackColor;
        }


    }
}
