using BiletlemeDapperApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletlemeDapperApp.Domain
{
    public class Musteri
    {
        public int id { get; set; }
        public string musteri_adi { get; set; }
        public string musteri_soyadi { get; set; }
        public DateTime dogum_tarihi { get; set; }
        public string tel_no { get; set; }
        public string email { get; set; }
        public DateTime? kayit_tarihi { get; set; }
        public CinsiyetEnum cinsiyet { get; set; }
        public DurumEnum durum { get; set; }
        public DateTime? guncelleme_tarihi { get; set; }
    }
}
