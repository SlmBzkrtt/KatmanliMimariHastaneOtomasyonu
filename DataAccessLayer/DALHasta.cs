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
    public class DALHasta
    {
        public static int HastaEkle(EntityHasta gHasta)
        {
            // Doktor Kayıt Form ekranından gelen bilgilerle yeni kayıt ekleme
            OleDbCommand cmd = new OleDbCommand("Insert Into Hastalar(Hasta_Tc,Hasta_Ad,Hasta_Soyad,Hasta_Yas,Hasta_Cinsiyet,Hasta_Sifre,Hasta_AnneAdi,Hasta_BabaAdi,Hasta_Il)Values(@Hasta_Tc,@Hasta_Ad,@Hasta_Soyad,@Hasta_Yas,@Hasta_Cinsiyet,@Hasta_Sifre,@Hasta_AnneAdi,@Hasta_BabaAdi,@Hasta_Il)", Baglanti.conn);
            //Gelen bilgiler ile insert into komutuna yollamak
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Hasta_Tc", gHasta.Hasta_Tc);
            cmd.Parameters.AddWithValue("@Hasta_Ad", gHasta.Hasta_Ad);
            cmd.Parameters.AddWithValue("@Hasta_Soyad", gHasta.Hasta_Soyad);
            cmd.Parameters.AddWithValue("@Hasta_Yas", gHasta.Hasta_Yas);
            cmd.Parameters.AddWithValue("@Hasta_Cinsiyet", gHasta.Hasta_Cinsiyet);
            cmd.Parameters.AddWithValue("@Hasta_Sifre", gHasta.Hasta_Sifre);
            cmd.Parameters.AddWithValue("@Hasta_AnneAdi", gHasta.Hasta_AnneAdi);
            cmd.Parameters.AddWithValue("@Hasta_BabaAdi", gHasta.Hasta_BabaAdi);
            cmd.Parameters.AddWithValue("@Hasta_Il", gHasta.Hasta_Il);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }

        public static string HastaKontrolEt(EntityHasta gHasta)
        {
            // Doktor Sifremi Unuttum Form ekranından gelen bilgilerle Kontrol yapma
            OleDbCommand cmd = new OleDbCommand("Select Hasta_Sifre,Hasta_Tc,Hasta_AnneAdi From Hastalar Where Hasta_Tc = @Hasta_Tc And Hasta_AnneAdi = @Hasta_AnneAdi", Baglanti.conn);
            //Gelen bilgiler ile kontrol yapma
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Hasta_Tc", gHasta.Hasta_Tc);
            cmd.Parameters.AddWithValue("@Hasta_AnneAdi", gHasta.Hasta_AnneAdi);

            OleDbDataReader dr = cmd.ExecuteReader();
            string Sifre = "";

            while (dr.Read())
            {
                // Eşleşen  doktorun sifre bilgisini stringe atama
                Sifre = dr["Hasta_Sifre"].ToString();
            };
            // Şifre bilgisini tutan şifreyi geri döndürme
            return Sifre;
        }

        public static List<string> HastaCmbDoldur()
        {
            // Hasta bilgisine göre Hastanın Id çekkme
            OleDbCommand cmd = new OleDbCommand("Select Hasta_Id From Hastalar", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<string> Hastalar = new List<string>();

            while (dr.Read())
            {
                //Hastaların ad bilgisin string listesine atama
                Hastalar.Add(dr["Hasta_Id"].ToString());
            }

            return Hastalar;// Nesneleri içinde tutan listeyi geri döndürme
        }

        public static List<EntityHasta> HastaListele()
        {
            // Hastalar tablosundan tüm verileri çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From Hastalar", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityHasta> Hastalar = new List<EntityHasta>();

            while (dr.Read())
            {
                // Her doktoru birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                Hastalar.Add(new EntityHasta
                {
                    Hasta_Id = int.Parse(dr["Hasta_Id"].ToString()),
                    Hasta_Tc = dr["Hasta_Tc"].ToString(),
                    Hasta_Ad = dr["Hasta_Ad"].ToString(),
                    Hasta_Soyad = dr["Hasta_Soyad"].ToString(),
                    Hasta_Yas = int.Parse(dr["Hasta_Yas"].ToString()),
                    Hasta_Cinsiyet = dr["Hasta_Cinsiyet"].ToString(),
                    Hasta_Sifre = dr["Hasta_Sifre"].ToString(),
                    Hasta_AnneAdi = dr["Hasta_AnneAdi"].ToString(),
                    Hasta_BabaAdi = dr["Hasta_BabaAdi"].ToString(),
                    Hasta_Il = dr["Hasta_Il"].ToString()
                });
            }

            return Hastalar; // Nesneleri içinde tutan listeyi geri döndürme
        }

        public static List<EntityHasta> HastaAdiListele()
        {
            // Hastanın sadece id ve ad bilgisi çekme
            OleDbCommand cmd = new OleDbCommand("Select Hasta_Id,Hasta_Ad From Hastalar", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityHasta> Hastalar = new List<EntityHasta>();

            while (dr.Read())
            {
                Hastalar.Add(new EntityHasta
                {
                    // Her hastayı birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                    Hasta_Id = int.Parse(dr["Hasta_Id"].ToString()),
                    Hasta_Ad = dr["Hasta_Ad"].ToString()
                });
            }

            return Hastalar; // Nesneleri içinde tutan listeyi geri döndürme
        }

        public static int HastaGuncelle(EntityHasta gHasta)
        {
            // Hasta Kontrol Paneli Form ekranından gelen bilgileri guncelleme
            OleDbCommand cmd = new OleDbCommand("Update Hastalar set Hasta_Ad = @Hasta_Ad , Hasta_Soyad = @Hasta_Soyad , Hasta_Il = @Hasta_Il , Hasta_Sifre = @Hasta_Sifre , Hasta_Yas = @Hasta_Yas Where Hasta_Id = @Hasta_Id", Baglanti.conn);
            // Hasta Id'si ile Doktoru bulup yeni değerler ile güncelleme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Hasta_Ad", gHasta.Hasta_Ad);
            cmd.Parameters.AddWithValue("@Hasta_Soyad", gHasta.Hasta_Soyad);
            cmd.Parameters.AddWithValue("@Hasta_Il", gHasta.Hasta_Il);
            cmd.Parameters.AddWithValue("@Hasta_Sifre", gHasta.Hasta_Sifre);
            cmd.Parameters.AddWithValue("@Hasta_Yas", gHasta.Hasta_Yas);
            cmd.Parameters.AddWithValue("@Hasta_Id", gHasta.Hasta_Id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }

        public static int HastaSil(EntityHasta gHasta)
        {
            // Hasta Kontrol Paneli Form ekranından gelen bilgilerle silme işlemi
            OleDbCommand cmd = new OleDbCommand("Delete From Hastalar Where Hasta_Id = @Hasta_Id", Baglanti.conn);
            // Gelen Id bilgisi bulunan veriyi silme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Hasta_Id", gHasta.Hasta_Id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }

        public static int HastaIdBul(EntityHasta gHasta)
        {
            // Gelen Ad ve Şifre bilgisine göre o doktorun id'sini geri dönderme
            OleDbCommand cmd = new OleDbCommand("Select Hasta_Id From Hastalar Where Hasta_Tc = @Hasta_Tc And Hasta_Sifre = @Hasta_Sifre", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("Hasta_Tc", gHasta.Hasta_Tc);
            cmd.Parameters.AddWithValue("Hasta_Sifre", gHasta.Hasta_Sifre);

            int Hasta_ID = 0;

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Gelen hasta bilgisinden id'sini çekme
                Hasta_ID = int.Parse(dr["Hasta_Id"].ToString());
            }

            return Hasta_ID;  // Hasta ID'sini geri döndür
        }

        public static EntityHasta HastaIdBilgiGetir(EntityHasta gHasta)
        {
            // Hastalar tablosundan Id bilgisi ile o hastanın bilgilerini getir
            OleDbCommand cmd = new OleDbCommand("Select * From Hastalar Where Hasta_Id = @Hasta_Id", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Hasta_Id", gHasta.Hasta_Id);

            EntityHasta yHasta = new EntityHasta();

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                // Dönecek olan hasta nesnesinin içeriğini doldurma
                yHasta.Hasta_Id = int.Parse(dr["Hasta_Id"].ToString());
                yHasta.Hasta_Tc = dr["Hasta_Tc"].ToString();
                yHasta.Hasta_Ad = dr["Hasta_Ad"].ToString();
                yHasta.Hasta_Soyad = dr["Hasta_Soyad"].ToString();
                yHasta.Hasta_Yas = int.Parse(dr["Hasta_Yas"].ToString());
                yHasta.Hasta_Cinsiyet = dr["Hasta_Cinsiyet"].ToString();
                yHasta.Hasta_Sifre = dr["Hasta_Sifre"].ToString();
                yHasta.Hasta_AnneAdi = dr["Hasta_AnneAdi"].ToString();
                yHasta.Hasta_BabaAdi = dr["Hasta_BabaAdi"].ToString();
                yHasta.Hasta_Il = dr["Hasta_Il"].ToString();
            };

            return yHasta; // Hasta nesnsini geri döndürme
        }
    }
}
