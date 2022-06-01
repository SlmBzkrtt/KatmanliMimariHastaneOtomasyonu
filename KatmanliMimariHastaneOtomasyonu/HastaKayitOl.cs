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
    public partial class HastaKayitOl : Form
    {
        public HastaKayitOl()
        {
            InitializeComponent();
            CinsiyetDoldur(); // Load'da cinsiyet doldurmak
        }

        private void CinsiyetDoldur()
        {
            // ComboBox'a değerleri atamak
            cmb_HastaCinsiyet.Items.Add("Erkek");
            cmb_HastaCinsiyet.Items.Add("Kadın");
        }

        private void Txt_HastaTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textbox'a harf girişini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_HastaYas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textbox'a harf girişini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_HastaKayitOl_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (txt_AnneAdi.Text != "" && txt_BabaAdi.Text != "" && txt_HastaAd.Text != "" && cmb_HastaCinsiyet.Text != "" && txt_HastaSifre.Text != "" && txt_HastaSoyad.Text != "" && txt_HastaTc.Text != "" && txt_HastaYas.Text != "" && txt_HastaIl.Text != "")
            {
                // TC uzunluğu kontrolü
                if (txt_HastaTc.Text.Length == 11)
                {
                    // Kontrolden sonra yeni bir hasta nesnesi oluşturma
                    EntityHasta yHasta = new EntityHasta()
                    {
                        Hasta_Tc = txt_HastaTc.Text,
                        Hasta_Ad = txt_HastaAd.Text,
                        Hasta_AnneAdi = txt_AnneAdi.Text,
                        Hasta_BabaAdi = txt_BabaAdi.Text,
                        Hasta_Cinsiyet = cmb_HastaCinsiyet.Text,
                        Hasta_Il = txt_HastaIl.Text,
                        Hasta_Sifre = txt_HastaSifre.Text,
                        Hasta_Soyad = txt_HastaSoyad.Text,
                        Hasta_Yas = int.Parse(txt_HastaYas.Text)
                    };

                    // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
                    BusinessHasta.BLHastaEkle(yHasta);

                    MessageBox.Show("Yeni Hasta Kayıdı Başarılı...", "Kayıt İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kayıt İşlemi Başarısız oldu. T.C Kimlik Bilgisini(11 Hane) Doğru Şekilde Doldurunuz...", "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Table Layout Panel'deki textbox'ları bulup eğer boşlarsa kullanıcıya uyarı göstermek
                foreach (Control yItem in tlp_HastaKayit.Controls)
                {
                    if (yItem is TextBox)
                    {
                        if (yItem.Text == "")
                        {
                            (yItem as TextBox).Text = "Bu Bilgiyi Doldurunuz...";
                            if ((yItem as TextBox).Name == "txt_HastaYas")
                            {
                                txt_HastaYas.Text = "99";
                            }
                        }
                    }
                }
                MessageBox.Show("Kayıt İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
