using Microsoft.Data.SqlClient;
using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.DataAccess
{
    public class MenuDBContext : DAL
    {
        //------------------------------------
        private static MenuDBContext instance = null;
        private static readonly object instanceLock = new object();
        private MenuDBContext() { }
        public static MenuDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MenuDBContext();
                    }
                    return instance;
                }
            }
        }

        //------------------------------------------

        public IEnumerable<MenuObject> GetListMenu()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Menu";
            var menus = new List<MenuObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    menus.Add(new MenuObject
                    {
                        FoodId = dataReader.GetInt32(0),
                        FoodName = dataReader.GetString(1),
                        Quantity = dataReader.GetInt32(2),
                        Price = dataReader.GetDouble(3),
                        ReleaseDate = dataReader.GetString(4),
                        Quanlity = dataReader.GetString(5),
                        Image= dataReader.GetString(6), 
                        CateID = dataReader.GetInt32(7)
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
            return menus;
        }
        //------------------------------------------

        public MenuObject GetMenuByID(int foodID)
        {
            MenuObject menuObject = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Menu where FoodID = @FoodID";
            try
            {
                var param = dataProvider.CreateParameter("@FoodID", 4, foodID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    menuObject = new MenuObject
                    {
                        FoodId = dataReader.GetInt32(0),
                        FoodName = dataReader.GetString(1),
                        Quantity = dataReader.GetInt32(2),
                        Price = dataReader.GetDouble(3),
                        ReleaseDate = dataReader.GetString(4),
                        Quanlity = dataReader.GetString(5),
                        Image = dataReader.GetString(6),
                        CateID = dataReader.GetInt32(7)
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
            return menuObject;
        }

        public void AddNew(MenuObject menuObject)
        {
            try
            {
                MenuObject pro = GetMenuByID(menuObject.FoodId);
                if (pro == null)
                {
                    string SQLInsert = "Insert Menu values(@FoodName, @Quantity, @Price, @Quanlity , @ReleaseDate , @Image, @CateId)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@FoodName", 50, menuObject.FoodName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 50, menuObject.Quantity, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Price", 50, menuObject.Price, DbType.Double));
                    parameters.Add(dataProvider.CreateParameter("@ReleaseDate", 50, menuObject.ReleaseDate, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Quanlity", 50, menuObject.ReleaseDate, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Image", 50, menuObject.Image, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CateId", 50, menuObject.CateID, DbType.Int32));

                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The car is already exist.");
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

        public void Update(MenuObject menuObject)
        {
            try
            {
                MenuObject c = GetMenuByID(menuObject.FoodId);
                if (c != null)
                {
                    string SQLUpdate = "Update Menu Set FoodName = @FoodName," +
                        "Quantity = @Quantity, Price = @Price, ReleaseDate = @ReleaseDate, Quanlity = @Quanlity, " +
                        "Image = @Image ,CateId = @CateId where FoodId = @FoodId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@FoodID", 4, menuObject.FoodId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@FoodName", 50, menuObject.FoodName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 50, menuObject.Quantity, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Price", 50, menuObject.Price, DbType.Double));
                    parameters.Add(dataProvider.CreateParameter("@ReleaseDate", 50, menuObject.ReleaseDate, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Quanlity", 50, menuObject.Quanlity, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Image", 100, menuObject.Image, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CateId", 50, menuObject.CateID, DbType.Int32));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The food does not already exist.");
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

        public void Remove(int FoodID)
        {
            try
            {
                MenuObject menuObject = GetMenuByID(FoodID);
                if (menuObject != null)
                {
                    string SQLDelete = "Delete Menu where FoodID =  @FoodID";
                    var param = dataProvider.CreateParameter("@FoodID", 4, FoodID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The food does not already exist.");
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
    }
}
