﻿namespace bilgi_yarışması
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeldogru = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelyanıt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labeldogrusayı = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelyanlıssayısı = new System.Windows.Forms.Label();
            this.buttonileri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-1, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(700, 245);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(732, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doğru cevap:";
            // 
            // labeldogru
            // 
            this.labeldogru.AutoSize = true;
            this.labeldogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldogru.Location = new System.Drawing.Point(893, 43);
            this.labeldogru.Name = "labeldogru";
            this.labeldogru.Size = new System.Drawing.Size(39, 29);
            this.labeldogru.TabIndex = 2;
            this.labeldogru.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(732, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yanıtınız:";
            // 
            // labelyanıt
            // 
            this.labelyanıt.AutoSize = true;
            this.labelyanıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyanıt.Location = new System.Drawing.Point(872, 100);
            this.labelyanıt.Name = "labelyanıt";
            this.labelyanıt.Size = new System.Drawing.Size(39, 29);
            this.labelyanıt.TabIndex = 4;
            this.labelyanıt.Text = "00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 90);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 90);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 90);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 90);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(732, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doğru sayısı:";
            // 
            // labeldogrusayı
            // 
            this.labeldogrusayı.AutoSize = true;
            this.labeldogrusayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldogrusayı.Location = new System.Drawing.Point(889, 182);
            this.labeldogrusayı.Name = "labeldogrusayı";
            this.labeldogrusayı.Size = new System.Drawing.Size(39, 29);
            this.labeldogrusayı.TabIndex = 10;
            this.labeldogrusayı.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(727, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yanlış sayısı:";
            // 
            // labelyanlıssayısı
            // 
            this.labelyanlıssayısı.AutoSize = true;
            this.labelyanlıssayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyanlıssayısı.Location = new System.Drawing.Point(893, 246);
            this.labelyanlıssayısı.Name = "labelyanlıssayısı";
            this.labelyanlıssayısı.Size = new System.Drawing.Size(39, 29);
            this.labelyanlıssayısı.TabIndex = 12;
            this.labelyanlıssayısı.Text = "00";
            // 
            // buttonileri
            // 
            this.buttonileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonileri.Location = new System.Drawing.Point(543, 351);
            this.buttonileri.Name = "buttonileri";
            this.buttonileri.Size = new System.Drawing.Size(220, 90);
            this.buttonileri.TabIndex = 13;
            this.buttonileri.Text = "İLERİ";
            this.buttonileri.UseVisualStyleBackColor = true;
            this.buttonileri.Click += new System.EventHandler(this.buttonileri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1078, 667);
            this.Controls.Add(this.buttonileri);
            this.Controls.Add(this.labelyanlıssayısı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labeldogrusayı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelyanıt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeldogru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeldogru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelyanıt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeldogrusayı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelyanlıssayısı;
        private System.Windows.Forms.Button buttonileri;
    }
}

