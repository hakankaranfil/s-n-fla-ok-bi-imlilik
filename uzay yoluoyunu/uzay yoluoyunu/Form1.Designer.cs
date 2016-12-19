namespace uzay_yoluoyunu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mekik = new System.Windows.Forms.PictureBox();
            this.roket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.roket2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mekik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roket2)).BeginInit();
            this.SuspendLayout();
            // 
            // mekik
            // 
            this.mekik.BackColor = System.Drawing.Color.Transparent;
            this.mekik.Image = ((System.Drawing.Image)(resources.GetObject("mekik.Image")));
            this.mekik.Location = new System.Drawing.Point(12, 53);
            this.mekik.Name = "mekik";
            this.mekik.Size = new System.Drawing.Size(126, 67);
            this.mekik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mekik.TabIndex = 0;
            this.mekik.TabStop = false;
            // 
            // roket
            // 
            this.roket.BackColor = System.Drawing.Color.Transparent;
            this.roket.Image = ((System.Drawing.Image)(resources.GetObject("roket.Image")));
            this.roket.Location = new System.Drawing.Point(144, 53);
            this.roket.Name = "roket";
            this.roket.Size = new System.Drawing.Size(32, 32);
            this.roket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roket.TabIndex = 1;
            this.roket.TabStop = false;
            this.roket.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // roket2
            // 
            this.roket2.BackColor = System.Drawing.Color.Transparent;
            this.roket2.Image = ((System.Drawing.Image)(resources.GetObject("roket2.Image")));
            this.roket2.Location = new System.Drawing.Point(889, 53);
            this.roket2.Name = "roket2";
            this.roket2.Size = new System.Drawing.Size(123, 63);
            this.roket2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roket2.TabIndex = 2;
            this.roket2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 479);
            this.Controls.Add(this.roket2);
            this.Controls.Add(this.roket);
            this.Controls.Add(this.mekik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mekik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roket2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mekik;
        private System.Windows.Forms.PictureBox roket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox roket2;
    }
}

