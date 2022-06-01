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
    public class DALDoktor
    {
        public static int DoktorEkle(EntityDoktor gDoktor)
        {
            // Doktor Kayıt Form ekranından gelen bilgilerle yeni kayıt ekleme
            OleDbCommand cmd = new OleDbCommand("Insert Into Doktorlar(Doktor_Tc,Doktor_Ad,Doktor_Soyad,Doktor_Yas,Doktor_Cinsiyet,Doktor_Sifre,Doktor_Alan,Doktor_Il) Values(@Doktor_Tc,@Doktor_Ad,@Doktor_Soyad,@Doktor_Yas,@Doktor_Cinsiyet,@Doktor_Sifre,@Doktor_Alan,@Doktor_Il)", Baglanti.conn);
            //Gelen bilgiler ile insert into komutuna yollamak
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Doktor_Tc", gDoktor.Doktor_Tc);
            cmd.Parameters.AddWithValue("@Doktor_Ad", gDoktor.Doktor_Ad);
            cmd.Parameters.AddWithValue("@Doktor_Soyad", gDoktor.Doktor_Soyad);
            cmd.Parameters.AddWithValue("@Doktor_Yas", gDoktor.Doktor_Yas);
            cmd.Parameters.AddWithValue("@Doktor_Cinsiyet", gDoktor.Doktor_Cinsiyet);
            cmd.Parameters.AddWithValue("@Doktor_Sifre", gDoktor.Doktor_Sifre);
            cmd.Parameters.AddWithValue("@Doktor_Alan", gDoktor.Doktor_Alan);
            cmd.Parameters.AddWithValue("@Doktor_Il", gDoktor.Doktor_Il);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }

        public static string DoktorKontrolEt(EntityDoktor gDoktor)
        {
            // Doktor Sifremi Unuttum Form ekranından gelen bilgilerle Kontrol yapma
            OleDbCommand cmd = new OleDbCommand("Select Doktor_Sifre,Doktor_Tc,Doktor_Yas From Doktorlar Where Doktor_Tc = @Doktor_Tc And Doktor_Yas = @Doktor_Yas", Baglanti.conn);
            //Gelen bilgiler ile kontrol yapma
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Doktor_Tc", gDoktor.Doktor_Tc);
            cmd.Parameters.AddWithValue("@Doktor_Yas", gDoktor.Doktor_Yas);

            OleDbDataReader dr = cmd.ExecuteReader();
            string Sifre = "";

            while (dr.Read())
            {
                // Eşleşen  doktorun sifre bilgisini stringe atama
                Sifre = dr["Doktor_Sifre"].ToString();
            };
            // Şifre bilgisini tutan şifreyi geri döndürme
            return Sifre;
        }

        public static List<EntityDoktor> DoktorListele()
        {
            // Doktorlar tablosundan tüm verileri çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From Doktorlar", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityDoktor> Doktorlar = new List<EntityDoktor>();

            while (dr.Read())
            {
                // Her doktoru birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                Doktorlar.Add(new EntityDoktor
                {
                    Doktor_Id = int.Parse(dr["Doktor_Id"].ToString()),
                    Doktor_Tc = dr["Doktor_Tc"].ToString(),
                    Doktor_Ad = dr["Doktor_Ad"].ToString(),
                    Doktor_Soyad = dr["Doktor_Soyad"].ToString(),
                    Doktor_Yas = int.Parse(dr["Doktor_Yas"].ToString()),
                    Doktor_Cinsiyet = dr["Doktor_Cinsiyet"].ToString(),
                    Doktor_Sifre = dr["Doktor_Sifre"].ToString(),
                    Doktor_Alan = dr["Doktor_Alan"].ToString(),
                    Doktor_Il = dr["Doktor_Il"].ToString()
                });
            }

            return Doktorlar; // Nesneleri içinde tutan listeyi geri döndürme
        }

        public static List<EntityDoktor> DoktorAdiListele()
        {
            // Doktorun sadece id ve ad bilgisi çekme
            OleDbCommand cmd = new OleDbCommand("Select Doktor_Id,Doktor_Ad From Doktorlar", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            
            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityDoktor> Doktorlar = new List<EntityDoktor>();

            while (dr.Read())
            {
                // Her doktoru birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                Doktorlar.Add(new EntityDoktor
                {
                    Doktor_Id = int.Parse(dr["Doktor_Id"].ToString()),
                    Doktor_Ad = dr["Doktor_Ad"].ToString()
                });
            }

            return Doktorlar; // Nesneleri içinde tutan listeyi geri döndürme
        }

        public static int DoktorGuncelle(EntityDoktor gDoktor)
        {
            // Doktor Kontrol Paneli Form ekranından gelen bilgileri guncelleme
            OleDbCommand cmd = new OleDbCommand("Update Doktorlar set Doktor_Ad = @Doktor_Ad , Doktor_Soyad = @Doktor_Soyad , Doktor_Il = @Doktor_Il ,Doktor_Sifre = @Doktor_Sifre , Doktor_Alan = @Doktor_Alan , Doktor_Yas = @Doktor_Yas Where Doktor_Id = @Doktor_Id", Baglanti.conn);
            // Doktor Id'si ile Doktoru bulup yeni değerler ile güncelleme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Doktor_Ad", gDoktor.Doktor_Ad);
            cmd.Parameters.AddWithValue("@Doktor_Soyad", gDoktor.Doktor_Soyad);
            cmd.Parameters.AddWithValue("@Doktor_Il", gDoktor.Doktor_Il);
            cmd.Parameters.AddWithValue("@Doktor_Sifre", gDoktor.Doktor_Sifre);
            cmd.Parameters.AddWithValue("@Doktor_Alan", gDoktor.Doktor_Alan);
            cmd.Parameters.AddWithValue("@Doktor_Yas", gDoktor.Doktor_Yas);
            cmd.Parameters.AddWithValue("@Doktor_Id", gDoktor.Doktor_Id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }

        public static int DoktorSil(EntityDoktor gDoktor)
        {
            // Doktor Kontrol Paneli Form ekranından gelen bilgilerle silme işlemi
            OleDbCommand cmd = new OleDbCommand("Delete From Doktorlar Where Doktor_Id = @Doktor_Id", Baglanti.conn);
            // Gelen Id bilgisi bulunan veriyi silme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Doktor_Id", gDoktor.Doktor_Id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }

        public static List<string> DoktorCmbDoldur(string Alan)
        {
            // Doktorun Alan bilgisine göre doktorun adını çekkme
            OleDbCommand cmd = new OleDbCommand("Select Doktor_Ad From Doktorlar Where Doktor_Alan = @Doktor_Alan", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Doktor_Alan", Alan);

            OleDbDataReader dr = cmd.ExecuteReader();
            List<string> Doktorlar = new List<string>();

            while (dr.Read())
            {
                //Doktorların ad bilgisin string listesine atama
                Doktorlar.Add(dr["Doktor_Ad"].ToString());
            }

            return Doktorlar;// Nesneleri içinde tutan listeyi geri döndürme
        }

        public static int DoktorIdBul(string DoktorAdi)
        {
            // Gelen Ad bilgisine göre o doktorun id'sini geri dönderme
            OleDbCommand cmd = new OleDbCommand("Select Doktor_Id From Doktorlar Where Doktor_Ad = @Doktor_Ad", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("Doktor_Ad", DoktorAdi);

            int Doktor_ID = 0;

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Gelen doktor bilgisinden id'sini çekme
                Doktor_ID = int.Parse(dr["Doktor_Id"].ToString());
            }

            return Doktor_ID; // Doktor ID'sini geri döndür
        }

        public static int DoktorIdBul(EntityDoktor gDoktor)
        {
            // Gelen Tc ve Şifre bilgisine göre o doktorun id'sini geri dönderme
            OleDbCommand cmd = new OleDbCommand("Select Doktor_Id From Doktorlar Where Doktor_Tc = @Doktor_Tc And Doktor_Sifre = @Doktor_Sifre", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("Doktor_Tc", gDoktor.Doktor_Tc);
            cmd.Parameters.AddWithValue("Doktor_Sifre", gDoktor.Doktor_Sifre);

            int Doktor_ID = 0;

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Gelen hasta bilgisinden id'sini çekme
                Doktor_ID = int.Parse(dr["Doktor_Id"].ToString());
            }

            return Doktor_ID;  // Hasta ID'sini geri döndür
        }
    }
}
