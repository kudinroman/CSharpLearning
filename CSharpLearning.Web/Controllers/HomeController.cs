using CSharpLearning.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSharpLearning.Web.Controllers
{
    public class HomeController : Controller
    {
        public string hello = "";
        public IActionResult Index()
        {
            hello = "Hello";

            return View("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
