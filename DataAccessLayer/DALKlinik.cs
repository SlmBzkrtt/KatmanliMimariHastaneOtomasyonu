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
    public class DALKlinik
    {
        public static int KlinikEkle(EntityKlinik gKlinik)
        {
            // Klinik Kontrol Paneli Form ekranından gelen bilgilerle yeni kayıt ekleme
            OleDbCommand cmd = new OleDbCommand("Insert Into Klinikler(Klinik_Adi) Values(@KlinikAdi)", Baglanti.conn);
            //Gelen bilgiler ile insert into komutuna yollamak
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@KlinikAdi", gKlinik.Klinik_Adi);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }

        public static int KlinikGuncelle(EntityKlinik gKlinik)
        {
            // Klinik Kontrol Paneli Form ekranından gelen bilgileri guncelleme
            OleDbCommand cmd = new OleDbCommand("Update Klinikler set Klinik_Adi = @KlinikAdi Where Klinik_Id = @Klinik_Id", Baglanti.conn);
            // Klinik Id'si ile Kliniği bulup yeni değerler ile güncelleme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@KlinikAdi", gKlinik.Klinik_Adi);
            cmd.Parameters.AddWithValue("@Klinik_Id", gKlinik.Klinik_Id);

            return cmd.ExecuteNonQuery();// Komutları işle.
        }

        public static int KlinikSil(EntityKlinik gKlinik)
        {
            // Klinik Kontrol Paneli Form ekranından gelen bilgilerle silme işlemi
            OleDbCommand cmd = new OleDbCommand("Delete From Klinikler Where Klinik_Id = @Klinik_Id", Baglanti.conn);
            // Gelen Id bilgisi bulunan veriyi silme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Klinik_Id", gKlinik.Klinik_Id);

            return cmd.ExecuteNonQuery();// Komutları işle.
        }

        public static int KlinikIdBul(string KlinikAdi)
        {
            // Gelen Ad bilgisine göre o doktorun id'sini geri dönderme
            OleDbCommand cmd = new OleDbCommand("Select Klinik_Id From Klinikler Where Klinik_Adi = @Klinik_Adi", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("Klinik_Adi", KlinikAdi);

            int Klinik_ID = 0;

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Gelen klinik bilgisinden id'sini çekme
                Klinik_ID = int.Parse(dr["Klinik_Id"].ToString());
            }

            return Klinik_ID;// Klinik ID'sini geri döndür
        }

        public static List<EntityKlinik> KlinikListele()
        {
            // Klinikler tablosundan tüm verileri çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From Klinikler", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityKlinik> Klinikler = new List<EntityKlinik>();

            while (dr.Read())
            {
                Klinikler.Add(new EntityKlinik
                {
                    // Her Kliniği birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                    Klinik_Id = int.Parse(dr["Klinik_Id"].ToString()),
                    Klinik_Adi = dr["Klinik_Adi"].ToString()
                });
            }

            return Klinikler;  // Nesneleri içinde tutan listeyi geri döndürme
        }

        public static List<string> KlinikCmbDoldur()
        {
            // Kliniğin adını çekme
            OleDbCommand cmd = new OleDbCommand("Select Klinik_Adi From Klinikler", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<string> Klinikler = new List<string>();

            while (dr.Read())
            {
                //Kliniklerin ad bilgisin string listesine atama
                Klinikler.Add(dr["Klinik_Adi"].ToString());
            }

            return Klinikler; // Nesneleri içinde tutan listeyi geri döndürme
        }
    }
}
