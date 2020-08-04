using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //  GET: /HelloWorld/
        public  string Index()
        {
            return "This is my default actions...";
        }
        // GET: /HelloWorld/Welcomes
        public string Welcome(string name, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello, {name}, ID: {id}");
        }
    }
}