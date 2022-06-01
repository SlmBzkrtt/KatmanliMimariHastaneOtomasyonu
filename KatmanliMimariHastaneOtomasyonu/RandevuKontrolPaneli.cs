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
    public partial class RandevuKontrolPaneli : Form
    {
        public RandevuKontrolPaneli()
        {
            InitializeComponent();
        }

        private void RandevuListeGuncelle()
        {
            dg_Randevular.DataSource = BusinessRandevu.BLRandevuListele();
        }

        private void RandevuKontrolPaneli_Load(object sender, EventArgs e)
        {
            // Load ekranında gerekli datagrid bilgilerini database'den doldurma

            dg_Klinikler.DataSource = BusinessKlinik.BLKlinikListele();
            dg_Hastalar.DataSource = BusinessHasta.BLKHastaAdiListele();

            RandevuListeGuncelle();
        }

        private void Dg_Randevular_SelectionChanged(object sender, EventArgs e)
        {
            // DataGrid'te seçilen randevunun bilgilerini textbox'lara aktarma
            txt_RandevuId.Text = dg_Randevular.CurrentRow.Cells[0].Value.ToString();
            txt_RandevuTarihi.Text = dg_Randevular.CurrentRow.Cells[1].Value.ToString();
            txt_RandevuSaati.Text = dg_Randevular.CurrentRow.Cells[2].Value.ToString();
            txt_DoktorId.Text = dg_Randevular.CurrentRow.Cells[3].Value.ToString();
            txt_HastaId.Text = dg_Randevular.CurrentRow.Cells[4].Value.ToString();
            txt_KlinikId.Text = dg_Randevular.CurrentRow.Cells[5].Value.ToString();
        }

        private void Btn_RandevuGuncelle_Click(object sender, EventArgs e)
        {
            // Gerekli textbox'ların boş olup olmadığını kontrol etme
            if (txt_RandevuId.Text != "" && txt_KlinikId.Text != "" && txt_HastaId.Text != "" && txt_DoktorId.Text != "" && txt_RandevuSaati.Text != "" && txt_RandevuTarihi.Text != "")
            {
                // Yeni randevu nesnesi oluşturma
                EntityRandevu yRandevu = new EntityRandevu()
                {
                    Doktor_Id = int.Parse(txt_DoktorId.Text),
                    Hasta_Id = int.Parse(txt_HastaId.Text),
                    Klinik_Id = int.Parse(txt_KlinikId.Text),
                    Randevu_Id = int.Parse(txt_RandevuId.Text),
                    Randevu_Saati = txt_RandevuSaati.Text,
                    Randevu_Tarihi = txt_RandevuTarihi.Text,
                };

                // Oluşturulan nesneyi güncellemek için database'e gönderiliyor.
                BusinessRandevu.BLRandevuGuncelle(yRandevu);

                MessageBox.Show("Randevu Güncelleme İşlemi Başarılı...", "Güncelleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Güncelleme sonrası Datagrid güncelleme
                RandevuListeGuncelle();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Güncelleme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_RandevuSil_Click(object sender, EventArgs e)
        {
            // Gerekli textbox'ların boş olup olmadığını kontrol etme
            if (txt_RandevuId.Text != "" && txt_HastaId.Text != "" && txt_DoktorId.Text != "" && txt_KlinikId.Text != "" && txt_RandevuSaati.Text != "" && txt_RandevuTarihi.Text != "")
            {
                // Yeni randevu nesnesi oluşturma
                EntityRandevu yRandevu = new EntityRandevu()
                {
                    Randevu_Id = int.Parse(txt_RandevuId.Text)
                };

                // Silinecek randevunun id'si alınıp silinmek üzere database'e yollanıyor.
                BusinessRandevu.BLRandevuSil(yRandevu);

                MessageBox.Show("Randevu Silme İşlemi Başarılı...", "Silme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Güncelleme sonrası Datagrid güncelleme
                RandevuListeGuncelle();
            }
            else
            {
                MessageBox.Show("Randevu Silme İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Silme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
