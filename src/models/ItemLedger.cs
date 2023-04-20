//using System.DateTime;

namespace ModelsNS
{
    public class ItemLedger
    {
        public int itemID { get; set; }
        public int ledgerID { get; set; }
        public int ledgerTypeID { get; set; }
        public int quantity { get; set; }
        public System.DateTime dateOccured { get; set; }

        public ItemLedger(int itemID, int ledgerID, int ledgerTypeID, int quantity, System.DateTime dateOccured)
        {
            this.itemID = itemID;
            this.ledgerID = ledgerID;
            this.ledgerTypeID = ledgerTypeID;
            this.quantity = quantity;
            this.dateOccured = dateOccured;
        }

        public ItemLedger(int itemID, int ledgerTypeID, int quantity, System.DateTime dateOccured)
        {
            this.itemID = itemID;
            this.ledgerTypeID = ledgerTypeID;
            this.quantity = quantity;
            this.dateOccured = dateOccured;
        }

        public string getDateString() {
            string dateStr = dateOccured.Year + "-" + dateOccured.Month + "-" + dateOccured.Day +
                "-" + dateOccured.Hour + "-" + dateOccured.Minute + "-" + dateOccured.Second;
            return dateStr;
        }
    }
}