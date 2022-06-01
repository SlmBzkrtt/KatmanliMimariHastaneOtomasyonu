using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessDoktor
    {
        public static int BLDoktorEkle(EntityDoktor d)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (d.Doktor_Tc.Length == 11 && d.Doktor_Ad != null && d.Doktor_Soyad != null && d.Doktor_Yas < 100 && d.Doktor_Cinsiyet != null && d.Doktor_Sifre != null && d.Doktor_Il != null && d.Doktor_Alan != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALDoktor.DoktorEkle(d);
            }
            else
            {
                return -1;
            }
        }

        public static string BLDoktorKontrolEt(EntityDoktor d)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (d.Doktor_Tc.Length == 11 && d.Doktor_Yas != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALDoktor.DoktorKontrolEt(d);
            }
            else
            {
                return "";
            }
        }

        public static int BLDoktorGuncelle(EntityDoktor d)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (d.Doktor_Id != 0 && d.Doktor_Yas != 0 && d.Doktor_Ad != null && d.Doktor_Soyad != null && d.Doktor_Sifre != null && d.Doktor_Il != null && d.Doktor_Alan != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALDoktor.DoktorGuncelle(d);
            }
            else
            {
                return -1;
            }
        }

        public static int BLDoktorSil(EntityDoktor d)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleris
            if (d.Doktor_Id != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALDoktor.DoktorSil(d);
            }
            else
            {
                return -1;
            }
        }

        public static int BLDoktorIdBul(string DoktorAdi)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (DoktorAdi != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALDoktor.DoktorIdBul(DoktorAdi);
            }
            else
            {
                return -1;
            }
        }

        public static int BLDoktorIdBul(EntityDoktor e)
        {
            // Form ekranından gelen Hasta nesnesinin Validation kontrolleri
            if (e.Doktor_Tc != null && e.Doktor_Sifre != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALDoktor.DoktorIdBul(e);
            }
            else
            {
                return -1;
            }
        }

        public static List<EntityDoktor> BLKDoktorListele()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALDoktor.DoktorListele();
        }

        public static List<EntityDoktor> BLKDoktorAdiListele()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALDoktor.DoktorAdiListele();
        }

        public static List<string> BLDoktorCmbDoldur(string Alan)
        {
            // Gelen nesne DAL Katmanındaki Fonksiyona yollanıyor.
            return DALDoktor.DoktorCmbDoldur(Alan);
        }

        
    }
}
