
namespace KDSProje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSoruNo = new System.Windows.Forms.TextBox();
            this.textSoru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ileriButton = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textSkor = new System.Windows.Forms.TextBox();
            this.cevapEvet = new System.Windows.Forms.RadioButton();
            this.cevapHayir = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textTC = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textCinsiyet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SoruNo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soru:";
            // 
            // textSoruNo
            // 
            this.textSoruNo.Location = new System.Drawing.Point(133, 94);
            this.textSoruNo.Name = "textSoruNo";
            this.textSoruNo.Size = new System.Drawing.Size(44, 22);
            this.textSoruNo.TabIndex = 3;
            this.textSoruNo.TextChanged += new System.EventHandler(this.textSoruNo_TextChanged);
            // 
            // textSoru
            // 
            this.textSoru.Location = new System.Drawing.Point(133, 131);
            this.textSoru.Name = "textSoru";
            this.textSoru.Size = new System.Drawing.Size(361, 22);
            this.textSoru.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cevap";
            // 
            // ileriButton
            // 
            this.ileriButton.Location = new System.Drawing.Point(231, 200);
            this.ileriButton.Name = "ileriButton";
            this.ileriButton.Size = new System.Drawing.Size(80, 33);
            this.ileriButton.TabIndex = 7;
            this.ileriButton.Text = "İleri";
            this.ileriButton.UseVisualStyleBackColor = true;
            this.ileriButton.Click += new System.EventHandler(this.ileriButton_Click);
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(130, 201);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(86, 33);
            this.geriButton.TabIndex = 8;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Skor:";
            // 
            // textSkor
            // 
            this.textSkor.Location = new System.Drawing.Point(317, 21);
            this.textSkor.Name = "textSkor";
            this.textSkor.Size = new System.Drawing.Size(114, 22);
            this.textSkor.TabIndex = 10;
            // 
            // cevapEvet
            // 
            this.cevapEvet.AutoSize = true;
            this.cevapEvet.Location = new System.Drawing.Point(133, 167);
            this.cevapEvet.Name = "cevapEvet";
            this.cevapEvet.Size = new System.Drawing.Size(57, 21);
            this.cevapEvet.TabIndex = 5;
            this.cevapEvet.TabStop = true;
            this.cevapEvet.Text = "Evet";
            this.cevapEvet.UseVisualStyleBackColor = true;
            // 
            // cevapHayir
            // 
            this.cevapHayir.AutoSize = true;
            this.cevapHayir.Location = new System.Drawing.Point(196, 167);
            this.cevapHayir.Name = "cevapHayir";
            this.cevapHayir.Size = new System.Drawing.Size(62, 21);
            this.cevapHayir.TabIndex = 6;
            this.cevapHayir.TabStop = true;
            this.cevapHayir.Text = "Hayır";
            this.cevapHayir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.ileriButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.geriButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textSoruNo);
            this.groupBox1.Controls.Add(this.cevapHayir);
            this.groupBox1.Controls.Add(this.textSoru);
            this.groupBox1.Controls.Add(this.cevapEvet);
            this.groupBox1.Location = new System.Drawing.Point(28, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 300);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korona Teşhis";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.textSkor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(605, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 323);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuçlarınız: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(84, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(583, 116);
            this.listBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Soyad:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "TC No:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cinsiyet";
            // 
            // textTC
            // 
            this.textTC.Location = new System.Drawing.Point(141, 78);
            this.textTC.Name = "textTC";
            this.textTC.Size = new System.Drawing.Size(100, 22);
            this.textTC.TabIndex = 5;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(141, 106);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(100, 22);
            this.textAd.TabIndex = 6;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(141, 132);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(100, 22);
            this.textSoyad.TabIndex = 7;
            // 
            // textCinsiyet
            // 
            this.textCinsiyet.Location = new System.Drawing.Point(141, 159);
            this.textCinsiyet.Name = "textCinsiyet";
            this.textCinsiyet.Size = new System.Drawing.Size(100, 22);
            this.textCinsiyet.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textCinsiyet);
            this.groupBox3.Controls.Add(this.textSoyad);
            this.groupBox3.Controls.Add(this.textAd);
            this.groupBox3.Controls.Add(this.textTC);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(28, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 311);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgileriniz:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(605, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(84, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 109);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(487, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sonuçlarınız, 5 puan ve üzerinde ise sağlık kuruluşuna başvurmanız gerekir.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sağlıklı günler dileriz...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1480, 722);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoronaTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSoruNo;
        private System.Windows.Forms.TextBox textSoru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ileriButton;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSkor;
        private System.Windows.Forms.RadioButton cevapEvet;
        private System.Windows.Forms.RadioButton cevapHayir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textTC;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textCinsiyet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}

