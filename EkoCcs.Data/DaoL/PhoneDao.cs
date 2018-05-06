using EkoCcs.Core.Models;
using EkoCcs.Data.Repositories;
using System.Collections.Generic;

namespace EkoCcs.Data.DaoL
{
    public class PhoneDao : EkoccsDAO<Phone,int>, IPhoneDao
    {
        public IEnumerable<Phone> GetPhoneList(int Id)
        {
            var Data = this.GetFilterList("CustomerId", Id);
            return Data;
        }
        public Phone SavePhone(Phone phone)
        {
            var Data = this.Insert(phone);
            return Data;
        }
        public void Deletephone(int Id)
        {
            this.Delete(Id);
        }

    }
}
