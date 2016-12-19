using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uzay_yoluoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int genişlik, uzunluk;

        private void timer1_Tick(object sender, EventArgs e)
        {
            roket2.Left -= 10;
            genişlik = Form1.ActiveForm.Width;

             uzunluk = Form1.ActiveForm.Height;

            if (mekik.Right>=roket2.Left)
            {
                MessageBox.Show("oyunu kaybettin");

            }
            if (roket.Location.X < genişlik - roket.Width)
            {

                roket.Left += 10;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            genişlik = Form1.ActiveForm.Width;
            uzunluk = Form1.ActiveForm.Height;
            switch (e.KeyCode)
            {
               
                case Keys.Left:
                    mekik.Left -= 10;
                    break;

                case Keys.Right:
                    mekik.Left+= 10;
                    break;
                case Keys.Up:
                    mekik.Top -= 10;
                    break;
                case Keys.Down:
                    mekik.Top += 10;
                    break;
                case Keys.Space:
                    int roketx = mekik.Location.X+mekik.Width;
                    int rokety = mekik.Location.Y+mekik.Height/2;
                    roket.Location = new Point(roketx, rokety);
                    roket.Visible = true;
                    
                    break;
                default:
                    break;
            }
            int mekikx = mekik.Location.X;
            int mekiky = mekik.Location.Y;
           
            if (mekikx>=genişlik-mekik.Width || mekikx<=0  ) 
            {
                MessageBox.Show("oyun bitti");
            }
            else if (mekiky>=uzunluk-mekik.Height || mekiky<=0)
            {
                MessageBox.Show("oyun bittti");

            }
        }
    }
}
