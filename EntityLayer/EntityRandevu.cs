using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityRandevu
    {
        // Randevu tablosunun değerlerini atama (DTO)
        int randevu_Id;

        string randevu_Tarihi;

        string randevu_Saati;

        int doktor_Id;

        int hasta_Id;

        int klinik_Id;

        public int Randevu_Id { get => randevu_Id; set => randevu_Id = value; }
        public string Randevu_Tarihi { get => randevu_Tarihi; set => randevu_Tarihi = value; }
        public string Randevu_Saati { get => randevu_Saati; set => randevu_Saati = value; }
        public int Doktor_Id { get => doktor_Id; set => doktor_Id = value; }
        public int Hasta_Id { get => hasta_Id; set => hasta_Id = value; }
        public int Klinik_Id { get => klinik_Id; set => klinik_Id = value; }
    }
}
