using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessRecete
    {
        public static int BLReceteEkle(EntityRecete r)
        {
            // Form ekranından gelen Doktor nesnesinin Validation kontrolleri
            if (r.Hasta_Id != 0 && r.Doktor_Id != 0 && r.Doktor_Aciklama != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALRecete.ReceteEkle(r);
            }
            else
            {
                return -1;
            }
        }
    }
}
