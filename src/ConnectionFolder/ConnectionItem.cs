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
                command.Parameters.Add(new SqlParameter("p_name", item.name));
                command.Parameters.Add(new SqlParameter("p_categoryID", item.categoryID));
                command.Parameters.Add(new SqlParameter("p_brandId", item.brandId));
                command.Parameters.Add(new SqlParameter("p_initialStock", item.initialStock));

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
    }
}