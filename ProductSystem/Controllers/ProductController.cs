using Microsoft.AspNetCore.Mvc;

namespace ProductSystem.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
    }
}
