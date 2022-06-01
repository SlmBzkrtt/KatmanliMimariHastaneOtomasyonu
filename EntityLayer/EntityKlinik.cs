using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKlinik
    {
        // Klinik tablosunun değerlerini atama (DTO)
        int klinik_Id;

        string klinik_Adi;

        public int Klinik_Id { get => klinik_Id; set => klinik_Id = value; }
        public string Klinik_Adi { get => klinik_Adi; set => klinik_Adi = value; }
    }
}
