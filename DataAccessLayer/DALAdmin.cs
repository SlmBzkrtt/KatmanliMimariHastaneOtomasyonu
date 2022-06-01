using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALAdmin
    {
        public static bool AdminKontrolEt(EntityAdmin gAdmin)
        {
            // Admin giriş yap butonunda çalışan kod satırı,Form ekranından Kullanici adı ve şifre geliyor.
            OleDbCommand cmd = new OleDbCommand("Select * From Admin Where Admin_KullaniciAdi = @Admin_KullaniciAdi And Admin_Sifre = @Admin_Sifre", Baglanti.conn);
            // Kullanici adi ve şifre gelen kişinin admin bilgilerini geri döndür.
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Admin_KullaniciAdi", gAdmin.Admin_KullaniciAdi);
            cmd.Parameters.AddWithValue("@Admin_Sifre", gAdmin.Admin_Sifre);

            OleDbDataReader dr = cmd.ExecuteReader();
            bool Sonuc = false;
            int sayac = 0;

            while (dr.Read())
            {
                sayac++; //Eğer okunacak bir veri var ise sayacı arttır.
            }

            if (sayac > 0)
            {
                // eğer sayac 0'dan büyükse sonucu true yap
                Sonuc = true;
            }
            //Eğer true sonuc dönüyorsa. Gelen bilgilerle eşleşen admin var. Giriş yapabilir demektir.
            return Sonuc;
        }
    }
}
