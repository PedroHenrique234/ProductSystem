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
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Make(ProductModel product)
        {
            _productRepository.AddProduct(product);

            return RedirectToAction("Index");
        }
    }
}
