using EkoCcs.Core.Models;
using EkoCcs.Data.Repositories;
using System.Collections.Generic;

namespace EkoCcs.Data.DaoL
{
    public class CustomerDao :EkoccsDAO<Customer, int>, ICustomerDao
    {
        public IEnumerable<Customer> GetCustomerList()
        {
            var Data = this.GetAll();
            return Data;
        }
        public Customer GetCustomerDetail(int Id)
        {
            var Data = this.GetObjectById(Id);
            return Data;
        }
        public void UpdateCustomer(Customer customer)
        {
            this.Update(customer);
        }
        public Customer SaveCustomer(Customer customer)
        {
            var Data = this.Insert(customer);
            return Data;
        }
        public void DeleteCustomer(int Id)
        {
            this.Delete(Id);
        }
    }
}
