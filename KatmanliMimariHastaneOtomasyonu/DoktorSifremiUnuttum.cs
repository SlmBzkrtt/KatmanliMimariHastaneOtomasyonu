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
    public partial class DoktorSifremiUnuttum : Form
    {
        public DoktorSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void Txt_DoktorTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textbox'a harf girişini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_DoktorYas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textbox'a harf girişini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_DoktoruKontrolEt_Click(object sender, EventArgs e)
        {
            // TC ve Yas adı textbox'ları boş olup olmadığını kontrol etme
            if (txt_DoktorTC.Text != "" && txt_DoktorYas.Text != "")
            {
                // TC hane numarası kontrol etme
                if (txt_DoktorTC.Text.Length == 11)
                {
                    // Kontrolden sonra yeni bir doktor  nesnesi oluşturma
                    EntityDoktor yDoktor = new EntityDoktor()
                    {
                        Doktor_Tc = txt_DoktorTC.Text,
                        Doktor_Yas = int.Parse(txt_DoktorYas.Text)
                    };

                    // Girilen bilgileri database'de kontrol etme. Doğru ise enable özelliği false olan textbox'a değeri aktarma
                    txt_MevcutSifre.Text = BusinessDoktor.BLDoktorKontrolEt(yDoktor).ToString();

                    if (txt_MevcutSifre.Text == "")
                    {
                        MessageBox.Show("Aranan Hasta Bulunamadı. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Arama İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Arama İşlemi Başarısız oldu. T.C Kimlik Bilgisini(11 Hane) Doğru Şekilde Doldurunuz...", "Arama İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Arama İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Arama İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
