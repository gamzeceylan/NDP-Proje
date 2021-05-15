namespace ndpProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPuan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnYeniOyun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBarOrganik = new System.Windows.Forms.ProgressBar();
            this.LstbxOrganik = new System.Windows.Forms.ListBox();
            this.BtnBosaltOrganik = new System.Windows.Forms.Button();
            this.BtnOrganik = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBarCam = new System.Windows.Forms.ProgressBar();
            this.LstbxCam = new System.Windows.Forms.ListBox();
            this.BtnBosaltCam = new System.Windows.Forms.Button();
            this.BtnCam = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.progressBarMetal = new System.Windows.Forms.ProgressBar();
            this.LstbxMetal = new System.Windows.Forms.ListBox();
            this.BtnBosaltMetal = new System.Windows.Forms.Button();
            this.BtnMetal = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.progressBarKagit = new System.Windows.Forms.ProgressBar();
            this.LstbxKagit = new System.Windows.Forms.ListBox();
            this.BtnKagit = new System.Windows.Forms.Button();
            this.BtnBosaltKagit = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelPuan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnCikis);
            this.panel1.Controls.Add(this.BtnYeniOyun);
            this.panel1.Location = new System.Drawing.Point(24, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 558);
            this.panel1.TabIndex = 1;
            // 
            // labelPuan
            // 
            this.labelPuan.BackColor = System.Drawing.Color.DarkGray;
            this.labelPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPuan.Location = new System.Drawing.Point(14, 351);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPuan.Size = new System.Drawing.Size(201, 93);
            this.labelPuan.TabIndex = 1;
            this.labelPuan.Text = "labelPuan";
            this.labelPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "PUAN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "SÜRE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(14, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(203, 87);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.SlateGray;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(14, 488);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(203, 64);
            this.BtnCikis.TabIndex = 1;
            this.BtnCikis.Text = "ÇIKIŞ";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnYeniOyun
            // 
            this.BtnYeniOyun.BackColor = System.Drawing.Color.SlateGray;
            this.BtnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniOyun.Location = new System.Drawing.Point(14, 12);
            this.BtnYeniOyun.Name = "BtnYeniOyun";
            this.BtnYeniOyun.Size = new System.Drawing.Size(205, 83);
            this.BtnYeniOyun.TabIndex = 0;
            this.BtnYeniOyun.Text = "YENİ OYUN";
            this.BtnYeniOyun.UseVisualStyleBackColor = false;
            this.BtnYeniOyun.Click += new System.EventHandler(this.BtnYeniOyun_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.progressBarOrganik);
            this.panel2.Controls.Add(this.LstbxOrganik);
            this.panel2.Controls.Add(this.BtnBosaltOrganik);
            this.panel2.Controls.Add(this.BtnOrganik);
            this.panel2.Location = new System.Drawing.Point(277, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 369);
            this.panel2.TabIndex = 3;
            // 
            // progressBarOrganik
            // 
            this.progressBarOrganik.Location = new System.Drawing.Point(15, 272);
            this.progressBarOrganik.Maximum = 700;
            this.progressBarOrganik.Name = "progressBarOrganik";
            this.progressBarOrganik.Size = new System.Drawing.Size(209, 40);
            this.progressBarOrganik.TabIndex = 2;
            // 
            // LstbxOrganik
            // 
            this.LstbxOrganik.FormattingEnabled = true;
            this.LstbxOrganik.ItemHeight = 16;
            this.LstbxOrganik.Location = new System.Drawing.Point(15, 54);
            this.LstbxOrganik.Name = "LstbxOrganik";
            this.LstbxOrganik.Size = new System.Drawing.Size(209, 212);
            this.LstbxOrganik.TabIndex = 2;
            // 
            // BtnBosaltOrganik
            // 
            this.BtnBosaltOrganik.Enabled = false;
            this.BtnBosaltOrganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBosaltOrganik.Location = new System.Drawing.Point(15, 318);
            this.BtnBosaltOrganik.Name = "BtnBosaltOrganik";
            this.BtnBosaltOrganik.Size = new System.Drawing.Size(209, 46);
            this.BtnBosaltOrganik.TabIndex = 1;
            this.BtnBosaltOrganik.Text = "BOŞALT";
            this.BtnBosaltOrganik.UseVisualStyleBackColor = true;
            this.BtnBosaltOrganik.Click += new System.EventHandler(this.BtnBosaltOrganik_Click);
            // 
            // BtnOrganik
            // 
            this.BtnOrganik.Enabled = false;
            this.BtnOrganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOrganik.Location = new System.Drawing.Point(15, 3);
            this.BtnOrganik.Name = "BtnOrganik";
            this.BtnOrganik.Size = new System.Drawing.Size(209, 45);
            this.BtnOrganik.TabIndex = 0;
            this.BtnOrganik.Text = "ORGANİK ATIK";
            this.BtnOrganik.UseVisualStyleBackColor = true;
            this.BtnOrganik.Click += new System.EventHandler(this.BtnOrganik_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.progressBarCam);
            this.panel3.Controls.Add(this.LstbxCam);
            this.panel3.Controls.Add(this.BtnBosaltCam);
            this.panel3.Controls.Add(this.BtnCam);
            this.panel3.Location = new System.Drawing.Point(277, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 373);
            this.panel3.TabIndex = 4;
            // 
            // progressBarCam
            // 
            this.progressBarCam.Location = new System.Drawing.Point(15, 275);
            this.progressBarCam.Maximum = 2200;
            this.progressBarCam.Name = "progressBarCam";
            this.progressBarCam.Size = new System.Drawing.Size(209, 40);
            this.progressBarCam.TabIndex = 4;
            // 
            // LstbxCam
            // 
            this.LstbxCam.FormattingEnabled = true;
            this.LstbxCam.ItemHeight = 16;
            this.LstbxCam.Location = new System.Drawing.Point(15, 57);
            this.LstbxCam.Name = "LstbxCam";
            this.LstbxCam.Size = new System.Drawing.Size(209, 212);
            this.LstbxCam.TabIndex = 4;
            // 
            // BtnBosaltCam
            // 
            this.BtnBosaltCam.Enabled = false;
            this.BtnBosaltCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBosaltCam.Location = new System.Drawing.Point(15, 321);
            this.BtnBosaltCam.Name = "BtnBosaltCam";
            this.BtnBosaltCam.Size = new System.Drawing.Size(209, 46);
            this.BtnBosaltCam.TabIndex = 3;
            this.BtnBosaltCam.Text = "BOŞALT";
            this.BtnBosaltCam.UseVisualStyleBackColor = true;
            this.BtnBosaltCam.Click += new System.EventHandler(this.BtnBosaltCam_Click);
            // 
            // BtnCam
            // 
            this.BtnCam.Enabled = false;
            this.BtnCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCam.Location = new System.Drawing.Point(15, 6);
            this.BtnCam.Name = "BtnCam";
            this.BtnCam.Size = new System.Drawing.Size(209, 45);
            this.BtnCam.TabIndex = 2;
            this.BtnCam.Text = "CAM";
            this.BtnCam.UseVisualStyleBackColor = true;
            this.BtnCam.Click += new System.EventHandler(this.BtnCam_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.progressBarMetal);
            this.panel4.Controls.Add(this.LstbxMetal);
            this.panel4.Controls.Add(this.BtnBosaltMetal);
            this.panel4.Controls.Add(this.BtnMetal);
            this.panel4.Location = new System.Drawing.Point(528, 453);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 373);
            this.panel4.TabIndex = 5;
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(18, 275);
            this.progressBarMetal.Maximum = 2300;
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(209, 40);
            this.progressBarMetal.TabIndex = 5;
            // 
            // LstbxMetal
            // 
            this.LstbxMetal.FormattingEnabled = true;
            this.LstbxMetal.ItemHeight = 16;
            this.LstbxMetal.Location = new System.Drawing.Point(18, 57);
            this.LstbxMetal.Name = "LstbxMetal";
            this.LstbxMetal.Size = new System.Drawing.Size(209, 212);
            this.LstbxMetal.TabIndex = 5;
            // 
            // BtnBosaltMetal
            // 
            this.BtnBosaltMetal.Enabled = false;
            this.BtnBosaltMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBosaltMetal.Location = new System.Drawing.Point(18, 321);
            this.BtnBosaltMetal.Name = "BtnBosaltMetal";
            this.BtnBosaltMetal.Size = new System.Drawing.Size(209, 46);
            this.BtnBosaltMetal.TabIndex = 7;
            this.BtnBosaltMetal.Text = "BOŞALT";
            this.BtnBosaltMetal.UseVisualStyleBackColor = true;
            this.BtnBosaltMetal.Click += new System.EventHandler(this.BtnBosaltMetal_Click);
            // 
            // BtnMetal
            // 
            this.BtnMetal.Enabled = false;
            this.BtnMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMetal.Location = new System.Drawing.Point(18, 6);
            this.BtnMetal.Name = "BtnMetal";
            this.BtnMetal.Size = new System.Drawing.Size(209, 45);
            this.BtnMetal.TabIndex = 6;
            this.BtnMetal.Text = "METAL";
            this.BtnMetal.UseVisualStyleBackColor = true;
            this.BtnMetal.Click += new System.EventHandler(this.BtnMetal_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.progressBarKagit);
            this.panel5.Controls.Add(this.LstbxKagit);
            this.panel5.Controls.Add(this.BtnKagit);
            this.panel5.Controls.Add(this.BtnBosaltKagit);
            this.panel5.Location = new System.Drawing.Point(528, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 369);
            this.panel5.TabIndex = 6;
            // 
            // progressBarKagit
            // 
            this.progressBarKagit.Location = new System.Drawing.Point(18, 272);
            this.progressBarKagit.Maximum = 1200;
            this.progressBarKagit.Name = "progressBarKagit";
            this.progressBarKagit.Size = new System.Drawing.Size(209, 40);
            this.progressBarKagit.TabIndex = 3;
            // 
            // LstbxKagit
            // 
            this.LstbxKagit.FormattingEnabled = true;
            this.LstbxKagit.ItemHeight = 16;
            this.LstbxKagit.Location = new System.Drawing.Point(18, 54);
            this.LstbxKagit.Name = "LstbxKagit";
            this.LstbxKagit.Size = new System.Drawing.Size(209, 212);
            this.LstbxKagit.TabIndex = 3;
            // 
            // BtnKagit
            // 
            this.BtnKagit.Enabled = false;
            this.BtnKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKagit.Location = new System.Drawing.Point(18, 3);
            this.BtnKagit.Name = "BtnKagit";
            this.BtnKagit.Size = new System.Drawing.Size(209, 45);
            this.BtnKagit.TabIndex = 4;
            this.BtnKagit.Text = "KAĞIT";
            this.BtnKagit.UseVisualStyleBackColor = true;
            this.BtnKagit.Click += new System.EventHandler(this.BtnKagit_Click);
            // 
            // BtnBosaltKagit
            // 
            this.BtnBosaltKagit.Enabled = false;
            this.BtnBosaltKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBosaltKagit.Location = new System.Drawing.Point(18, 318);
            this.BtnBosaltKagit.Name = "BtnBosaltKagit";
            this.BtnBosaltKagit.Size = new System.Drawing.Size(209, 46);
            this.BtnBosaltKagit.TabIndex = 5;
            this.BtnBosaltKagit.Text = "BOŞALT";
            this.BtnBosaltKagit.UseVisualStyleBackColor = true;
            this.BtnBosaltKagit.Click += new System.EventHandler(this.BtnBosaltKagit_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 835);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.MintCream;
            this.panel10.Controls.Add(this.label5);
            this.panel10.Location = new System.Drawing.Point(277, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(492, 54);
            this.panel10.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(129, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "ATIK KUTULARI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(793, 835);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Atık Toplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnYeniOyun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBosaltOrganik;
        private System.Windows.Forms.Button BtnOrganik;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox LstbxCam;
        private System.Windows.Forms.Button BtnBosaltCam;
        private System.Windows.Forms.Button BtnCam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox LstbxMetal;
        private System.Windows.Forms.Button BtnBosaltMetal;
        private System.Windows.Forms.Button BtnMetal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox LstbxKagit;
        private System.Windows.Forms.Button BtnKagit;
        private System.Windows.Forms.Button BtnBosaltKagit;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.ProgressBar progressBarOrganik;
        private System.Windows.Forms.ProgressBar progressBarCam;
        private System.Windows.Forms.ProgressBar progressBarMetal;
        private System.Windows.Forms.ProgressBar progressBarKagit;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelPuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox LstbxOrganik;
        public System.Windows.Forms.Label label3;
    }
}

