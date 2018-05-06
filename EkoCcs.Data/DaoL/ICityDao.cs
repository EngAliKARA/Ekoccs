using EkoCcs.Core.Models;
using System.Collections.Generic;

namespace EkoCcs.Data.DaoL
{
    public interface ICityDao
    {
        IEnumerable<City> GetCityList();
    }
}