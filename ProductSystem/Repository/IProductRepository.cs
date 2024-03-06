using ProductSystem.Models;

namespace ProductSystem.Repository
{
    public interface IProductRepository
    {
        public ProductModel AddProduct(ProductModel product);
        public List<ProductModel> FindAllProducts();
        public ProductModel FindById(int id);
        public bool Remove (int id);
    }
}
