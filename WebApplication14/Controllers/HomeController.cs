using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<Product> products = new List<Product>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(products.Count);
        }
        [HttpPost]
        public IActionResult Index(Product product)
        {
            products.Add(product);
            return View(products.Count);

        }
        [HttpPost]
        public IActionResult ViewProducts()
        {
            return View("ProductsTable", products);
        }
        [HttpGet]
        public IActionResult ViewProducts(Product product)
        {
            return View(product);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

