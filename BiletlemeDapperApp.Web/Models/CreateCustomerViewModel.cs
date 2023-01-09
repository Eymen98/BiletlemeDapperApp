using BiletlemeDapperApp.Domain.Enums;

namespace BiletlemeDapperApp.Web.Models
{
    public class CreateCustomerViewModel
    {
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public CinsiyetEnum Cinsiyet { get; set; }
        public DurumEnum Durum { get; set; }
    }
}
