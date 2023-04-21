using System;
using System.Data;
using System.Data.SqlClient;
using ModelsNS;

//get
//set
//insert
//delete

namespace ConnectionNS
{
    public partial class Connection
    {
        private string connectionString = @"data source=BBD-KG\SQLEXPRESS;initial catalog=StockManagementDB;trusted_connection=true";
        // private static string schema = "dbo";
        //TODO include schema name in queries
        //TODO get info from config file
        //TODO handle not found queries with error handling
        //TODO ensure all data validation is done on frontend side
        //TODO checks should be done for not found on gets

        public Connection()
        {  }
        
    }
}