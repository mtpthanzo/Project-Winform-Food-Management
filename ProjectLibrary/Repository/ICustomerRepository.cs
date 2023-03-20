using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerObject> GetCustomers();

        CustomerObject GetCustomerByID(int id);

        void InsertCustomer(CustomerObject customer);

    }
}
