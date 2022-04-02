using Microsoft.AspNetCore.Mvc;
using PracticeGuru.Data;
using PracticeGuru.Models;
using System.Diagnostics;

namespace PracticeGuru.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContexts _db;

        public HomeController(ApplicationDbContexts db)
        {
            _db = db;
        }    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}