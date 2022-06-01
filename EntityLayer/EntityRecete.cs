using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityRecete
    {
        // Reçete tablosunun değerlerini atama (DTO)
        int recete_Id;

        int doktor_Id;

        int hasta_Id;

        string doktor_Aciklama;

        public string Doktor_Aciklama { get => doktor_Aciklama; set => doktor_Aciklama = value; }
        public int Hasta_Id { get => hasta_Id; set => hasta_Id = value; }
        public int Doktor_Id { get => doktor_Id; set => doktor_Id = value; }
        public int Recete_Id { get => recete_Id; set => recete_Id = value; }
    }
}
