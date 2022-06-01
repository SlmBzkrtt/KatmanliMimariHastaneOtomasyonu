namespace KatmanliMimariHastaneOtomasyonu
{
    partial class RandevuKontrolPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuKontrolPaneli));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_Doktorlar = new System.Windows.Forms.DataGridView();
            this.dg_Klinikler = new System.Windows.Forms.DataGridView();
            this.dg_Randevular = new System.Windows.Forms.DataGridView();
            this.txt_RandevuId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KlinikId = new System.Windows.Forms.TextBox();
            this.txt_DoktorId = new System.Windows.Forms.TextBox();
            this.txt_HastaId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_RandevuSaati = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_RandevuTarihi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_RandevuGuncelle = new System.Windows.Forms.Button();
            this.Btn_RandevuSil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dg_Hastalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Doktorlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Klinikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Randevular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Hastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(275, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Doktor Bilgileri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Klinik Bilgileri";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tüm Randevular";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dg_Doktorlar
            // 
            this.dg_Doktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Doktorlar.Location = new System.Drawing.Point(279, 379);
            this.dg_Doktorlar.Name = "dg_Doktorlar";
            this.dg_Doktorlar.Size = new System.Drawing.Size(268, 171);
            this.dg_Doktorlar.TabIndex = 22;
            // 
            // dg_Klinikler
            // 
            this.dg_Klinikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Klinikler.Location = new System.Drawing.Point(22, 379);
            this.dg_Klinikler.Name = "dg_Klinikler";
            this.dg_Klinikler.Size = new System.Drawing.Size(251, 171);
            this.dg_Klinikler.TabIndex = 21;
            // 
            // dg_Randevular
            // 
            this.dg_Randevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Randevular.Location = new System.Drawing.Point(22, 187);
            this.dg_Randevular.Name = "dg_Randevular";
            this.dg_Randevular.Size = new System.Drawing.Size(800, 140);
            this.dg_Randevular.TabIndex = 20;
            this.dg_Randevular.SelectionChanged += new System.EventHandler(this.Dg_Randevular_SelectionChanged);
            // 
            // txt_RandevuId
            // 
            this.txt_RandevuId.Enabled = false;
            this.txt_RandevuId.Location = new System.Drawing.Point(139, 24);
            this.txt_RandevuId.Name = "txt_RandevuId";
            this.txt_RandevuId.Size = new System.Drawing.Size(111, 20);
            this.txt_RandevuId.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Randevu ID :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Klinik ID : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Doktor ID : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_KlinikId
            // 
            this.txt_KlinikId.Location = new System.Drawing.Point(139, 116);
            this.txt_KlinikId.Name = "txt_KlinikId";
            this.txt_KlinikId.Size = new System.Drawing.Size(111, 20);
            this.txt_KlinikId.TabIndex = 28;
            // 
            // txt_DoktorId
            // 
            this.txt_DoktorId.Location = new System.Drawing.Point(139, 70);
            this.txt_DoktorId.Name = "txt_DoktorId";
            this.txt_DoktorId.Size = new System.Drawing.Size(111, 20);
            this.txt_DoktorId.TabIndex = 29;
            // 
            // txt_HastaId
            // 
            this.txt_HastaId.Location = new System.Drawing.Point(421, 24);
            this.txt_HastaId.Name = "txt_HastaId";
            this.txt_HastaId.Size = new System.Drawing.Size(111, 20);
            this.txt_HastaId.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(264, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Hasta ID : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_RandevuSaati
            // 
            this.txt_RandevuSaati.Location = new System.Drawing.Point(421, 116);
            this.txt_RandevuSaati.Name = "txt_RandevuSaati";
            this.txt_RandevuSaati.Size = new System.Drawing.Size(111, 20);
            this.txt_RandevuSaati.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(264, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "Randevu Saati : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_RandevuTarihi
            // 
            this.txt_RandevuTarihi.Location = new System.Drawing.Point(421, 70);
            this.txt_RandevuTarihi.Name = "txt_RandevuTarihi";
            this.txt_RandevuTarihi.Size = new System.Drawing.Size(111, 20);
            this.txt_RandevuTarihi.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(264, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Randevu Tarihi : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_RandevuGuncelle
            // 
            this.Btn_RandevuGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_RandevuGuncelle.Location = new System.Drawing.Point(555, 21);
            this.Btn_RandevuGuncelle.Name = "Btn_RandevuGuncelle";
            this.Btn_RandevuGuncelle.Size = new System.Drawing.Size(267, 57);
            this.Btn_RandevuGuncelle.TabIndex = 36;
            this.Btn_RandevuGuncelle.Text = "Randevu Güncelle";
            this.Btn_RandevuGuncelle.UseVisualStyleBackColor = true;
            this.Btn_RandevuGuncelle.Click += new System.EventHandler(this.Btn_RandevuGuncelle_Click);
            // 
            // Btn_RandevuSil
            // 
            this.Btn_RandevuSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_RandevuSil.Location = new System.Drawing.Point(555, 84);
            this.Btn_RandevuSil.Name = "Btn_RandevuSil";
            this.Btn_RandevuSil.Size = new System.Drawing.Size(267, 57);
            this.Btn_RandevuSil.TabIndex = 37;
            this.Btn_RandevuSil.Text = "Randevu Sil";
            this.Btn_RandevuSil.UseVisualStyleBackColor = true;
            this.Btn_RandevuSil.Click += new System.EventHandler(this.Btn_RandevuSil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(551, 342);
            this.label10.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 22);
            this.label10.TabIndex = 39;
            this.label10.Text = "Hasta Bilgileri";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dg_Hastalar
            // 
            this.dg_Hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Hastalar.Location = new System.Drawing.Point(555, 379);
            this.dg_Hastalar.Name = "dg_Hastalar";
            this.dg_Hastalar.Size = new System.Drawing.Size(267, 171);
            this.dg_Hastalar.TabIndex = 38;
            // 
            // RandevuKontrolPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dg_Hastalar);
            this.Controls.Add(this.Btn_RandevuSil);
            this.Controls.Add(this.Btn_RandevuGuncelle);
            this.Controls.Add(this.txt_RandevuTarihi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_RandevuSaati);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_HastaId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_DoktorId);
            this.Controls.Add(this.txt_KlinikId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Doktorlar);
            this.Controls.Add(this.dg_Klinikler);
            this.Controls.Add(this.dg_Randevular);
            this.Controls.Add(this.txt_RandevuId);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandevuKontrolPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Kontrol Paneli";
            this.Load += new System.EventHandler(this.RandevuKontrolPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Doktorlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Klinikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Randevular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Hastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_Doktorlar;
        private System.Windows.Forms.DataGridView dg_Klinikler;
        private System.Windows.Forms.DataGridView dg_Randevular;
        public System.Windows.Forms.TextBox txt_RandevuId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_KlinikId;
        public System.Windows.Forms.TextBox txt_DoktorId;
        public System.Windows.Forms.TextBox txt_HastaId;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_RandevuSaati;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_RandevuTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_RandevuGuncelle;
        private System.Windows.Forms.Button Btn_RandevuSil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dg_Hastalar;
    }
}