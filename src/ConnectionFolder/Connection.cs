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
        private string connectionString = @"data source=JoshuaWa\MSSQLSERVER02;initial catalog=StockManagementDB;trusted_connection=true";
        // private static string schema = "dbo";
        //TODO include schema name in queries
        //TODO get info from config file
        //TODO handle not found queries with error handling
        //TODO ensure all data validation is done on frontend side
        //TODO checks should be done for not found on gets

        public Connection()
        {  }

        //*******************************************************BRAND START****************************************************

        public List<Brand> getAllBrands()
        {
            List<Brand> brandList = new List<Brand>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Brand", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Brand brand = new Brand(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]));
                        brandList.Add(brand);
                    }
                }
            }

            return brandList;
        }

        public Brand getBrand(int brandID) {

            Brand brand = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Brand WHERE BrandId = @p_brandID", conn);
                command.Parameters.Add(new SqlParameter("p_brandID", brandID));
           
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        brand = new Brand(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]));
                    }
                    else
                    {
                        Console.WriteLine("brand not found");
                    }
                }
            }

            return brand;

        }

        public Brand getBrand(string name)
        {
            Brand brand = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Brand WHERE Name = @p_brandName", conn);
                command.Parameters.Add(new SqlParameter("p_brandName", name));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        brand = new Brand(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]));
                    }
                    else
                    {
                        Console.WriteLine("brand not found");
                    }
                }
            }

            return brand;

        }

        public Boolean setBrand(string oldName, string newName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE Brand SET Name = @p_newName WHERE Name = @p_oldName", conn);
                command.Parameters.Add(new SqlParameter("p_newName", newName));
                command.Parameters.Add(new SqlParameter("p_oldName", oldName));

                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean setBrand(int brandID, string newName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE Brand SET Name = @p_newName WHERE BrandID = @p_brandID", conn);
                command.Parameters.Add(new SqlParameter("p_newName", newName));
                command.Parameters.Add(new SqlParameter("p_brandID", brandID));

                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }
    
        public Boolean insertBrand(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Brand VALUES(@p_name);", conn);
                command.Parameters.Add(new SqlParameter("p_name", name));
                
                try {

                    int result = command.ExecuteNonQuery();
                    return result > 0;

                }
                catch (System.Data.SqlClient.SqlException exception )
                {
                    Console.WriteLine(exception.Message);
                    return false;
                }
                
            }
        }

        public Boolean deleteBrand(int brandID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Brand WHERE brandID = @p_brandID", conn);
                command.Parameters.Add(new SqlParameter("p_brandID", brandID));


                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean deleteBrand(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Brand WHERE Name = @p_name", conn);
                command.Parameters.Add(new SqlParameter("p_name", name));


                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        //*******************************************************BRAND END****************************************************


        //*******************************************************CATEGORY START****************************************************

        public List<Category> getAllCategories()
        {
            List<Category> categoryList = new List<Category>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Category", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category category = new Category(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]));
                        categoryList.Add(category);
                    }
                }
            }

            return categoryList;
        }

        public Category getCategory(int categoryID)
        {

            Category category = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Category WHERE CategoryID = @p_categoryID", conn);
                command.Parameters.Add(new SqlParameter("p_categoryID", categoryID));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        category = new Category(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]));
                    }
                    else
                    {
                        Console.WriteLine("category not found");
                    }
                }
            }

            return category;

        }

        public Category getCategory(string name)
        {

            Category category = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Category WHERE Name = @p_name", conn);
                command.Parameters.Add(new SqlParameter("p_name", name));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        category = new Category(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]));
                    }
                    else
                    {
                        Console.WriteLine("category not found");
                    }
                }
            }

            return category;

        }

        public Boolean setCategory(string oldName, string newName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE Category SET Name = @p_newName WHERE Name = @p_oldName", conn);
                command.Parameters.Add(new SqlParameter("p_newName", newName));
                command.Parameters.Add(new SqlParameter("p_oldName", oldName));

                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean setCategory(int categoryID, string newName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE Category SET Name = @p_newName WHERE CategoryID = @p_categoryID", conn);
                command.Parameters.Add(new SqlParameter("p_newName", newName));
                command.Parameters.Add(new SqlParameter("p_categoryID", categoryID));

                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean insertCategory(string name)
          {
              using (SqlConnection conn = new SqlConnection(connectionString))
              {
                  conn.Open();

                  SqlCommand command = new SqlCommand("INSERT INTO Category VALUES(@p_name);", conn);
                  command.Parameters.Add(new SqlParameter("p_name", name));

                  try
                  {

                      int result = command.ExecuteNonQuery();
                      return result > 0;

                  }
                  catch (System.Data.SqlClient.SqlException exception)
                  {
                      Console.WriteLine(exception.Message);
                      return false;
                  }


              }
          }

        public Boolean deleteCategory(int categoryID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Category WHERE CategoryID = @p_categoryID", conn);
                command.Parameters.Add(new SqlParameter("p_categoryID", categoryID));


                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean deleteCategory(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Category WHERE Name = @p_name", conn);
                command.Parameters.Add(new SqlParameter("p_name", name));


                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        //*******************************************************CATEGORY END****************************************************

        //*******************************************************LedgerType START************************************************

        public List<LedgerType> getAllLedgerTypes()
        {
            List<LedgerType> ledgerTypeList = new List<LedgerType>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM LedgerType", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LedgerType ledgerType = new LedgerType(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]));
                        ledgerTypeList.Add(ledgerType);
                    }
                }
            }

            return ledgerTypeList;
        }

        public LedgerType getLedgerType(int ledgerTypeID)
        {

            LedgerType ledgerType = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM LedgerType WHERE LedgerTypeID = @p_ledgerTypeID", conn);
                command.Parameters.Add(new SqlParameter("p_ledgerTypeID", ledgerTypeID));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ledgerType = new LedgerType(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]));
                    }
                    else
                    {
                        Console.WriteLine("ledgerType not found");
                    }
                }
            }

            return ledgerType;

        }

        public LedgerType getLedgerType(string name)
        {

            LedgerType ledgerType = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM LedgerType WHERE Name = @p_name", conn);
                command.Parameters.Add(new SqlParameter("p_name", name));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ledgerType = new LedgerType(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]));
                    }
                    else
                    {
                        Console.WriteLine("ledgerType not found");
                    }
                }
            }

            return ledgerType;

        }

        public Boolean setLedgerType(string oldName, string newName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE LedgerType SET Name = @p_newName WHERE Name = @p_oldName", conn);
                command.Parameters.Add(new SqlParameter("p_newName", newName));
                command.Parameters.Add(new SqlParameter("p_oldName", oldName));

                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean setLedgerType(int ledgerTypeID, string newName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE LedgerType SET Name = @p_newName WHERE LedgerTypeID = @p_ledgerTypeID", conn);
                command.Parameters.Add(new SqlParameter("p_ledgerTypeID", ledgerTypeID));
                command.Parameters.Add(new SqlParameter("p_newName", newName));

                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean insertLedgerType(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("INSERT INTO LedgerType VALUES(@p_name);", conn);
                command.Parameters.Add(new SqlParameter("p_name", name));

                try
                {

                    int result = command.ExecuteNonQuery();
                    return result > 0;

                }
                catch (System.Data.SqlClient.SqlException exception)
                {
                    Console.WriteLine(exception.Message);
                    return false;
                }


            }
        }

        public Boolean deleteLedgerType(int ledgerTypeID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM LedgerType WHERE LedgerTypeID = @p_ledgerTypeID", conn);
                command.Parameters.Add(new SqlParameter("p_ledgerTypeID", ledgerTypeID));


                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean deleteLedgerType(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM LedgerType WHERE Name = @p_name", conn);
                command.Parameters.Add(new SqlParameter("p_name", name));


                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        //*******************************************************LedgerType END************************************************

        //*******************************************************Item START************************************************

        public List<Item> getAllItems()
        {
            List<Item> itemList = new List<Item>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Item", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item item = new Item(Convert.ToInt32(reader[0]), 
                            Convert.ToString(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToInt32(reader[4]));

                        itemList.Add(item);
                    }
                }
            }

            return itemList;
        }

        public Item getItem(int itemID)
        {

            Item item = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Item WHERE itemID = @p_itemID", conn);
                command.Parameters.Add(new SqlParameter("p_itemID", itemID));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        item = new Item(Convert.ToInt32(reader[0]),
                            Convert.ToString(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToInt32(reader[4]));
                    }
                    else
                    {
                        Console.WriteLine("item not found");
                    }
                }
            }

            return item;

        }

        public Item getItem(string name)
        {

            Item item = null;
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Item WHERE Name = @p_name", conn);
                command.Parameters.Add(new SqlParameter("p_name", name));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        item = new Item(Convert.ToInt32(reader[0]),
                            Convert.ToString(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToInt32(reader[4]));


                    }
                    else
                    {
                        Console.WriteLine("item not found");
                    }
                }
            }

            return item;

        }

        public List<Item> getItemByCategoryID(int categoryID)
        {

            List<Item> itemList = new List<Item>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Item WHERE categoryID = @p_categoryID", conn);
                command.Parameters.Add(new SqlParameter("p_categoryID", categoryID));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item item = new Item(Convert.ToInt32(reader[0]),
                            Convert.ToString(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToInt32(reader[4]));
                        itemList.Add(item);

                    }
                }
            }

            return itemList;

        }

        public List<Item> getItemByBrandID(int brandId)
        {

            List<Item> itemList = new List<Item>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Item WHERE brandId = @p_brandId", conn);
                command.Parameters.Add(new SqlParameter("p_brandId", brandId));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item item = new Item(Convert.ToInt32(reader[0]),
                            Convert.ToString(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToInt32(reader[4]));
                        itemList.Add(item);

                    }
                }
            }

            return itemList;

        }

        public Boolean setItem(string oldName, string newName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE Item SET Name = @p_newName WHERE Name = @p_oldName", conn);
                command.Parameters.Add(new SqlParameter("p_newName", newName));
                command.Parameters.Add(new SqlParameter("p_oldName", oldName));

                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean setItem(int itemID, string newName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE Item SET Name = @p_newName WHERE itemID = @p_itemID", conn);
                command.Parameters.Add(new SqlParameter("p_newName", newName));
                command.Parameters.Add(new SqlParameter("p_itemID", itemID));

                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean insertItem(Item item)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Item VALUES(@p_name,@p_categoryID,@p_brandId,@p_initialStock);", conn);
                command.Parameters.Add(new SqlParameter("p_name", item.getName()));
                command.Parameters.Add(new SqlParameter("p_categoryID", item.getCategoryID()));
                command.Parameters.Add(new SqlParameter("p_brandId", item.getBrandID()));
                command.Parameters.Add(new SqlParameter("p_initialStock", item.getInitialStock()));

                try
                {

                    int result = command.ExecuteNonQuery();
                    return result > 0;

                }
                catch (System.Data.SqlClient.SqlException exception)
                {
                    Console.WriteLine(exception.Message);
                    return false;
                }


            }
        }

        public Boolean deleteItem(int itemID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Item WHERE itemID = @p_itemID", conn);
                command.Parameters.Add(new SqlParameter("p_itemID", itemID));


                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean deleteItem(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Item WHERE Name = @p_name", conn);
                command.Parameters.Add(new SqlParameter("p_name", name));


                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        //*******************************************************Item END************************************************

        //*******************************************************ItemLedger START************************************************
        
        public List<ItemLedger> getAllItemLedgers()
        {
            List<ItemLedger> itemLedgerList = new List<ItemLedger>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM ItemLedger", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemLedger itemLedger = new ItemLedger(Convert.ToInt32(reader[0]),
                            Convert.ToInt32(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToDateTime(reader[4]));

                        itemLedgerList.Add(itemLedger);
                    }
                }
            }

            return itemLedgerList;
        }

        public List<ItemLedger> getLedgerItemByItemID(int itemID)
        {

            List<ItemLedger> itemLedgerList = new List<ItemLedger>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM ItemLedger WHERE itemID = @p_itemID", conn);
                command.Parameters.Add(new SqlParameter("p_itemID", itemID));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemLedger itemLedger = new ItemLedger(Convert.ToInt32(reader[0]),
                            Convert.ToInt32(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToDateTime(reader[4]));

                        itemLedgerList.Add(itemLedger);

                    }
                }
            }

            return itemLedgerList;

        }

        public List<ItemLedger> getLedgerItemByLedgerTypeID(int ledgerTypeID)
        {

            List<ItemLedger> itemLedgerList = new List<ItemLedger>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM ItemLedger WHERE ledgerTypeID = @p_ledgerTypeID", conn);
                command.Parameters.Add(new SqlParameter("p_ledgerTypeID", ledgerTypeID));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemLedger itemLedger = new ItemLedger(Convert.ToInt32(reader[0]),
                            Convert.ToInt32(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToDateTime(reader[4]));

                        itemLedgerList.Add(itemLedger);

                    }
                }
            }

            return itemLedgerList;

        }

        public List<ItemLedger> getLedgerItemByQuantity(int quantity)
        {

            List<ItemLedger> itemLedgerList = new List<ItemLedger>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM ItemLedger WHERE quantity = @p_quantity", conn);
                command.Parameters.Add(new SqlParameter("p_quantity", quantity));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemLedger itemLedger = new ItemLedger(Convert.ToInt32(reader[0]),
                            Convert.ToInt32(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToDateTime(reader[4]));

                        itemLedgerList.Add(itemLedger);

                    }
                }
            }

            return itemLedgerList;

        }

        public List<ItemLedger> getLedgerItemByDateOccured(String dateOccured)
        {

            List<ItemLedger> itemLedgerList = new List<ItemLedger>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM ItemLedger WHERE DateOccured = CONVERT(Date, [DateOccured], 102)", conn);
                //command.Parameters.Add(new SqlParameter("p_quantity", dateOccured));
                command.Parameters.Add("@Date", SqlDbType.Date).Value = dateOccured;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemLedger itemLedger = new ItemLedger(Convert.ToInt32(reader[0]),
                            Convert.ToInt32(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToDateTime(reader[4]));

                        itemLedgerList.Add(itemLedger);

                    }
                }
            }

            return itemLedgerList;

        }

        public List<ItemLedger> getLedgerItemByDateOccuredBefore(String dateOccured)
        {

            List<ItemLedger> itemLedgerList = new List<ItemLedger>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM ItemLedger WHERE DateOccured >= CONVERT(Date, [DateOccured], 102)", conn);
                //command.Parameters.Add(new SqlParameter("p_quantity", dateOccured));
                command.Parameters.Add("@Date", SqlDbType.Date).Value = dateOccured;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemLedger itemLedger = new ItemLedger(Convert.ToInt32(reader[0]),
                            Convert.ToInt32(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToDateTime(reader[4]));

                        itemLedgerList.Add(itemLedger);

                    }
                }
            }
            return itemLedgerList;

        }

        public List<ItemLedger> getLedgerItemByDateOccuredAfter(String dateOccured)
        {

            List<ItemLedger> itemLedgerList = new List<ItemLedger>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM ItemLedger WHERE DateOccured <= CONVERT(Date, [DateOccured], 102)", conn);
                //command.Parameters.Add(new SqlParameter("p_quantity", dateOccured));
                command.Parameters.Add("@Date", SqlDbType.Date).Value = dateOccured;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemLedger itemLedger = new ItemLedger(Convert.ToInt32(reader[0]),
                            Convert.ToInt32(reader[1]),
                            Convert.ToInt32(reader[2]),
                            Convert.ToInt32(reader[3]),
                            Convert.ToDateTime(reader[4]));

                        itemLedgerList.Add(itemLedger);

                    }
                }
            }


            return itemLedgerList;
        

        }

        public Boolean setLedgerItem(int itemID, int newQuantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE ItemLedger SET quantity = @p_newQuantity WHERE itemID = @p_itemID", conn);
                command.Parameters.Add(new SqlParameter("p_newQuantity", newQuantity));
                command.Parameters.Add(new SqlParameter("p_itemID", itemID));

                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }

        public Boolean insertLedgerItem(ItemLedger ledgerItem)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("INSERT INTO ItemLedger VALUES(@p_ledgerTypeID,@p_itemID,@p_quantity,@p_dateOccured);", conn);
                command.Parameters.Add(new SqlParameter("p_itemID", ledgerItem.getItemID()));
                command.Parameters.Add(new SqlParameter("p_ledgerTypeID", ledgerItem.getLedgerTypeID()));
                command.Parameters.Add(new SqlParameter("p_quantity", ledgerItem.getQuantity()));
                command.Parameters.Add(new SqlParameter("p_dateOccured", ledgerItem.getDateOccured().ToString("yyyy-MM-dd HH:mm:ss")));
                Console.WriteLine(command.Parameters);
                //command.Parameters.Add("@Date", SqlDbType.Date).Value = ledgerItem.getDateOccured();

                try
                {

                    int result = command.ExecuteNonQuery();
                    return result > 0;

                }
                catch (System.Data.SqlClient.SqlException exception)
                {
                    Console.WriteLine(exception.Message);
                    return false;
                }


            }
        }

        public Boolean deleteLedgerItem(int ledgerID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM ItemLedger WHERE ledgerID = @p_ledgerID", conn);
                command.Parameters.Add(new SqlParameter("p_ledgerID", ledgerID));

                int result = command.ExecuteNonQuery();
                return result > 0;

            }
        }
    }
}