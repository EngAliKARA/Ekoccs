using EkoCcs.Core.Models;
using EkoCcs.Data.Repositories;
using System.Collections.Generic;

namespace EkoCcs.Data.DaoL
{
    public class CityDao : EkoccsDAO<City, int>, ICityDao
    {
        public IEnumerable<City> GetCityList()
        {
            var Data = this.GetAll();
            return Data;
        }
    }
}
