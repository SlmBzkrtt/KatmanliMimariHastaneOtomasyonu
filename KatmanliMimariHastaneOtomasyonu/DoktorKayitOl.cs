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
    public partial class DoktorKayitOl : Form
    {
        public DoktorKayitOl()
        {
            InitializeComponent();
            CinsiyetDoldur(); // Load'da cinsiyet doldurmak
            AlanDoldur(); // Load'da doktor alanlarını doldurmak
        }

        private void CinsiyetDoldur()
        {
            // ComboBox'a değerleri atamak
            cmb_DoktorCinsiyet.Items.Add("Erkek");
            cmb_DoktorCinsiyet.Items.Add("Kadın");
        }

        private void AlanDoldur()
        {
            // ComboBox'a değeleri Database'den çekmek
            cmb_DoktorAlan.DataSource = BusinessKlinik.BLKlinikCmbDoldur();
        }

        private void Btn_DoktorKayitOl_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (cmb_DoktorAlan.Text != "" && txt_DoktorAd.Text != "" && cmb_DoktorCinsiyet.Text != "" && txt_DoktorSifre.Text != "" && txt_DoktorSoyad.Text != "" && txt_DoktorTc.Text != "" && txt_DoktorYas.Text != "" && txt_DoktorIl.Text != "")
            {
                // TC uzunluğu kontrolü
                if (txt_DoktorTc.Text.Length == 11)
                {
                    // Kontrolden sonra yeni bir doktor  nesnesi oluşturma
                    EntityDoktor yDoktor = new EntityDoktor()
                    {
                        Doktor_Tc = txt_DoktorTc.Text,
                        Doktor_Ad = txt_DoktorAd.Text,
                        Doktor_Soyad = txt_DoktorSoyad.Text,
                        Doktor_Alan = cmb_DoktorAlan.Text,
                        Doktor_Cinsiyet = cmb_DoktorCinsiyet.Text,
                        Doktor_Il = txt_DoktorIl.Text,
                        Doktor_Sifre = txt_DoktorSifre.Text,
                        Doktor_Yas = int.Parse(txt_DoktorYas.Text)
                    };

                    // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
                    BusinessDoktor.BLDoktorEkle(yDoktor);

                    MessageBox.Show("Yeni Doktor Kayıdı Başarılı...", "Kayıt İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                foreach (Control yItem in tlp_DoktorKayit.Controls)
                {
                    if (yItem is TextBox)
                    {
                        if (yItem.Text == "")
                        {
                            (yItem as TextBox).Text = "Bu Bilgiyi Doldurunuz...";
                            if ((yItem as TextBox).Name == "txt_DoktorYas")
                            {
                                txt_DoktorYas.Text = "99";
                            }
                        }
                    }
                }
                MessageBox.Show("Kayıt İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Txt_DoktorTc_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
