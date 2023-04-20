namespace ModelsNS
{
	public class Category
	{
		public int categoryID {get; set; }
		public string name {get; set; }

		public Category(int categoryID, string name)
		{
			this.categoryID = categoryID;
			this.name = name;
		}
	}
}
