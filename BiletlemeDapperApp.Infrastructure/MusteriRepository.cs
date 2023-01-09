using BiletlemeDapperApp.Domain;
using BiletlemeDapperApp.Domain.Repository;
using Dapper;
using System.Data.SqlClient;

namespace BiletlemeDapperApp.Infrastructure
{
    public class MusteriRepository : IMusteriRepository
    {
        private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biletleme;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Musteri> GetList()
        {
            List<Musteri> list;

            using (var connection = new SqlConnection(_connectionString))
            {
                list = connection.Query<Musteri>("SELECT * FROM dbo.Musteriler").ToList();
            }
            return list;
        }

        public Musteri Get(int id)
        {
            Musteri musteri;
            using (var connection = new SqlConnection(_connectionString))
            {
                musteri = connection.QueryFirst<Musteri>($"SELECT * FROM dbo.Musteriler WHERE = '{id}'");
            }
            return musteri;
        }

        public int Insert(Musteri musteri)
        {
            int result;
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = $"INSERT INTO dbo.Musteriler(musteri_adi,musteri_soyadi,dogum_tarihi,tel_no,email,kayit_tarihi,cinsiyet,durum,guncelleme_tarihi) VALUES ('{musteri.musteri_adi}', '{musteri.musteri_soyadi}', '{musteri.dogum_tarihi.ToString("yyyy-MM-dd")}','{musteri.tel_no}','{musteri.email}','{musteri.kayit_tarihi?.ToString("yyyy-MM-dd HH:mm:ss")}','{(int)musteri.cinsiyet}',{(int)musteri.durum},NULL)";
                
                result =  connection.Execute(query);
            }
            return result;
        }

        public int Update(int id, Musteri musteri)
        {
            int result;
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = string.Format(@"UPDATE dbo.Musteriler SET
                                            musteri_adi='{0}',
                                            musteri_soyadi='{1}',
                                            dogum_tarihi='{2}',
                                            tel_no='{3}',
                                            email='{4}',
                                            cinsiyet={5},
                                            durum={6},
                                            guncelleme_tarihi='{7}'  WHERE id={8} ", musteri.musteri_adi, musteri.musteri_soyadi
                                            , musteri.dogum_tarihi.ToString("yyyy-MM-dd"), musteri.tel_no, musteri.email, (int)musteri.cinsiyet, (int)musteri.durum, musteri.guncelleme_tarihi, id);

                result = connection.Execute(query);
            }
            return result;
        }
        public int Delete(int id)
        {
            int result;
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = $"DELETE FROM dbo.Musteriler WHERE Id = '{id}'";

                result = connection.Execute(query);
            }
            return result;
        }
    }
}
