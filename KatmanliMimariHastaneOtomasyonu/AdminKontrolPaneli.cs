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
    public partial class AdminKontrolPaneli : Form
    {
        public AdminKontrolPaneli()
        {
            InitializeComponent();
        }

        private void Pb_Hasta_Click(object sender, EventArgs e)
        {
            // Yeni Form Ekranına geçiş
            HastaKontrolPaneli HKP = new HastaKontrolPaneli();
            HKP.ShowDialog();
        }

        private void Pb_Doktor_Click(object sender, EventArgs e)
        {
            // Yeni Form Ekranına geçiş
            DoktorKontrolPaneli DKP = new DoktorKontrolPaneli();
            DKP.ShowDialog();
        }

        private void Pb_Klinik_Click(object sender, EventArgs e)
        {
            // Yeni Form Ekranına geçiş
            KlinikKontolPaneli KKP = new KlinikKontolPaneli();
            KKP.ShowDialog();
        }

        private void Pb_Randevu_Click(object sender, EventArgs e)
        {
            // Yeni Form Ekranına geçiş
            RandevuKontrolPaneli RKP = new RandevuKontrolPaneli();
            RKP.ShowDialog();
        }

        private void Pb_Cikis_Click(object sender, EventArgs e)
        {
            // Admin panelinden çıkış
            this.Close();
        }
    }
}
