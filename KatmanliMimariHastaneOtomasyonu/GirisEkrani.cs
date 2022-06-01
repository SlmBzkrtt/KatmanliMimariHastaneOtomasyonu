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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
            Acilis Ac = new Acilis();
            //Ac.ShowDialog();
        }

        private void Txt_HastaTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textbox'a harf girişini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_DoktorTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textbox'a harf girişini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_KayitOlHasta_Click_1(object sender, EventArgs e)
        {
            // Yeni Form Ekranına geçiş
            HastaKayitOl HKO = new HastaKayitOl();
            HKO.ShowDialog();
        }

        private void Btn_KayitOlDoktor_Click(object sender, EventArgs e)
        {
            // Yeni Form Ekranına geçiş
            DoktorKayitOl DKO = new DoktorKayitOl();
            DKO.ShowDialog();
        }

        private void Btn_SifremiUnuttumDoktor_Click(object sender, EventArgs e)
        {
            // Yeni Form Ekranına geçiş
            DoktorSifremiUnuttum DSU = new DoktorSifremiUnuttum();
            DSU.ShowDialog();
        }

        private void Btn_SifremiUnuttumHasta_Click(object sender, EventArgs e)
        {
            // Yeni Form Ekranına geçiş
            HastaSifremiUnuttum HSU = new HastaSifremiUnuttum();
            HSU.ShowDialog();
        }

        private void Btn_AdminGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcı Adı ve şifre boşluk kontrolü
            if (txt_AdminKullaniciAdi.Text != "" && txt_AdminSifre.Text != "")
            {
                // Kontrolden sonra yeni bir admin nesnesi oluşturma
                EntityAdmin yAdmin = new EntityAdmin()
                {
                    Admin_KullaniciAdi = txt_AdminKullaniciAdi.Text,
                    Admin_Sifre = txt_AdminSifre.Text
                };

                //Oluşturulan nesneyi gönderip girişin doğruluğunu kontrol etme
                if (BusinessAdmin.BLAdminKontrolEt(yAdmin) == true)
                {
                    // Yeni Form Ekranına geçiş
                    AdminKontrolPaneli AKP = new AdminKontrolPaneli();

                    //Giriş yaparken giren kullanıcın Kullanıcı adını açılacak olan form'a gönderme.
                    AKP.lbl_AdminAciklama.Text = "'" + txt_AdminKullaniciAdi.Text + "' olarak giriş Yapılmıştır. Soldaki menüden işlemlerinizi gerçekleştirebilirsiniz...";

                    //Giriş sonrası textboxları temizleme
                    txt_AdminKullaniciAdi.Text = "";
                    txt_AdminSifre.Text = "";
                    AKP.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Giriş İşlemi Başarısız Oldu. Admin Kullanıcı Adı Veya Şifre Hatalı. Lütfen Tekrar Deneyiniz...", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Giriş İşlemi Başarısız Oldu. Admin Kullanıcı Adı Veya Şifre Hatalı. Lütfen Tekrar Deneyiniz...", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_GirisYapHasta_Click(object sender, EventArgs e)
        {
            // TC ve şifre boşluk kontrolü
            if (txt_HastaTC.Text != "" && txt_HastaSifre.Text != "")
            {
                // TC uzunluğu kontrolü
                if (txt_HastaTC.Text.Length == 11)
                {
                    // Kontrolden sonra yeni bir hasta nesnesi oluşturma
                    HastaRandevuAl HRA = new HastaRandevuAl();

                    EntityHasta yHasta = new EntityHasta()
                    {
                        Hasta_Tc = txt_HastaTC.Text,
                        Hasta_Sifre = txt_HastaSifre.Text
                    };

                    //Giriş Yapan hastanın Tc ve şifre bilgilerini yollayıp id bilgisini almak...
                    int HastaId = BusinessHasta.BLHastaIdBul(yHasta);

                    //Eğer bir id döndüyse yani Id > 0 ise
                    if (HastaId > 0)
                    {
                        // Gelen Hasta_Id'sini Açılacak olan formdaki label nesnesine yollama..
                        HRA.lbl_Id.Text = HastaId.ToString();
                        HRA.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Giriş İşlemi Başarısız Oldu. Hasta TC Veya Şifre Hatalı. Lütfen Tekrar Deneyiniz...", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Giriş İşlemi Başarısız oldu. T.C Kimlik Bilgisini(11 Hane) Doğru Şekilde Doldurunuz...", "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Giriş İşlemi Başarısız Oldu. Hasta TC Veya Şifre Hatalı. Lütfen Tekrar Deneyiniz...", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_GirisYapDoktor_Click(object sender, EventArgs e)
        {
            // TC ve şifre boşluk kontrolü
            if (txt_DoktorTC.Text != "" && txt_DoktorSifre.Text != "")
            {
                // TC uzunluğu kontrolü
                if (txt_DoktorTC.Text.Length == 11)
                {
                    // Kontrolden sonra yeni bir hasta nesnesi oluşturma
                    DoktorReceteYaz DRY = new DoktorReceteYaz();

                    EntityDoktor yDoktor = new EntityDoktor()
                    {
                        Doktor_Tc = txt_DoktorTC.Text,
                        Doktor_Sifre = txt_DoktorSifre.Text
                    };

                    //Giriş Yapan hastanın Tc ve şifre bilgilerini yollayıp id bilgisini almak...
                    int DoktorId = BusinessDoktor.BLDoktorIdBul(yDoktor);

                    //Eğer bir id döndüyse yani Id > 0 ise
                    if (DoktorId > 0)
                    {
                        // Gelen Doktor_Id'sini Açılacak olan formdaki label nesnesine yollama..
                        DRY.txt_DoktorId.Text = DoktorId.ToString();
                        DRY.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Giriş İşlemi Başarısız Oldu. Hasta TC Veya Şifre Hatalı. Lütfen Tekrar Deneyiniz...", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Giriş İşlemi Başarısız oldu. T.C Kimlik Bilgisini(11 Hane) Doğru Şekilde Doldurunuz...", "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Giriş İşlemi Başarısız Oldu. Hasta TC Veya Şifre Hatalı. Lütfen Tekrar Deneyiniz...", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
