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
    public partial class HastaKontrolPaneli : Form
    {
        public HastaKontrolPaneli()
        {
            InitializeComponent();
        }

        private void HastaListeGuncelle()
        {
            // Hastaları database'den datagrid'e veri aktarma
            dg_HastaListesi.DataSource = BusinessHasta.BLKHastaListele();
        }

        private void Btn_HastaGuncelle_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (Txt_Id.Text != "" && Txt_Tc.Text != "" && Txt_Ad.Text != "" && Txt_Soyad.Text != "" && Txt_Yas.Text != "" && Txt_Cinsiyet.Text != "" && Txt_AnneAdi.Text != "" && Txt_BabaAdi.Text != "" && Txt_Sifre.Text != "" && Txt_Il.Text != "")
            {
                // Kontrolden sonra yeni bir hasta nesnesi oluşturma
                EntityHasta yHasta = new EntityHasta()
                {
                    Hasta_Id = int.Parse(Txt_Id.Text),
                    Hasta_Ad = Txt_Ad.Text,
                    Hasta_Soyad = Txt_Soyad.Text,
                    Hasta_Il = Txt_Il.Text,
                    Hasta_Sifre = Txt_Sifre.Text,
                    Hasta_Yas = int.Parse(Txt_Yas.Text)
                };

                // Oluşturulan ve içi doldurulan nesneyi database'de güncelleme
                BusinessHasta.BLHastaGuncelle(yHasta);

                MessageBox.Show("Hasta Güncelleme İşlemi Başarılı...", "Güncelleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Güncelleme sonrası datagrid güncelleme
                HastaListeGuncelle();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Güncelleme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_HastaSil_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (Txt_Id.Text != "" && Txt_Tc.Text != "" && Txt_Ad.Text != "" && Txt_Soyad.Text != "" && Txt_Yas.Text != "" && Txt_Cinsiyet.Text != "" && Txt_AnneAdi.Text != "" && Txt_BabaAdi.Text != "" && Txt_Sifre.Text != "" && Txt_Il.Text != "")
            {
                // Kontrolden sonra yeni bir hasta nesnesi oluşturma
                EntityHasta yHasta = new EntityHasta()
                {
                    Hasta_Id = int.Parse(Txt_Id.Text)
                };

                // Oluşturulan ve Id tutan nesneyi / veriyi database'den silme
                BusinessHasta.BLHastaSil(yHasta);

                MessageBox.Show("Hasta Silme İşlemi Başarılı...", "Silme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Silme sonrası datagrid güncelleme
                HastaListeGuncelle();
            }
            else
            {
                MessageBox.Show("Hasta Silme İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Hasta İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HastaKontrolPaneli_Load(object sender, EventArgs e)
        {
            // Load ekranında sonrası datagrid güncelleme
            HastaListeGuncelle();

            // Yeni nesne oluşturma
            EntityHasta yHasta = new EntityHasta()
            {
                // Giriş Ekranındayken giriş yapan hastanın id'si label'a atılmıştı. Hasta Kontrol Panelinde ise o id'yi alıyoruz.
                Hasta_Id = int.Parse(Txt_Id.Text)
            };

            // Giriş ekranında aldığımız id ile o hastanın bilgilerini database'den çekme
            yHasta = BusinessHasta.BLHastaIdBilgiGetir(yHasta);

            //Database'den gelen bilgilerle ekrandaki gereken kısımları doldurmak
            Txt_Tc.Text = yHasta.Hasta_Tc;
            Txt_Ad.Text = yHasta.Hasta_Ad;
            Txt_Soyad.Text = yHasta.Hasta_Soyad;
            Txt_Yas.Text = yHasta.Hasta_Yas.ToString();
            Txt_Cinsiyet.Text = yHasta.Hasta_Cinsiyet;
            Txt_Sifre.Text = yHasta.Hasta_Sifre;
            Txt_AnneAdi.Text = yHasta.Hasta_AnneAdi;
            Txt_BabaAdi.Text = yHasta.Hasta_BabaAdi;
            Txt_Il.Text = yHasta.Hasta_Il;
        }

        private void Dg_HastaListesi_SelectionChanged(object sender, EventArgs e)
        {
            // DataGrid'de seçilen satırdaki bilgileri textbox'lara yerleşme
            Txt_Id.Text = dg_HastaListesi.CurrentRow.Cells[0].Value.ToString();
            Txt_Tc.Text = dg_HastaListesi.CurrentRow.Cells[1].Value.ToString();
            Txt_Ad.Text = dg_HastaListesi.CurrentRow.Cells[2].Value.ToString();
            Txt_Soyad.Text = dg_HastaListesi.CurrentRow.Cells[3].Value.ToString();
            Txt_Yas.Text = dg_HastaListesi.CurrentRow.Cells[4].Value.ToString();
            Txt_Cinsiyet.Text = dg_HastaListesi.CurrentRow.Cells[5].Value.ToString();
            Txt_Sifre.Text = dg_HastaListesi.CurrentRow.Cells[6].Value.ToString();
            Txt_AnneAdi.Text = dg_HastaListesi.CurrentRow.Cells[7].Value.ToString();
            Txt_BabaAdi.Text = dg_HastaListesi.CurrentRow.Cells[8].Value.ToString();
            Txt_Il.Text = dg_HastaListesi.CurrentRow.Cells[9].Value.ToString();
        }

        private void Txt_Yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textbox'a harf girişini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

