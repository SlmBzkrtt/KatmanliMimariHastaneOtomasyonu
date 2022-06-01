namespace KatmanliMimariHastaneOtomasyonu
{
    partial class HastaSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaSifremiUnuttum));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_HastayiKontrolEt = new System.Windows.Forms.Button();
            this.txt_MevcutSifre = new System.Windows.Forms.TextBox();
            this.txt_HastaAnne = new System.Windows.Forms.TextBox();
            this.txt_HastaTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_HastayiKontrolEt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_MevcutSifre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_HastaAnne, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_HastaTC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
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
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Btn_HastayiKontrolEt
            // 
            this.Btn_HastayiKontrolEt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_HastayiKontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_HastayiKontrolEt.ForeColor = System.Drawing.Color.Black;
            this.Btn_HastayiKontrolEt.Location = new System.Drawing.Point(185, 203);
            this.Btn_HastayiKontrolEt.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_HastayiKontrolEt.Name = "Btn_HastayiKontrolEt";
            this.Btn_HastayiKontrolEt.Size = new System.Drawing.Size(179, 66);
            this.Btn_HastayiKontrolEt.TabIndex = 9;
            this.Btn_HastayiKontrolEt.Text = "Hastayı Kontrol Et";
            this.Btn_HastayiKontrolEt.UseVisualStyleBackColor = true;
            this.Btn_HastayiKontrolEt.Click += new System.EventHandler(this.Btn_HastayiKontrolEt_Click);
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
            // txt_HastaAnne
            // 
            this.txt_HastaAnne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HastaAnne.Location = new System.Drawing.Point(204, 90);
            this.txt_HastaAnne.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HastaAnne.Name = "txt_HastaAnne";
            this.txt_HastaAnne.Size = new System.Drawing.Size(140, 20);
            this.txt_HastaAnne.TabIndex = 6;
            // 
            // txt_HastaTC
            // 
            this.txt_HastaTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HastaTC.Location = new System.Drawing.Point(204, 23);
            this.txt_HastaTC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HastaTC.MaxLength = 11;
            this.txt_HastaTC.Name = "txt_HastaTC";
            this.txt_HastaTC.Size = new System.Drawing.Size(140, 20);
            this.txt_HastaTC.TabIndex = 5;
            this.txt_HastaTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_HastaTC_KeyPress);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 67);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anne Adı : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta T.C : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HastaSifremiUnuttum
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
            this.Name = "HastaSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Şifremi Unuttum";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_HastayiKontrolEt;
        private System.Windows.Forms.TextBox txt_MevcutSifre;
        private System.Windows.Forms.TextBox txt_HastaAnne;
        private System.Windows.Forms.TextBox txt_HastaTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}