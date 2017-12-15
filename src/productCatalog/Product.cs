namespace src.ProductCatalog
{
    public class Product
    {
        public string Category { get; set; }
        public int Price { get; set; }
        public Product(string category, int price)
        {
            Category = category;
            Price = price;
        }
    }
}
