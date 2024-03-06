using Microsoft.AspNetCore.Mvc;
using ProductSystem.Models;
using ProductSystem.Repository;

namespace ProductSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            List<ProductModel> product = _productRepository.FindAllProducts();
            return View(product);
        }
        public IActionResult Make()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            ProductModel product =_productRepository.FindById(id);
            return View(product);
        }
        public IActionResult DeletConfirm(int id)
        {
            ProductModel product = _productRepository.FindById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Make(ProductModel product)
        {
            _productRepository.AddProduct(product);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(ProductModel product)
        {
            _productRepository.UpdateProduct(product);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            _productRepository.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
