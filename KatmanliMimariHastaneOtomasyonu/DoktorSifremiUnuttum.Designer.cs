namespace KatmanliMimariHastaneOtomasyonu
{
    partial class DoktorSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorSifremiUnuttum));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_DoktoruKontrolEt = new System.Windows.Forms.Button();
            this.txt_MevcutSifre = new System.Windows.Forms.TextBox();
            this.txt_DoktorYas = new System.Windows.Forms.TextBox();
            this.txt_DoktorTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Yas = new System.Windows.Forms.Label();
            this.lbl_DoktorTC = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_DoktoruKontrolEt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_MevcutSifre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_DoktorYas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_DoktorTC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Yas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_DoktorTC, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 271);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Btn_DoktoruKontrolEt
            // 
            this.Btn_DoktoruKontrolEt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_DoktoruKontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_DoktoruKontrolEt.ForeColor = System.Drawing.Color.Black;
            this.Btn_DoktoruKontrolEt.Location = new System.Drawing.Point(185, 203);
            this.Btn_DoktoruKontrolEt.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_DoktoruKontrolEt.Name = "Btn_DoktoruKontrolEt";
            this.Btn_DoktoruKontrolEt.Size = new System.Drawing.Size(179, 66);
            this.Btn_DoktoruKontrolEt.TabIndex = 9;
            this.Btn_DoktoruKontrolEt.Text = "Doktoru Kontrol Et";
            this.Btn_DoktoruKontrolEt.UseVisualStyleBackColor = true;
            this.Btn_DoktoruKontrolEt.Click += new System.EventHandler(this.Btn_DoktoruKontrolEt_Click);
            // 
            // txt_MevcutSifre
            // 
            this.txt_MevcutSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MevcutSifre.Enabled = false;
            this.txt_MevcutSifre.Location = new System.Drawing.Point(204, 157);
            this.txt_MevcutSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MevcutSifre.Name = "txt_MevcutSifre";
            this.txt_MevcutSifre.Size = new System.Drawing.Size(140, 20);
            this.txt_MevcutSifre.TabIndex = 7;
            // 
            // txt_DoktorYas
            // 
            this.txt_DoktorYas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DoktorYas.Location = new System.Drawing.Point(204, 90);
            this.txt_DoktorYas.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DoktorYas.MaxLength = 2;
            this.txt_DoktorYas.Name = "txt_DoktorYas";
            this.txt_DoktorYas.Size = new System.Drawing.Size(140, 20);
            this.txt_DoktorYas.TabIndex = 6;
            this.txt_DoktorYas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DoktorYas_KeyPress);
            // 
            // txt_DoktorTC
            // 
            this.txt_DoktorTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DoktorTC.Location = new System.Drawing.Point(204, 23);
            this.txt_DoktorTC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DoktorTC.MaxLength = 11;
            this.txt_DoktorTC.Name = "txt_DoktorTC";
            this.txt_DoktorTC.Size = new System.Drawing.Size(140, 20);
            this.txt_DoktorTC.TabIndex = 5;
            this.txt_DoktorTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DoktorTC_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 67);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mevcut Şifre : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Yas
            // 
            this.lbl_Yas.AutoSize = true;
            this.lbl_Yas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Yas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yas.ForeColor = System.Drawing.Color.White;
            this.lbl_Yas.Location = new System.Drawing.Point(2, 67);
            this.lbl_Yas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Yas.Name = "lbl_Yas";
            this.lbl_Yas.Size = new System.Drawing.Size(179, 67);
            this.lbl_Yas.TabIndex = 2;
            this.lbl_Yas.Text = "Yaş : ";
            this.lbl_Yas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DoktorTC
            // 
            this.lbl_DoktorTC.AutoSize = true;
            this.lbl_DoktorTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_DoktorTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DoktorTC.ForeColor = System.Drawing.Color.White;
            this.lbl_DoktorTC.Location = new System.Drawing.Point(2, 0);
            this.lbl_DoktorTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DoktorTC.Name = "lbl_DoktorTC";
            this.lbl_DoktorTC.Size = new System.Drawing.Size(179, 67);
            this.lbl_DoktorTC.TabIndex = 0;
            this.lbl_DoktorTC.Text = "Doktor T.C : ";
            this.lbl_DoktorTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoktorSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(366, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoktorSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Şifremi Unuttum";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_DoktoruKontrolEt;
        private System.Windows.Forms.TextBox txt_MevcutSifre;
        private System.Windows.Forms.TextBox txt_DoktorYas;
        private System.Windows.Forms.TextBox txt_DoktorTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Yas;
        private System.Windows.Forms.Label lbl_DoktorTC;
    }
}