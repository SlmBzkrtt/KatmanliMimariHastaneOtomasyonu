using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimariHastaneOtomasyonu
{
    public partial class DoktorKontrolPaneli : Form
    {
        public DoktorKontrolPaneli()
        {
            InitializeComponent();
        }

        private void DoktorKontrolPaneli_Load(object sender, EventArgs e)
        {
            DoktorListeGuncelle();
        }

        private void DoktorListeGuncelle()
        {
            // Doktorları database'den datagrid'e veri aktarma
            dg_DoktorListesi.DataSource = BusinessDoktor.BLKDoktorListele();
        }

        private void Dg_DoktorListesi_SelectionChanged(object sender, EventArgs e)
        {
            // DataGrid'de seçilen satırdaki bilgileri textbox'lara yerleşme
            Txt_Id.Text = dg_DoktorListesi.CurrentRow.Cells[0].Value.ToString();
            Txt_Tc.Text = dg_DoktorListesi.CurrentRow.Cells[1].Value.ToString();
            Txt_Ad.Text = dg_DoktorListesi.CurrentRow.Cells[2].Value.ToString();
            Txt_Soyad.Text = dg_DoktorListesi.CurrentRow.Cells[3].Value.ToString();
            Txt_Yas.Text = dg_DoktorListesi.CurrentRow.Cells[4].Value.ToString();
            Txt_Cinsiyet.Text = dg_DoktorListesi.CurrentRow.Cells[5].Value.ToString();
            Txt_Sifre.Text = dg_DoktorListesi.CurrentRow.Cells[6].Value.ToString();
            Txt_Il.Text = dg_DoktorListesi.CurrentRow.Cells[7].Value.ToString();
            Txt_Alan.Text = dg_DoktorListesi.CurrentRow.Cells[8].Value.ToString();
        }

        private void Btn_DoktorGuncelle_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (Txt_Id.Text != "" && Txt_Tc.Text != "" && Txt_Ad.Text != "" && Txt_Soyad.Text != "" && Txt_Yas.Text != "" && Txt_Cinsiyet.Text != "" && Txt_Alan.Text != "" && Txt_Sifre.Text != "" && Txt_Il.Text != "")
            {
                // Kontrolden sonra yeni bir doktor  nesnesi oluşturma
                EntityDoktor yDoktor = new EntityDoktor()
                {
                    Doktor_Id = int.Parse(Txt_Id.Text),
                    Doktor_Ad = Txt_Ad.Text,
                    Doktor_Soyad = Txt_Soyad.Text,
                    Doktor_Il = Txt_Il.Text,
                    Doktor_Sifre = Txt_Sifre.Text,
                    Doktor_Yas = int.Parse(Txt_Yas.Text),
                    Doktor_Alan = Txt_Alan.Text
                };

                // Oluşturulan ve içi doldurulan nesneyi database'de güncelleme
                BusinessDoktor.BLDoktorGuncelle(yDoktor);

                MessageBox.Show("Doktor Güncelleme İşlemi Başarılı...", "Güncelleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                // Güncelleme sonrası datagrid güncelleme
                DoktorListeGuncelle();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Güncelleme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Txt_Yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textbox'a harf girişini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_DoktorSil_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (Txt_Id.Text != "" && Txt_Tc.Text != "" && Txt_Ad.Text != "" && Txt_Soyad.Text != "" && Txt_Yas.Text != "" && Txt_Cinsiyet.Text != "" && Txt_Alan.Text != "" && Txt_Sifre.Text != "" && Txt_Il.Text != "")
            {
                // Kontrolden sonra yeni bir doktor  nesnesi oluşturma
                EntityDoktor yDoktor = new EntityDoktor()
                {
                    Doktor_Id = int.Parse(Txt_Id.Text)
                };

                // Oluşturulan ve Id tutan nesneyi / veriyi database'den silme
                BusinessDoktor.BLDoktorSil(yDoktor);

                MessageBox.Show("Hasta Silme İşlemi Başarılı...", "Silme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Silme sonrası datagrid güncelleme
                DoktorListeGuncelle();
            }
            else
            {
                MessageBox.Show("Hasta Silme İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Hasta İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
