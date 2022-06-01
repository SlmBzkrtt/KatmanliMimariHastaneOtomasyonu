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
    public partial class DoktorReceteYaz : Form
    {
        public DoktorReceteYaz()
        {
            InitializeComponent();
        }

        private void DoktorReceteYaz_Load(object sender, EventArgs e)
        {
            cmb_Hastalar.DataSource = BusinessHasta.BLHastaaCmbDoldur();
            dg_Hastalar.DataSource = BusinessHasta.BLKHastaAdiListele();
        }

        private void Btn_ReceteYaz_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün değerlerin dolu olduğunu kontrol etme
            if (txt_DoktorId.Text != "" && txt_Recete.Text != "" && cmb_Hastalar.Text != "")
            {
                // Kontrolden sonra yeni bir recete nesnesi oluşturma
                EntityRecete yRecete = new EntityRecete()
                {
                    Doktor_Aciklama = txt_Recete.Text,
                    Hasta_Id = int.Parse(cmb_Hastalar.Text),
                    Doktor_Id = int.Parse(txt_DoktorId.Text)
                };

                // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
                BusinessRecete.BLReceteEkle(yRecete);

                MessageBox.Show("Yeni Reçete Kayıdı Başarılı...", "Kayıt İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi Başarısız oldu. Lütfen Tüm Bilgileri Doğru Şekilde Doldurunuz...", "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
