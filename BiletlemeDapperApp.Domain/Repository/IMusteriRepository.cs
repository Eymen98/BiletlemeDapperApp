using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletlemeDapperApp.Domain.Repository
{
    public interface IMusteriRepository
    {
        List<Musteri> GetList();

        Musteri Get(int id);

        int Insert(Musteri musteri);

        int Update(int id, Musteri musteri);

        int Delete(int id);
    }
}
