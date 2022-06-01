using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessKlinik
    {
        public static int BLKlinikEkle(EntityKlinik k)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (k.Klinik_Adi != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALKlinik.KlinikEkle(k);
            }
            else
            {
                return -1;
            }
        }
        public static int BLKlinikGuncelle(EntityKlinik k)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (k.Klinik_Adi != null && k.Klinik_Id != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALKlinik.KlinikGuncelle(k);
            }
            else
            {
                return -1;
            }
        }

        public static int BLKlinikSil(EntityKlinik k)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (k.Klinik_Id != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALKlinik.KlinikSil(k);
            }
            else
            {
                return -1;
            }
        }

        public static int BLKlinikIdBul(string KlinikAdi)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (KlinikAdi != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALKlinik.KlinikIdBul(KlinikAdi);
            }
            else
            {
                return -1;
            }
        }

        public static List<EntityKlinik> BLKlinikListele()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALKlinik.KlinikListele();
        }

        public static List<string> BLKlinikCmbDoldur()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALKlinik.KlinikCmbDoldur();
        }

        
    }
}
