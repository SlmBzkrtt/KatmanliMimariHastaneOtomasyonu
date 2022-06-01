using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessRandevu
    {
        public static int BLRandevuEkle(EntityRandevu r)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (r.Klinik_Id != 0 && r.Hasta_Id != 0 && r.Randevu_Saati != null && r.Doktor_Id != 0 && r.Randevu_Tarihi != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALRandevu.Randevuekle(r);
            }
            else
            {
                return -1;
            }
        }

        public static int BLRandevuGuncelle(EntityRandevu r)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (r.Randevu_Id != 0 && r.Klinik_Id != 0 && r.Hasta_Id != 0 && r.Doktor_Id != 0 && r.Randevu_Saati != null && r.Randevu_Tarihi != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALRandevu.RandevuGuncelle(r);
            }
            else
            {
                return -1;
            }
        }

        public static int BLRandevuSil(EntityRandevu r)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (r.Randevu_Id != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALRandevu.RandevuSil(r);
            }
            else
            {
                return -1;
            }
        }

        public static List<EntityRandevu> BLRandevuHastaListele(int HastaID)
        {
            // Gelen nesne DAL Katmanındaki Fonksiyona yollanıyor.
            return DALRandevu.RandevuHastaListele(HastaID);
        }

        public static List<EntityRandevu> BLRandevuListele()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALRandevu.RandevuListele();
        }
    }
}
