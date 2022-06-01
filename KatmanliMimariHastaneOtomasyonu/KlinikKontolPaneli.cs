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
    public partial class KlinikKontolPaneli : Form
    {
        public KlinikKontolPaneli()
        {
            InitializeComponent();
        }

        private void KlinikKontolPaneli_Load(object sender, EventArgs e)
        {
            // Load ekranında gerekli datagrid bilgilerini database'den doldurma
            KlinikListeGuncelle();
        }

        private void KlinikListeGuncelle()
        {
            // Gerekli datagrid bilgilerini database'den doldurma
            dg_Klinikler.DataSource = BusinessKlinik.BLKlinikListele();
        }

        private void Btn_KlinikEkle_Click(object sender, EventArgs e)
        {
            // Gerekli textbox'ların boş olup olmadığını kontrol etme
            if (txt_KlinikAdi.Text != "")
            {
                // Yeni klinik nesnesi oluşturma
                EntityKlinik yKlinik = new EntityKlinik()
                {
                    Klinik_Adi = txt_KlinikAdi.Text
                };

                // Eklenecek olan klinik nesnesini database'e yollanıyor.
                BusinessKlinik.BLKlinikEkle(yKlinik);

                MessageBox.Show("Yeni Klinik Kayıdı Başarılı...", "Kayıt İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Ekleme sonrası Datagrid güncelleme
                KlinikListeGuncelle();
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Dtg_Klinikler_SelectionChanged(object sender, EventArgs e)
        { 
            // DataGrid'te seçilen klinik bilgilerini textbox'lara aktarma
            txt_KlinikId.Text = dg_Klinikler.CurrentRow.Cells[0].Value.ToString();
            txt_KlinikAdi2.Text = dg_Klinikler.CurrentRow.Cells[1].Value.ToString();
        }

        private void Btn_KlinikSil_Click(object sender, EventArgs e)
        {
            // Gerekli textbox'ların boş olup olmadığını kontrol etme
            if (txt_KlinikAdi2.Text != "" && txt_KlinikId.Text != "")
            {
                // Yeni klinik nesnesi oluşturma
                EntityKlinik yKlinik = new EntityKlinik()
                {
                    Klinik_Id = int.Parse(txt_KlinikId.Text),
                    Klinik_Adi = txt_KlinikAdi2.Text
                };

                // Silinecek klinik id'si alınıp silinmek üzere database'e yollanıyor.
                BusinessKlinik.BLKlinikSil(yKlinik);

                MessageBox.Show("Klinik Silme İşlemi Başarılı...", "Silme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Silme sonrası Datagrid güncelleme
                KlinikListeGuncelle();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Silme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_KlinikGuncelle_Click(object sender, EventArgs e)
        {
            // Gerekli textbox'ların boş olup olmadığını kontrol etme
            if (txt_KlinikAdi2.Text != "" && txt_KlinikId.Text != "")
            {
                // Yeni klinik nesnesi oluşturma
                EntityKlinik yKlinik = new EntityKlinik()
                {
                    Klinik_Id = int.Parse(txt_KlinikId.Text),
                    Klinik_Adi = txt_KlinikAdi2.Text
                };

                // Oluşturulan nesneyi güncellemek için database'e gönderiliyor.
                BusinessKlinik.BLKlinikGuncelle(yKlinik);

                MessageBox.Show("Klinik Güncelleme İşlemi Başarılı...", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Güncelleme sonrası Datagrid güncelleme
                KlinikListeGuncelle();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Güncelleme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}