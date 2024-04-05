using Microsoft.AspNetCore.Mvc;

namespace FruitSellingWebsite.Controllers 
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
