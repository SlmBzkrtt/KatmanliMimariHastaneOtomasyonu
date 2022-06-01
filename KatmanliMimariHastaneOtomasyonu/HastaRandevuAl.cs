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
    public partial class HastaRandevuAl : Form
    {
        public HastaRandevuAl()
        {
            InitializeComponent();
        }

        private void RandevuSaatiDoldur()
        {
            // Randevu Saatini saatte 1 olacak şekilde dolduruluyor
            for (int i = 9; i < 19; i++)
            {
                cmb_RandevuSaati.Items.Add(i + ".00");
            }
        }

        private void HastaRandevuAl_Load(object sender, EventArgs e)
        {
            // Klinik bilgilerini database'den doldur
            cmb_Klinik.DataSource = BusinessKlinik.BLKlinikCmbDoldur();
            
            RandevuSaatiDoldur();

            EntityHasta yHasta = new EntityHasta()
            {
                Hasta_Id = int.Parse(lbl_Id.Text)
            };

            // Giriş ekranından gelen hasta Id'sini kullanarak hastanın bilgilerini form'a database'den çekmek.
            yHasta = BusinessHasta.BLHastaIdBilgiGetir(yHasta);

            //Gelen bilgileri nesneye aktarıp nesneden label'ları dolduruluyor.
            lbl_AdSoyad.Text = yHasta.Hasta_Ad + " " + yHasta.Hasta_Soyad + "        ";
            lbl_TC.Text = yHasta.Hasta_Tc + "        ";
            lbl_Il.Text = yHasta.Hasta_Il + "        ";
            lbl_Yas.Text = yHasta.Hasta_Yas.ToString() + "        ";
            lbl_Cinsiyet.Text = yHasta.Hasta_Cinsiyet + "           ";
        }

        private void Pb_BilgileriGuncelle_Click(object sender, EventArgs e)
        {
            HastaKontrolPaneli HKP = new HastaKontrolPaneli();
            HKP.dg_HastaListesi.Visible = false;
            HKP.Btn_HastaSil.Visible = false;
            //Yeni form açılmadan sadece admine özel olan hastanın görmemesi gereken yerler visible = false ile kapatıldı.
            HKP.Txt_Id.Text = lbl_Id.Text; // Hasta Id yeni form'a atanyor.
            HKP.ShowDialog();
        }

        private void Pb_RandevuGecmisi_Click(object sender, EventArgs e)
        {
            //Hastanın randevu geçmişi formunun açıldığı kısım
            HastaRandevuGecmisi HRG = new HastaRandevuGecmisi();
            HRG.txt_HastaId.Text = lbl_Id.Text;
            HRG.ShowDialog();
        }

        private void Cmb_Klinik_SelectedValueChanged(object sender, EventArgs e)
        {
            string KlinikAdi = cmb_Klinik.Text;
            cmb_Doktor.DataSource = BusinessDoktor.BLDoktorCmbDoldur(KlinikAdi);

            // Seçilen değeri randevu kayıt öncesi label'a atanıyor
            lbl_RandevuKlinik.Text = KlinikAdi;
        }

        private void Cmb_Doktor_SelectedValueChanged(object sender, EventArgs e)
        {
            // Seçilen değeri randevu kayıt öncesi label'a atanıyor
            lbl_RandevuDoktor.Text = cmb_Doktor.Text;
        }

        private void Dtp_RandevuTarihi_ValueChanged(object sender, EventArgs e)
        {
            // Seçilen değeri randevu kayıt öncesi label'a atanıyor
            lbl_RandevuTarihi.Text = dtp_RandevuTarihi.Text;
        }

        private void Cmb_RandevuSaati_SelectedValueChanged(object sender, EventArgs e)
        {
            // Seçilen değeri randevu kayıt öncesi label'a atanıyor
            lbl_RandevuSaati.Text = cmb_RandevuSaati.Text;
        }

        private void Btn_RandevuKaydet_Click(object sender, EventArgs e)
        {
            // Gerekli textbox'ların boş olup olmadığını kontrol etme
            if (cmb_Doktor.Text != "" && cmb_Klinik.Text != "" && dtp_RandevuTarihi.Text != "" && cmb_RandevuSaati.Text != "")
            {
                // ComboBox'lardan seçilen bilgilerin ID bilgilerini alma
                string KlinikAdi = cmb_Klinik.Text;
                int Klinik_ID = BusinessKlinik.BLKlinikIdBul(KlinikAdi);

                string DoktorAdi = cmb_Doktor.Text;
                int Doktor_ID = BusinessDoktor.BLDoktorIdBul(DoktorAdi);

                // Yeni nesne oluşturma
                EntityRandevu yRandevu = new EntityRandevu()
                {
                    Doktor_Id = Doktor_ID,
                    Hasta_Id = int.Parse(lbl_Id.Text),
                    Klinik_Id = Klinik_ID,
                    Randevu_Saati = lbl_RandevuSaati.Text,
                    Randevu_Tarihi = lbl_RandevuTarihi.Text
                };

                // Oluşturulan ve içeriği doldurulan nesneyi database yüklemek
                BusinessRandevu.BLRandevuEkle(yRandevu);

                MessageBox.Show("Yeni Randevu Kayıdı Başarılı...", "Kayıt İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
