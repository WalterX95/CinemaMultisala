using Microsoft.AspNetCore.Mvc;

namespace CinemaMultisala.Controllers
{
    public class CinemaController : Controller
    {

        // GET: /CinemaController/Index
        
        public IActionResult Sala()
        {
             return View();
          
        }
        // 
        public IActionResult SalaNord()
        {
            return View();
        }
        
        public IActionResult SalaSud()
        {
            return View();
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
