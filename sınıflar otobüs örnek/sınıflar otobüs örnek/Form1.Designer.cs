namespace sınıflar_otobüs_örnek
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.cboxotobüstürü = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioerkek = new System.Windows.Forms.RadioButton();
            this.radiokadın = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxmüsteriler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "adsoyad";
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(12, 37);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(100, 20);
            this.textBoxad.TabIndex = 1;
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.Location = new System.Drawing.Point(12, 272);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(86, 33);
            this.buttonkaydet.TabIndex = 4;
            this.buttonkaydet.Text = "Kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = true;
            this.buttonkaydet.Click += new System.EventHandler(this.buttonkaydet_Click);
            // 
            // cboxotobüstürü
            // 
            this.cboxotobüstürü.FormattingEnabled = true;
            this.cboxotobüstürü.Items.AddRange(new object[] {
            "setra",
            "trivago",
            "403"});
            this.cboxotobüstürü.Location = new System.Drawing.Point(113, 279);
            this.cboxotobüstürü.Name = "cboxotobüstürü";
            this.cboxotobüstürü.Size = new System.Drawing.Size(121, 21);
            this.cboxotobüstürü.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiokadın);
            this.groupBox1.Controls.Add(this.radioerkek);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "cinsiyet";
            // 
            // radioerkek
            // 
            this.radioerkek.AutoSize = true;
            this.radioerkek.Location = new System.Drawing.Point(17, 31);
            this.radioerkek.Name = "radioerkek";
            this.radioerkek.Size = new System.Drawing.Size(52, 17);
            this.radioerkek.TabIndex = 0;
            this.radioerkek.TabStop = true;
            this.radioerkek.Text = "erkek";
            this.radioerkek.UseVisualStyleBackColor = true;
            // 
            // radiokadın
            // 
            this.radiokadın.AutoSize = true;
            this.radiokadın.Location = new System.Drawing.Point(17, 66);
            this.radiokadın.Name = "radiokadın";
            this.radiokadın.Size = new System.Drawing.Size(51, 17);
            this.radiokadın.TabIndex = 1;
            this.radiokadın.TabStop = true;
            this.radiokadın.Text = "kadın";
            this.radiokadın.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "otobüs türü";
            // 
            // listBoxmüsteriler
            // 
            this.listBoxmüsteriler.FormattingEnabled = true;
            this.listBoxmüsteriler.Location = new System.Drawing.Point(274, 23);
            this.listBoxmüsteriler.Name = "listBoxmüsteriler";
            this.listBoxmüsteriler.Size = new System.Drawing.Size(155, 303);
            this.listBoxmüsteriler.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 374);
            this.Controls.Add(this.listBoxmüsteriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboxotobüstürü);
            this.Controls.Add(this.buttonkaydet);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.ComboBox cboxotobüstürü;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiokadın;
        private System.Windows.Forms.RadioButton radioerkek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxmüsteriler;
    }
}

