namespace ModelsNS
{
	public class Category
	{
		private int categoryID;
		private string name;

		public Category(int categoryID, string name)
		{
			this.categoryID = categoryID;
			this.name = name;
		}

		public int getCategoryID() { return categoryID; }

		public void setCategoryID(int categoryID) { this.categoryID = categoryID; }

		public string getName() { return name; }

		public void setName(string name) { this.name = name; }


	}
}
