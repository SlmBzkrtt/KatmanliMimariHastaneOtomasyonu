namespace KatmanliMimariHastaneOtomasyonu
{
    partial class KlinikKontolPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlinikKontolPaneli));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_KlinikAdi = new System.Windows.Forms.Label();
            this.txt_KlinikAdi = new System.Windows.Forms.TextBox();
            this.Btn_KlinikEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_KlinikSil = new System.Windows.Forms.Button();
            this.txt_KlinikAdi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KlinikId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_KlinikGuncelle = new System.Windows.Forms.Button();
            this.dg_Klinikler = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Klinikler)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 159);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_KlinikAdi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_KlinikAdi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_KlinikEkle, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 153);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_KlinikAdi
            // 
            this.lbl_KlinikAdi.AutoSize = true;
            this.lbl_KlinikAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_KlinikAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KlinikAdi.ForeColor = System.Drawing.Color.White;
            this.lbl_KlinikAdi.Location = new System.Drawing.Point(3, 0);
            this.lbl_KlinikAdi.Name = "lbl_KlinikAdi";
            this.lbl_KlinikAdi.Size = new System.Drawing.Size(162, 76);
            this.lbl_KlinikAdi.TabIndex = 0;
            this.lbl_KlinikAdi.Text = "Klinik Adı : ";
            this.lbl_KlinikAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_KlinikAdi
            // 
            this.txt_KlinikAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_KlinikAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KlinikAdi.Location = new System.Drawing.Point(178, 25);
            this.txt_KlinikAdi.Name = "txt_KlinikAdi";
            this.txt_KlinikAdi.Size = new System.Drawing.Size(148, 26);
            this.txt_KlinikAdi.TabIndex = 1;
            // 
            // Btn_KlinikEkle
            // 
            this.Btn_KlinikEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_KlinikEkle.Location = new System.Drawing.Point(171, 79);
            this.Btn_KlinikEkle.Name = "Btn_KlinikEkle";
            this.Btn_KlinikEkle.Size = new System.Drawing.Size(162, 71);
            this.Btn_KlinikEkle.TabIndex = 2;
            this.Btn_KlinikEkle.Text = "Klinik Ekle";
            this.Btn_KlinikEkle.UseVisualStyleBackColor = true;
            this.Btn_KlinikEkle.Click += new System.EventHandler(this.Btn_KlinikEkle_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_KlinikSil, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_KlinikAdi2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_KlinikId, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_KlinikGuncelle, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(345, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(337, 153);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Btn_KlinikSil
            // 
            this.Btn_KlinikSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_KlinikSil.Location = new System.Drawing.Point(171, 109);
            this.Btn_KlinikSil.Name = "Btn_KlinikSil";
            this.Btn_KlinikSil.Size = new System.Drawing.Size(162, 41);
            this.Btn_KlinikSil.TabIndex = 6;
            this.Btn_KlinikSil.Text = "Klinik Sil";
            this.Btn_KlinikSil.UseVisualStyleBackColor = true;
            this.Btn_KlinikSil.Click += new System.EventHandler(this.Btn_KlinikSil_Click);
            // 
            // txt_KlinikAdi2
            // 
            this.txt_KlinikAdi2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_KlinikAdi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KlinikAdi2.Location = new System.Drawing.Point(178, 66);
            this.txt_KlinikAdi2.Name = "txt_KlinikAdi2";
            this.txt_KlinikAdi2.Size = new System.Drawing.Size(148, 26);
            this.txt_KlinikAdi2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "Klinik Adı : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_KlinikId
            // 
            this.txt_KlinikId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_KlinikId.Enabled = false;
            this.txt_KlinikId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KlinikId.Location = new System.Drawing.Point(178, 13);
            this.txt_KlinikId.Name = "txt_KlinikId";
            this.txt_KlinikId.Size = new System.Drawing.Size(148, 26);
            this.txt_KlinikId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klinik Id : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_KlinikGuncelle
            // 
            this.Btn_KlinikGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_KlinikGuncelle.Location = new System.Drawing.Point(3, 109);
            this.Btn_KlinikGuncelle.Name = "Btn_KlinikGuncelle";
            this.Btn_KlinikGuncelle.Size = new System.Drawing.Size(162, 41);
            this.Btn_KlinikGuncelle.TabIndex = 5;
            this.Btn_KlinikGuncelle.Text = "Klinik Güncelle";
            this.Btn_KlinikGuncelle.UseVisualStyleBackColor = true;
            this.Btn_KlinikGuncelle.Click += new System.EventHandler(this.Btn_KlinikGuncelle_Click);
            // 
            // dg_Klinikler
            // 
            this.dg_Klinikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Klinikler.Location = new System.Drawing.Point(3, 165);
            this.dg_Klinikler.Name = "dg_Klinikler";
            this.dg_Klinikler.Size = new System.Drawing.Size(679, 144);
            this.dg_Klinikler.TabIndex = 1;
            this.dg_Klinikler.SelectionChanged += new System.EventHandler(this.Dtg_Klinikler_SelectionChanged);
            // 
            // KlinikKontolPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.dg_Klinikler);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KlinikKontolPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klinik Kontol Paneli";
            this.Load += new System.EventHandler(this.KlinikKontolPaneli_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Klinikler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dg_Klinikler;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_KlinikAdi;
        private System.Windows.Forms.TextBox txt_KlinikAdi;
        private System.Windows.Forms.Button Btn_KlinikEkle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txt_KlinikAdi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KlinikId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_KlinikSil;
        private System.Windows.Forms.Button Btn_KlinikGuncelle;
    }
}