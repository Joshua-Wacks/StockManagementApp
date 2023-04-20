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