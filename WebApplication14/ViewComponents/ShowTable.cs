using Microsoft.AspNetCore.Mvc;
using WebApplication14.Models;

namespace WebApplication14.ViewComponents
{
    public class ShowTable : ViewComponent
    {
        public IViewComponentResult Invoke(List<Product> products)
        {
            return View(products);
        }
    }
}

