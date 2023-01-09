using BiletlemeDapperApp.Domain;
using BiletlemeDapperApp.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletlemeDapperApp.Application
{
    public class MusteriAppService : IMusteriAppService
    {
        private readonly IMusteriRepository _musteriRepository;
        
        public MusteriAppService(IMusteriRepository musteriRepository)
        {
            _musteriRepository = musteriRepository;
        }
        
        public Musteri GetCustomer(int id)
        {
            var customer = _musteriRepository.Get(id);
            return customer;
        }
        
        public List<Musteri> GetCustomerList()
        {
            var customerList = _musteriRepository.GetList();
            return customerList;
        }

        public int InsertCustomer(Musteri musteri)
        {
            int result = _musteriRepository.Insert(musteri);
            return result;
        }

        public int UpdateCustomer(int id, Musteri musteri)
        {
            int result = _musteriRepository.Update(id, musteri);
            return result;
        }

        public int DeleteCustomer(int id)
        {
            int result = _musteriRepository.Delete(id);
            return result;
        }
    }
}
