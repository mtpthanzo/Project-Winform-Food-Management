using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.DataAccess
{
    public class DAL
    {
        public MenuDataProvider dataProvider { get; set; } = null;

        public SqlConnection connection = null;
        public DAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new MenuDataProvider(connectionString);
        }
        public string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            connectionString = config["ConnectionString:Data"];
            return connectionString;
        }
        //-------------------------------------------
        public void CloseConnection() => dataProvider.CloseConnection(connection);
    }
    
}
