using System.Diagnostics;
using E_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
    public class HomeController : Controller
    {
        EcommerceContext db =new EcommerceContext();
       

        public IActionResult Index()
        {
            var cats=db.Categories.ToList();
            ViewBag.Products=db.Products.ToList();
            return View(cats);

        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Categories()
        {
          var cats=  db.Categories.ToList();
            return View(cats);
        }
        public IActionResult Products(int id)
        {
            var products = db.Products.Where(x => x.catid == id).ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult ProductSearch(string xname)
        {
            var products = db.Products.Where(x => x.name.Contains(xname)).ToList();
            return View(products);
        }

        [HttpPost]
        public IActionResult sendReview(Review model)
        {
            db.Reviews.Add(new Review { name = model.name, email = model.email, subject = model.subject, description = model.description });
            db.SaveChanges();
            return RedirectToAction("index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
