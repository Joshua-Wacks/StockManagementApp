using System;
using System.Data;
using System.Data.SqlClient;
using ModelsNS;

namespace ConnectionNS
{
    public partial class Connection
    {
        private string connectionString = @"data source=JoshuaWa\MSSQLSERVER02;initial catalog=StockManagementDB;trusted_connection=true";

        public Connection()
        {  }
        
    }
}