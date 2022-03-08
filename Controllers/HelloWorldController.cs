using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /Hello/

        public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /Hello/Goodbye/ 
        public string Goodbye()
        {
            return "Goodbye!";
        }

        // 
        // GET: /Hello/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}