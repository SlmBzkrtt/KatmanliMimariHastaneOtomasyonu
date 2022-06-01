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
    public partial class HastaSifremiUnuttum : Form
    {
        public HastaSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void Txt_HastaTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textbox'a harf girişini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_HastayiKontrolEt_Click(object sender, EventArgs e)
        {
            // TC ve Anne adı textbox'ları boş olup olmadığını kontrol etme
            if (txt_HastaTC.Text != "" && txt_HastaAnne.Text != "")
            {
                // TC hane numarası kontrol etme
                if (txt_HastaTC.Text.Length == 11)
                {
                    // Kontrolden sonra yeni bir hasta nesnesi oluşturma
                    EntityHasta yHasta = new EntityHasta()
                    {
                        Hasta_Tc = txt_HastaTC.Text,
                        Hasta_AnneAdi = txt_HastaAnne.Text
                    };

                    // Girilen bilgileri database'de kontrol etme. Doğru ise enable özelliği false olan textbox'a değeri aktarma
                    txt_MevcutSifre.Text = BusinessHasta.BLHastaKontrolEt(yHasta).ToString();

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
