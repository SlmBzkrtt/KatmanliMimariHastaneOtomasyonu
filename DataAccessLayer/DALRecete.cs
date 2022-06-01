using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALRecete
    {
        public static int ReceteEkle(EntityRecete gRecete)
        {
            // Form ekranından gelen bilgilerle yeni kayıt ekleme
            OleDbCommand cmd = new OleDbCommand("Insert Into Receteler(Doktor_Id,Hasta_Id,Doktor_Aciklama) Values(@Doktor_Id,@Hasta_Id,@Doktor_Aciklama)", Baglanti.conn);
            //Gelen bilgiler ile insert into komutuna yollamak
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Doktor_Id", gRecete.Doktor_Id);
            cmd.Parameters.AddWithValue("@Hasta_Id", gRecete.Hasta_Id);
            cmd.Parameters.AddWithValue("@Doktor_Aciklama", gRecete.Doktor_Aciklama);

            return cmd.ExecuteNonQuery();// Komutları işle.
        }
    }
}
