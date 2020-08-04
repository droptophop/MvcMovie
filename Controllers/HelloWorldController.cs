using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //  GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome
        public IActionResult Welcome(string name, int id = 1)
        {
            ViewData["message"] = $"Hello, {name}!";
            ViewData["id"] = id;

            return View();
        }
    }
}