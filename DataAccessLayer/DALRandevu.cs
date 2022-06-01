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
    public class DALRandevu
    {
        public static int Randevuekle(EntityRandevu gRandevu)
        {
            // Hasta Randevu Al Form ekranından gelen bilgilerle yeni kayıt ekleme
            OleDbCommand cmd = new OleDbCommand("Insert Into Randevular(Randevu_Tarihi,Randevu_Saati,Doktor_Id,Hasta_Id,Klinik_Id) Values(@Randevu_Tarihi,@Randevu_Saati,@Doktor_Id,@Hasta_Id,@Klinik_Id)", Baglanti.conn);
            //Gelen bilgiler ile insert into komutuna yollamak
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Randevu_Tarihi", gRandevu.Randevu_Tarihi);
            cmd.Parameters.AddWithValue("@Randevu_Saati", gRandevu.Randevu_Saati);
            cmd.Parameters.AddWithValue("@Doktor_Id", gRandevu.Doktor_Id);
            cmd.Parameters.AddWithValue("@Hasta_Id", gRandevu.Hasta_Id);
            cmd.Parameters.AddWithValue("@Klinik_Id", gRandevu.Klinik_Id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }
        public static int RandevuGuncelle(EntityRandevu gRandevu)
        {
            // Randevu Kontrol Paneli Form ekranından gelen bilgileri guncelleme
            OleDbCommand cmd = new OleDbCommand("Update Hastalar set Hasta_Id = @Hasta_Id , Klinik_Id = @Klinik_Id , Doktor_Id = @Doktor_Id , Randevu_Saati = @Randevu_Saati , Randevu_Tarihi = @Randevu_Tarihi Where Randevu_Id = @Randevu_Id", Baglanti.conn);
            // Randevu Id'si ile Doktoru bulup yeni değerler ile güncelleme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Hasta_Id", gRandevu.Hasta_Id);
            cmd.Parameters.AddWithValue("@Klinik_Id", gRandevu.Klinik_Id);
            cmd.Parameters.AddWithValue("@Doktor_Id", gRandevu.Doktor_Id);
            cmd.Parameters.AddWithValue("@Randevu_Saati", gRandevu.Randevu_Saati);
            cmd.Parameters.AddWithValue("@Randevu_Tarihi", gRandevu.Randevu_Tarihi);
            cmd.Parameters.AddWithValue("@Randevu_Id", gRandevu.Randevu_Id);

            return cmd.ExecuteNonQuery();// Komutları işle.
        }

        public static int RandevuSil(EntityRandevu gRandevu)
        {
            // Randevu Kontrol Paneli Form ekranından gelen bilgilerle silme işlemi
            OleDbCommand cmd = new OleDbCommand("Delete From Randevular Where Randevu_Id = @Randevu_Id", Baglanti.conn);
            // Gelen Id bilgisi bulunan veriyi silme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Randevu_Id", gRandevu.Randevu_Id);

            return cmd.ExecuteNonQuery();// Komutları işle.
        }

        public static List<EntityRandevu> RandevuHastaListele(int Hasta_Id)
        {
            // Randevular tablosundan tüm verileri çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From Randevular Where Hasta_Id = @Hasta_Id", Baglanti.conn);
            // Gelen hasta Id'sinin sahip olduğu randevular çekmek
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Hasta_Id", Hasta_Id);

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityRandevu> Randevular = new List<EntityRandevu>();

            while (dr.Read())
            {
                Randevular.Add(new EntityRandevu
                {
                    // Her randevu birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                    Randevu_Id = int.Parse(dr["Randevu_Id"].ToString()),
                    Hasta_Id = int.Parse(dr["Hasta_Id"].ToString()),
                    Doktor_Id = int.Parse(dr["Doktor_Id"].ToString()),
                    Klinik_Id = int.Parse(dr["Klinik_Id"].ToString()),
                    Randevu_Saati = dr["Randevu_Saati"].ToString(),
                    Randevu_Tarihi = dr["Randevu_Tarihi"].ToString()
                });
            }

            return Randevular;// Nesneleri içinde tutan listeyi geri döndürme
        }

        public static List<EntityRandevu> RandevuListele()
        {
            // Randevular tablosundan tüm verileri çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From Randevular", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityRandevu> Randevular = new List<EntityRandevu>();

            while (dr.Read())
            {
                Randevular.Add(new EntityRandevu
                {
                    // Her randevu birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                    Randevu_Id = int.Parse(dr["Randevu_Id"].ToString()),
                    Hasta_Id = int.Parse(dr["Hasta_Id"].ToString()),
                    Doktor_Id = int.Parse(dr["Doktor_Id"].ToString()),
                    Klinik_Id = int.Parse(dr["Klinik_Id"].ToString()),
                    Randevu_Saati = dr["Randevu_Saati"].ToString(),
                    Randevu_Tarihi = dr["Randevu_Tarihi"].ToString()
                });
            }

            return Randevular;// Nesneleri içinde tutan listeyi geri döndürme
        }
    }
}
