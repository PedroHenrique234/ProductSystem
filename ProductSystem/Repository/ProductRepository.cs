using ProductSystem.Data;
using ProductSystem.Models;
using System.Globalization;

namespace ProductSystem.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly BankContext _bankContext;
        public ProductRepository(BankContext bankContext) 
        {
            _bankContext = bankContext;
        }
        public ProductModel AddProduct(ProductModel product)
        {
            product.TotalPrice = product.Price * product.Quantity;

            _bankContext.Products.Add(product);
            _bankContext.SaveChanges();
            return product;
        }

        public List<ProductModel> FindAllProducts()
        {
            return _bankContext.Products.ToList();
        }
    }
}
