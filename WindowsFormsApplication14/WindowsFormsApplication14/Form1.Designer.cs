namespace WindowsFormsApplication14
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
            this.birinciat = new System.Windows.Forms.PictureBox();
            this.ikinciat = new System.Windows.Forms.PictureBox();
            this.üçüncüat = new System.Windows.Forms.PictureBox();
            this.dördüncüat = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tahmin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yatanpara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birinciat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikinciat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.üçüncüat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dördüncüat)).BeginInit();
            this.SuspendLayout();
            // 
            // birinciat
            // 
            this.birinciat.BackColor = System.Drawing.Color.Transparent;
            this.birinciat.Image = ((System.Drawing.Image)(resources.GetObject("birinciat.Image")));
            this.birinciat.Location = new System.Drawing.Point(12, 12);
            this.birinciat.Name = "birinciat";
            this.birinciat.Size = new System.Drawing.Size(105, 55);
            this.birinciat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birinciat.TabIndex = 0;
            this.birinciat.TabStop = false;
            // 
            // ikinciat
            // 
            this.ikinciat.BackColor = System.Drawing.Color.Transparent;
            this.ikinciat.Image = ((System.Drawing.Image)(resources.GetObject("ikinciat.Image")));
            this.ikinciat.Location = new System.Drawing.Point(12, 95);
            this.ikinciat.Name = "ikinciat";
            this.ikinciat.Size = new System.Drawing.Size(105, 55);
            this.ikinciat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ikinciat.TabIndex = 1;
            this.ikinciat.TabStop = false;
            // 
            // üçüncüat
            // 
            this.üçüncüat.BackColor = System.Drawing.Color.Transparent;
            this.üçüncüat.Image = ((System.Drawing.Image)(resources.GetObject("üçüncüat.Image")));
            this.üçüncüat.Location = new System.Drawing.Point(12, 182);
            this.üçüncüat.Name = "üçüncüat";
            this.üçüncüat.Size = new System.Drawing.Size(105, 55);
            this.üçüncüat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.üçüncüat.TabIndex = 2;
            this.üçüncüat.TabStop = false;
            // 
            // dördüncüat
            // 
            this.dördüncüat.BackColor = System.Drawing.Color.Transparent;
            this.dördüncüat.Image = ((System.Drawing.Image)(resources.GetObject("dördüncüat.Image")));
            this.dördüncüat.Location = new System.Drawing.Point(12, 260);
            this.dördüncüat.Name = "dördüncüat";
            this.dördüncüat.Size = new System.Drawing.Size(105, 55);
            this.dördüncüat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dördüncüat.TabIndex = 3;
            this.dördüncüat.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(755, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(871, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(859, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saniye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(743, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "dakika";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(1, 321);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(977, 29);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "tahmin:";
            // 
            // tahmin
            // 
            this.tahmin.Location = new System.Drawing.Point(131, 371);
            this.tahmin.Name = "tahmin";
            this.tahmin.Size = new System.Drawing.Size(100, 22);
            this.tahmin.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "yatırılan para";
            // 
            // yatanpara
            // 
            this.yatanpara.Location = new System.Drawing.Point(135, 433);
            this.yatanpara.Name = "yatanpara";
            this.yatanpara.Size = new System.Drawing.Size(100, 22);
            this.yatanpara.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(969, 477);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yatanpara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tahmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dördüncüat);
            this.Controls.Add(this.üçüncüat);
            this.Controls.Add(this.ikinciat);
            this.Controls.Add(this.birinciat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birinciat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikinciat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.üçüncüat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dördüncüat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox birinciat;
        private System.Windows.Forms.PictureBox ikinciat;
        private System.Windows.Forms.PictureBox üçüncüat;
        private System.Windows.Forms.PictureBox dördüncüat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tahmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yatanpara;
        private System.Windows.Forms.Label label7;
    }
}

