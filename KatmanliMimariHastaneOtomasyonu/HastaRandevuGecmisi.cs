using BusinessLayer;
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
    public partial class HastaRandevuGecmisi : Form
    {
        public HastaRandevuGecmisi()
        {
            InitializeComponent();
        }

        private void HastaRandevuGecmisi_Load(object sender, EventArgs e)
        {
            // Load ekranında gerekli datagrid bilgilerini database'den doldurma

            dg_Doktorlar.DataSource = BusinessDoktor.BLKDoktorAdiListele();
            dg_Klinikler.DataSource = BusinessKlinik.BLKlinikListele();

            dg_Randevular.DataSource = BusinessRandevu.BLRandevuHastaListele(int.Parse(txt_HastaId.Text));
        }
    }
}
