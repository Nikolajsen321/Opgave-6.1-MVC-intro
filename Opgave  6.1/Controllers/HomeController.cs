using Microsoft.AspNetCore.Mvc;

namespace Opgave__6._1.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            string name = "Mikkel Bang";
            int age = 30;
            DateTime birthday = new DateTime(1994, 9, 23);

            ViewBag.name = name;    
            ViewBag.age = age;
            ViewBag.birthday = birthday.ToString("dd-MM-yyyy");

            return View();
        }
    }
}
