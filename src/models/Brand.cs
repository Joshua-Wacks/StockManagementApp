namespace ModelsNS
{
    public class Brand
    {
        public int brandId { get; set; }
        public string name { get; set; }

        public Brand(int brandID,string name) { 
            this.brandId = brandID;
            this.name = name;
        }

        public int getBrandId() { return brandId; }

        public void setBrandId(int brandID) { this.brandId = brandID; }

        public string getName() { return name; }

        public void setName(string name) { this.name = name;}

          
    }
}
