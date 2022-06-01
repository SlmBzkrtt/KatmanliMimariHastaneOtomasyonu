namespace KatmanliMimariHastaneOtomasyonu
{
    partial class HastaRandevuGecmisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaRandevuGecmisi));
            this.label6 = new System.Windows.Forms.Label();
            this.txt_HastaId = new System.Windows.Forms.TextBox();
            this.dg_Randevular = new System.Windows.Forms.DataGridView();
            this.dg_Klinikler = new System.Windows.Forms.DataGridView();
            this.dg_Doktorlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Randevular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Klinikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Doktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hasta ID : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_HastaId
            // 
            this.txt_HastaId.Enabled = false;
            this.txt_HastaId.Location = new System.Drawing.Point(128, 24);
            this.txt_HastaId.Name = "txt_HastaId";
            this.txt_HastaId.Size = new System.Drawing.Size(111, 20);
            this.txt_HastaId.TabIndex = 11;
            // 
            // dg_Randevular
            // 
            this.dg_Randevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Randevular.Location = new System.Drawing.Point(3, 93);
            this.dg_Randevular.Name = "dg_Randevular";
            this.dg_Randevular.Size = new System.Drawing.Size(794, 140);
            this.dg_Randevular.TabIndex = 12;
            // 
            // dg_Klinikler
            // 
            this.dg_Klinikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Klinikler.Location = new System.Drawing.Point(3, 266);
            this.dg_Klinikler.Name = "dg_Klinikler";
            this.dg_Klinikler.Size = new System.Drawing.Size(236, 181);
            this.dg_Klinikler.TabIndex = 13;
            // 
            // dg_Doktorlar
            // 
            this.dg_Doktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Doktorlar.Location = new System.Drawing.Point(245, 266);
            this.dg_Doktorlar.Name = "dg_Doktorlar";
            this.dg_Doktorlar.Size = new System.Drawing.Size(552, 181);
            this.dg_Doktorlar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hastanın Geçmiş Randevuları ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Klinik Bilgileri";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(241, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Doktor Bilgileri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HastaRandevuGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Doktorlar);
            this.Controls.Add(this.dg_Klinikler);
            this.Controls.Add(this.dg_Randevular);
            this.Controls.Add(this.txt_HastaId);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HastaRandevuGecmisi";
            this.Text = "Hasta Randevu Geçmişi";
            this.Load += new System.EventHandler(this.HastaRandevuGecmisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Randevular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Klinikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Doktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_HastaId;
        private System.Windows.Forms.DataGridView dg_Randevular;
        private System.Windows.Forms.DataGridView dg_Klinikler;
        private System.Windows.Forms.DataGridView dg_Doktorlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}