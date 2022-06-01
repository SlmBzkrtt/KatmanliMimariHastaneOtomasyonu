using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessHasta
    {
        public static int BLHastaEkle(EntityHasta h)
        {
            // Form ekranından gelen Hasta nesnesinin Validation kontrolleri
            if (h.Hasta_Tc.Length == 11 && h.Hasta_Ad != null && h.Hasta_Soyad != null && h.Hasta_Yas < 100 && h.Hasta_Cinsiyet != null && h.Hasta_Sifre != null && h.Hasta_AnneAdi != null && h.Hasta_BabaAdi != null && h.Hasta_Il != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALHasta.HastaEkle(h);
            }
            else
            {
                return -1;
            }
        }

        public static string BLHastaKontrolEt(EntityHasta h)
        {
            // Form ekranından gelen Hasta nesnesinin Validation kontrolleri
            if (h.Hasta_Tc.Length == 11 && h.Hasta_AnneAdi != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALHasta.HastaKontrolEt(h);
            }
            else
            {
                return "";
            }
        }

        public static int BLHastaGuncelle(EntityHasta h)
        {
            // Form ekranından gelen Hasta nesnesinin Validation kontrolleri
            if (h.Hasta_Id != 0 && h.Hasta_Yas != 0 && h.Hasta_Ad != null && h.Hasta_Soyad != null && h.Hasta_Sifre != null && h.Hasta_Il != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALHasta.HastaGuncelle(h);
            }
            else
            {
                return -1;
            }
        }

        public static int BLHastaSil(EntityHasta h)
        {
            // Form ekranından gelen Hasta nesnesinin Validation kontrolleri
            if (h.Hasta_Id != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALHasta.HastaSil(h);
            }
            else
            {
                return -1;
            }
        }

        public static int BLHastaIdBul(EntityHasta h)
        {
            // Form ekranından gelen Hasta nesnesinin Validation kontrolleri
            if (h.Hasta_Tc != null && h.Hasta_Sifre != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALHasta.HastaIdBul(h);
            }
            else
            {
                return -1;
            }
        }

        public static EntityHasta BLHastaIdBilgiGetir(EntityHasta h)
        {
            // Form ekranından gelen Hasta nesnesinin Validation kontrolleri
            if (h.Hasta_Id != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALHasta.HastaIdBilgiGetir(h);
            }
            else
            {
                return h;
            }
        }

        public static List<EntityHasta> BLKHastaListele()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALHasta.HastaListele();
        }

        public static List<string> BLHastaaCmbDoldur()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALHasta.HastaCmbDoldur();
        }

        public static List<EntityHasta> BLKHastaAdiListele()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALHasta.HastaAdiListele();
        }

        
    }
}
