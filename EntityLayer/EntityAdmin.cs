using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityAdmin
    {
        // Admin tablosunun değerlerini atama (DTO)

        int admin_Id;

        string admin_KullaniciAdi;

        string admin_Sifre;

        public int Admin_Id { get => admin_Id; set => admin_Id = value; }
        public string Admin_KullaniciAdi { get => admin_KullaniciAdi; set => admin_KullaniciAdi = value; }
        public string Admin_Sifre { get => admin_Sifre; set => admin_Sifre = value; }
    }
}
