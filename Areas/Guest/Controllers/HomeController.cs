using Microsoft.AspNetCore.Mvc;
using SanPhamChauPhu.Helper;

namespace SanPhamChauPhu.Areas.Guest.Controllers
{
   
    [Area("Guest")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private ProductHelper productHelper;




        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        [Route("home")]
       public async Task<IActionResult> Index()
        {
            var products = new ProductHelper(_context).GetAllProducts();
            this.productHelper = new ProductHelper(_context);
            var products1 = productHelper.GetAllProducts(); 
            ViewData["Message"] = products;
            return View(products);

        }


        //public IActionResult Privacy()
        //{
        //    //var products = new ProductHelper(_context).GetAllProducts();
        //    //ViewData["Message"] = products;
        //    return View();

        //}
    }
}
