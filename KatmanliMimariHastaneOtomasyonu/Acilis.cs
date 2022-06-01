using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimariHastaneOtomasyonu
{
    public partial class Acilis : Form
    {
        public Acilis()
        {
            InitializeComponent();
        }

        private int Saniye = 6;
        private int Sayac = 0;
        public string[] Giris = new string[] { "Database Bağlantısı Kuruluyor", "Gerekli Ön Yüklemeler Yapılıyor", "Kod Dizileri Tanımlanıyor", "Son Düzeltmeler Yapılıyor", "Program Açılıyor" };

        private void TimerGiris_Tick(object sender, EventArgs e)
        {
            Saniye--;
            lblSayac.Text = Saniye + " Saniye Sonra Program Açıklacaktır.";
            lbl_Yukleme.Text = Giris[Sayac];
            Sayac++;
            if (Sayac == 5)
            {
                Sayac = 0;
            }

            if (Saniye == 0)
            {
                timerGiris.Stop();
                TimerBar.Stop();
                Thread.Sleep(1000);
                this.Close();
            }
        }

        private void TimerBar_Tick(object sender, EventArgs e)
        {
            AcilisBar.Value += 2;
            if (AcilisBar.Value == 100)
            {
                TimerBar.Stop();
            }
        }

        private void Acilis_Load(object sender, EventArgs e)
        {
            timerGiris.Start();
            timerGiris.Interval = 1000;
            TimerBar.Start();
            TimerBar.Interval = 100;
        }
    }
}
