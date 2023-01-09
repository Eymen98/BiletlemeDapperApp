using BiletlemeDapperApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletlemeDapperApp.Application
{
    public interface IMusteriAppService
    {
        List<Musteri> GetCustomerList();

        Musteri GetCustomer(int id);

        int InsertCustomer(Musteri musteri);

        int UpdateCustomer(int id, Musteri musteri);

        int DeleteCustomer(int id);
    }
}
