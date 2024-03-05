using ProductSystem.Models;

namespace ProductSystem.Repository
{
    public interface IProductRepository
    {
        public ProductModel AddProduct(ProductModel product);
    }
}
