using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<OrderObject> GetOrders();
        IEnumerable<OrderObject> GetOrderRevenue();
        IEnumerable<OrderObject> GetOrderQuantityProduct();
        OrderObject GetOrderByID(int orderID);
        void InsertOrder(OrderObject order);
        void UpdateOrder(OrderObject order);
        void Delete(int orderID);
    }
}
