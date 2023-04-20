namespace ModelsNS
{
    public class Item
    {
        public int itemID { get; set; }
        public string name { get; set; }
        public int categoryID { get; set; }
        public int brandId { get; set; }
        public int initialStock { get; set; }

        public Item(int itemID, string name,int categoryID, int brandId,int initialStock)
        {
            this.itemID = itemID;
            this.name = name;
            this.categoryID = categoryID;
            this.brandId = brandId;
            this.initialStock = initialStock;
        }

        public Item(string name, int categoryID, int brandId, int initialStock)
        {
            this.name = name;
            this.categoryID = categoryID;
            this.brandId = brandId;
            this.initialStock = initialStock;
        }
    }
}
