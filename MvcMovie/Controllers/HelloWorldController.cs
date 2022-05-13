using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            
            return View();
        }
        
        // GET: /HelloWorld/Welcome/ 

        public string Test(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, your ID: {ID}");
        }
    }
}