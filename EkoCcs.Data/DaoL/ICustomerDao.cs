using EkoCcs.Core.Models;
using System.Collections.Generic;

namespace EkoCcs.Data.DaoL
{
    public interface ICustomerDao
    {
        IEnumerable<Customer> GetCustomerList();
        Customer GetCustomerDetail(int Id);
        void UpdateCustomer(Customer customer);
        Customer SaveCustomer(Customer customer);
        void DeleteCustomer(int Id);
    }
}
