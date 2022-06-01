using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDoktor
    {
        // Doktor tablosunun değerlerini atama (DTO)
        int doktor_Id;

        string doktor_Tc;

        string doktor_Ad;

        string doktor_Soyad;    

        int doktor_Yas;

        string doktor_Cinsiyet;

        string doktor_Sifre;

        string doktor_Il;

        string doktor_Alan;

        public int Doktor_Id { get => doktor_Id; set => doktor_Id = value; }
        public string Doktor_Tc { get => doktor_Tc; set => doktor_Tc = value; }
        public string Doktor_Ad { get => doktor_Ad; set => doktor_Ad = value; }
        public string Doktor_Soyad { get => doktor_Soyad; set => doktor_Soyad = value; }
        public int Doktor_Yas { get => doktor_Yas; set => doktor_Yas = value; }
        public string Doktor_Cinsiyet { get => doktor_Cinsiyet; set => doktor_Cinsiyet = value; }
        public string Doktor_Sifre { get => doktor_Sifre; set => doktor_Sifre = value; }
        public string Doktor_Il { get => doktor_Il; set => doktor_Il = value; }
        public string Doktor_Alan { get => doktor_Alan; set => doktor_Alan = value; }
    }
}
