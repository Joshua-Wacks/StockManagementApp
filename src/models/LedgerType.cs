namespace ModelsNS
{
    public class LedgerType
    {
        private int ledgerTypeID;
        private string name;

        public LedgerType(int ledgerTypeID, string name)
        {
            this.ledgerTypeID = ledgerTypeID;
            this.name = name;
        }

        public int getLedgerTypeID() { return ledgerTypeID; }

        public void setLedgerTypeID(int ledgerTypeID) { this.ledgerTypeID = ledgerTypeID; }

        public string getName() { return name; }

        public void setName(string name) { this.name = name; }


    }
}
