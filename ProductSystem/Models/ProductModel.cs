namespace ProductSystem.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public  double Price { get; set; }
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
