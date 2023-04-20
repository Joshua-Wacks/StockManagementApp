namespace ModelsNS
{
    public class LedgerType
    {
        public int ledgerTypeID { get; set; }
        public string name { get; set; }

        public LedgerType(int ledgerTypeID, string name)
        {
            this.ledgerTypeID = ledgerTypeID;
            this.name = name;
        }
    }
}
