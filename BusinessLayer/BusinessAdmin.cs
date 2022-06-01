using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessAdmin
    {
        public static bool BLAdminKontrolEt(EntityAdmin a)
        {
            // Form ekranından gelen Admin nesnesinin Validation kontrolleri
            if (a.Admin_KullaniciAdi != null && a.Admin_Sifre != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALAdmin.AdminKontrolEt(a);
            }
            else
            {
                return false;
            }
        }
    }
}
