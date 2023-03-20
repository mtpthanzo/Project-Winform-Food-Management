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
    public class CustomerDBContext : DALCustomer
    {

        private static CustomerDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CustomerDBContext() { }
        public static CustomerDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDBContext();
                    }
                    return instance;
                }
            }
        }

        //------------------------------------------

        public IEnumerable<CustomerObject> GetListCus()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Customer";
            var customers = new List<CustomerObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    customers.Add(new CustomerObject
                    {
                        CustomerID = dataReader.GetInt32(0),
                        FirstName= dataReader.GetString(1),
                        LastName= dataReader.GetString(2),
                        Gender= dataReader.GetString(3),
                        Address= dataReader.GetString(4),
                        Telephone = dataReader.GetString(5),
                        Email= dataReader.GetString(6),
                        UserName= dataReader.GetString(7),
                        Password= dataReader.GetString(8),
                        Role = dataReader.GetInt32(9),
                    }) ;
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
            return customers;
        }
        //------------------------------------------

        public CustomerObject GetCusByID(int customerID)
        {
            CustomerObject customerObject = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Customer where CustomerID = @CustomerID";
            try
            {
                var param = dataProvider.CreateParameter("@CustomerID", 4, customerID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    customerObject = new CustomerObject
                    {
                        CustomerID = dataReader.GetInt32(0),
                        FirstName = dataReader.GetString(1),
                        LastName = dataReader.GetString(2),
                        Gender = dataReader.GetString(3),
                        Address = dataReader.GetString(4),
                        Telephone = dataReader.GetString(5),
                        Email = dataReader.GetString(6),
                        UserName = dataReader.GetString(8),
                        Password = dataReader.GetString(9),
                        Role = dataReader.GetInt32(10),
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
            return customerObject;
        }

        public void AddNew(CustomerObject customerObject)
        {
            try
            {
                CustomerObject pro = GetCusByID(customerObject.CustomerID);
                if (pro == null)
                {
                    string SQLInsert = "Insert Customer values(@FirstName, @LastName, @Gender, @Address , @Telephone , @Email," +
                        " @UserName, @Password, @Role)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@FirstName", 50,customerObject.FirstName , DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@LastName", 50, customerObject.LastName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Gender", 50, customerObject.Gender, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Address", 50, customerObject.Address, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Telephone", 50, customerObject.Telephone, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, customerObject.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UserName", 50, customerObject.UserName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, customerObject.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Role", 50, customerObject.Role, DbType.Int32));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The food is already exist.");
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

        //public void Update(MenuObject menuObject)
        //{
        //    try
        //    {
        //        MenuObject c = GetMenuByID(menuObject.FoodId);
        //        if (c != null)
        //        {
        //            string SQLUpdate = "Update Menu Set FoodName = @FoodName," +
        //                "Quantity = @Quantity, Price = @Price, ReleaseDate = @ReleaseDate, Quanlity = @Quanlity, " +
        //                "Image = @Image ,CateId = @CateId where FoodId = @FoodId";
        //            var parameters = new List<SqlParameter>();
        //            parameters.Add(dataProvider.CreateParameter("@FoodID", 4, menuObject.FoodId, DbType.Int32));
        //            parameters.Add(dataProvider.CreateParameter("@FoodName", 50, menuObject.FoodName, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter("@Quantity", 50, menuObject.Quantity, DbType.Int32));
        //            parameters.Add(dataProvider.CreateParameter("@Price", 50, menuObject.Price, DbType.Double));
        //            parameters.Add(dataProvider.CreateParameter("@ReleaseDate", 50, menuObject.ReleaseDate, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter("@Quanlity", 50, menuObject.Quanlity, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter("@Image", 100, menuObject.Image, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter("@CateId", 50, menuObject.CateID, DbType.Int32));
        //            dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
        //        }
        //        else
        //        {
        //            throw new Exception("The food does not already exist.");
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}//end update

        //public void Remove(int FoodID)
        //{
        //    try
        //    {
        //        MenuObject menuObject = GetMenuByID(FoodID);
        //        if (menuObject != null)
        //        {
        //            string SQLDelete = "Delete Menu where FoodID =  @FoodID";
        //            var param = dataProvider.CreateParameter("@FoodID", 4, FoodID, DbType.Int32);
        //            dataProvider.Delete(SQLDelete, CommandType.Text, param);
        //        }
        //        else
        //        {
        //            throw new Exception("The car does not already exist.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}//end delete

    }
}
