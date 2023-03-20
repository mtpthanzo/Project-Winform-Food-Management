using ProjectLibrary.DataAccess;
using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void Delete(int orderID)=> OrderDBContext.Instance.Remove(orderID);

        public OrderObject GetOrderByID(int orderID) => OrderDBContext.Instance.GetOrderByID(orderID);

        public IEnumerable<OrderObject> GetOrderQuantityProduct() => OrderDBContext.Instance.GetQuantityProduct();

        public IEnumerable<OrderObject> GetOrderRevenue() => OrderDBContext.Instance.GetRevenue();

        public IEnumerable<OrderObject> GetOrders() => OrderDBContext.Instance.GetListOrder();

        public void InsertOrder(OrderObject order) => OrderDBContext.Instance.AddNew(order);

        public void UpdateOrder(OrderObject order) => OrderDBContext.Instance.Update(order);


    }
}
