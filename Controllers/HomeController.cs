using FruitSellingWebsite.Models;
using FruitSellingWebsite.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FruitSellingWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _dataContext = context;
        }

        public IActionResult Index()
        {
            var products = _dataContext.Products.Include("Category").Include("Brand").ToList();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statuscode)
        {
            if(statuscode == 404)
            {
                return View("NotFound");
            }
            else
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

		[HttpPost]
		public async Task<IActionResult> Search(string query)
		{
			if (!string.IsNullOrEmpty(query))
			{
				var searchResults = await _dataContext.Products
					.Include(p => p.Category)
					.Include(p => p.Brand)
					.Where(p => p.Name.Contains(query) || p.Category.Name.Contains(query) || p.Brand.Name.Contains(query))
					.ToListAsync();

				return View("Index", searchResults);
			}

			return View("Index");
		}
	}
}
