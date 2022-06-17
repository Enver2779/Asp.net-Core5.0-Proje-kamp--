using Microsoft.AspNetCore.Mvc;

namespace CoreDemo5._0.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
