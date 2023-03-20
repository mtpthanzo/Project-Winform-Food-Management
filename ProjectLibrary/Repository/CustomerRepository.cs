using ProjectLibrary.DataAccess;
using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerObject GetCustomerByID(int id) => CustomerDBContext.Instance.GetCusByID(id);
        public IEnumerable<CustomerObject> GetCustomers() => CustomerDBContext.Instance.GetListCus();

        public void InsertCustomer(CustomerObject customer) => CustomerDBContext.Instance.AddNew(customer);
    }
}
