using System;
using System.Data;
using System.Data.SqlClient;
using ModelsNS;

namespace ConnectionNS
{
    public partial class Connection
    {

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
    }
}