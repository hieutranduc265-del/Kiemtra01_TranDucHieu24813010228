namespace TechMartManager
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category(string id, string name)
        {
            CategoryId = id;
            CategoryName = name;
        }
    }
}