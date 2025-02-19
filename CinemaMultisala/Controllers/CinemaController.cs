using Microsoft.AspNetCore.Mvc;

namespace CinemaMultisala.Controllers
{
    public class CinemaController : Controller
    {
     
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
