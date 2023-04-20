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
    }
}