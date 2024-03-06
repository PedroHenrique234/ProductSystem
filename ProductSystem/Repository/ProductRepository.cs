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

        public ProductModel FindById(int id)
        {
            return _bankContext.Products.FirstOrDefault(x => x.Id == id);
        }

        public bool Remove(int id)
        {
            ProductModel productDb = FindById(id);

            if (productDb == null) throw new Exception("Impossível apagar o contato");

            _bankContext.Remove(productDb);
            _bankContext.SaveChanges();
            return true;
        }
    }
}
