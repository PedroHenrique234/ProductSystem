using ProductSystem.Data;
using ProductSystem.Models;

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
            _bankContext.Add(product);
            _bankContext.SaveChanges();
            return product;
        }
    }
}
