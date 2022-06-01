using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityHasta
    {
        // Hasta tablosunun değerlerini atama (DTO)
        int hasta_Id;

        string hasta_Tc;

        string hasta_Ad;

        string hasta_Soyad;

        int hasta_Yas;

        string hasta_Cinsiyet;

        string hasta_Sifre;

        string hasta_AnneAdi;

        string hasta_BabaAdi;

        string hasta_Il;

        public int Hasta_Id { get => hasta_Id; set => hasta_Id = value; }
        public string Hasta_Tc { get => hasta_Tc; set => hasta_Tc = value; }
        public string Hasta_Ad { get => hasta_Ad; set => hasta_Ad = value; }
        public string Hasta_Soyad { get => hasta_Soyad; set => hasta_Soyad = value; }
        public int Hasta_Yas { get => hasta_Yas; set => hasta_Yas = value; }
        public string Hasta_Cinsiyet { get => hasta_Cinsiyet; set => hasta_Cinsiyet = value; }
        public string Hasta_Sifre { get => hasta_Sifre; set => hasta_Sifre = value; }
        public string Hasta_AnneAdi { get => hasta_AnneAdi; set => hasta_AnneAdi = value; }
        public string Hasta_BabaAdi { get => hasta_BabaAdi; set => hasta_BabaAdi = value; }
        public string Hasta_Il { get => hasta_Il; set => hasta_Il = value; }
    }
}
