//using System.DateTime;

namespace ModelsNS
{
    public class ItemLedger
    {
        private int itemID;
        private int ledgerID;
        private int ledgerTypeID;
        private int quantity;
        private System.DateTime dateOccured;

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

        public int getItemID() { return itemID; }

        public void setItemID(int itemID) { this.itemID = itemID; }

        public int getLedgerID() { return ledgerID; }

        public void setLedgerID(int ledgerID) { this.ledgerID = ledgerID; }

        public int getLedgerTypeID() { return ledgerTypeID; }

        public void setLedgerTypeID(int ledgerTypeID) { this.ledgerTypeID = ledgerTypeID; }

        public int getQuantity() { return quantity; }

        public void setQuantity(int quantity) { this.quantity = quantity; }

        public System.DateTime getDateOccured() { return dateOccured; }

        public void setDateOccured(System.DateTime dateOccured) { this.dateOccured = dateOccured; }

        public string getDateString() {
            string dateStr = dateOccured.Year + "-" + dateOccured.Month + "-" + dateOccured.Day +
                "-" + dateOccured.Hour + "-" + dateOccured.Minute + "-" + dateOccured.Second;
            return dateStr;
        }
    }
}