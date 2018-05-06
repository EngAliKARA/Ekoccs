using EkoCcs.Core.Models;
using System.Collections.Generic;

namespace EkoCcs.Data.DaoL
{
    public interface IPhoneDao
    {
        IEnumerable<Phone> GetPhoneList(int Id);
    }
}