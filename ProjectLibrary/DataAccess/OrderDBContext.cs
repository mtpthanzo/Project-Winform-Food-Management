using Microsoft.Data.SqlClient;
using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.DataAccess
{
    public class OrderDBContext : DALOrder
    {
        private static OrderDBContext instance = null;
        private static readonly object instanceLock = new object();
        private OrderDBContext() { }
        public static OrderDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDBContext();
                    }
                    return instance;
                }
            }
        }
        
        //------------------------------------------

        public IEnumerable<OrderObject> GetListOrder()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from [Order]";
            var menus = new List<OrderObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    menus.Add(new OrderObject
                    {
                        CustomerID = dataReader.GetInt32(0),
                        OrderID= dataReader.GetInt32(1),
                        OrderDate = dataReader.GetString(2),
                        TotalMoney = dataReader.GetDecimal(3),
                        FoodID = dataReader.GetInt32(4),
                        Quantity = dataReader.GetInt32(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return menus;
        }
        
        //------------------------------------------

        public OrderObject GetOrderByID(int orderID)
        {
            OrderObject orderObject = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * from [Order] where OrderID = @OrderID";
            try
            {
                var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    orderObject = new OrderObject
                    {
                        CustomerID = dataReader.GetInt32(0),
                        OrderID = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetString(2),
                        TotalMoney = dataReader.GetDecimal(3),
                        FoodID = dataReader.GetInt32(4),
                        Quantity = dataReader.GetInt32(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return orderObject;
        }

        public void AddNew(OrderObject orderObject)
        {
            try
            {
                OrderObject pro = GetOrderByID(orderObject.OrderID);
                if (pro == null)
                {
                    string SQLInsert = "Insert [Order] values(@CustomerID, @OrderDate, @TotalMoney, @FoodID, @Quantity)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CustomerID", 50, orderObject.CustomerID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@FoodID", 4, orderObject.FoodID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 4, orderObject.Quantity, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 50, orderObject.OrderDate, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@TotalMoney", 50, orderObject.TotalMoney, DbType.Decimal));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }//end add

        public void Update(OrderObject orderObject)
        {
            try
            {
                OrderObject c = GetOrderByID(orderObject.OrderID);
                if (c != null)
                {
                    string SQLUpdate = "Update [Order] Set CustomerID = @CustomerID, OrderDate= @OrderDate," +
                        "  TotalMoney = @TotalMoney, FoodID = @FoodID, Quantity = @Quantity   where OrderID = @OrderID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CustomerID", 50, orderObject.CustomerID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@FoodID", 4, orderObject.FoodID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 4, orderObject.Quantity, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 50, orderObject.OrderDate, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@TotalMoney", 50, orderObject.TotalMoney, DbType.Decimal));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order does not already exist.");
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }//end update

        public void Remove(int orderID)
        {
            try
            {
                OrderObject orderObject = GetOrderByID(orderID);
                if (orderObject != null)
                {
                    string SQLDelete = "Delete [Order] where OrderID =  @OrderID";
                    var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The order does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }//end delete

        public IEnumerable<OrderObject> GetRevenue()
        {
            IDataReader dataReader = null;
            string SQLSelect = "select MONTH(o.OrderDate) as Month, SUM(o.TotalMoney) as Revenue from [Order] o group by MONTH(OrderDate)";
            var menus = new List<OrderObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    menus.Add(new OrderObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        TotalMoney = dataReader.GetDecimal(1),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return menus;
        }

        public IEnumerable<OrderObject> GetQuantityProduct()
        {
            IDataReader dataReader = null;
            string SQLSelect = "select MONTH(o.OrderDate) as Month, SUM(o.foodID) as QuantityFood from [Order] o group by MONTH(OrderDate) ";
            var menus = new List<OrderObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    menus.Add(new OrderObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        FoodID =dataReader.GetInt32(1)
                    });
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return menus;
        }
    }
}
