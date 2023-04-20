namespace ModelsNS
{
    public class Item
    {
        private int itemID;
        private string name;
        private int categoryID;
        private int brandId;
        private int initialStock;

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

        public int getItemID() { return itemID; }

        public void setItemID(int itemID) { this.itemID = itemID; }

        public string getName() { return name; }

        public void setName(string name) { this.name = name; }

        public int getCategoryID() { return categoryID; }

        public void setCategoryId(int CategoryId) { this.categoryID = CategoryId; }

        public int getBrandID() { return brandId; }

        public void setBrandId(int brandID) { this.brandId = brandID; }

        public int getInitialStock() { return initialStock; }

        public void setInitialStock(int initialStock) { this.initialStock = initialStock; }

    }
}
