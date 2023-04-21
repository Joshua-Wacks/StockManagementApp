using System;
using System.Data;
using System.Data.SqlClient;
using ModelsNS;

namespace ConnectionNS
{
    public partial class Connection
    {

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
    }
}