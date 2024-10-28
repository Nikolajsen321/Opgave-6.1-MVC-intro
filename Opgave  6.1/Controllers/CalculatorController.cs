using Microsoft.AspNetCore.Mvc;

namespace Opgave__6._1.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            // Omdirigerer til TimeCalculator
            return RedirectToAction("TimeCalculator");
        }

        [HttpGet]
        public IActionResult TimeCalculator() {
                return View();
            }

        [HttpPost]
        public IActionResult TimeCalculator(IFormCollection formCollection)
        {
            int hours = Convert.ToInt32(formCollection["Hours"]);
            int minutes = Convert.ToInt32(formCollection["Minutes"]);
            int seconds = Convert.ToInt32(formCollection["Seconds"]);
            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
            double total = ts.TotalSeconds;

            ViewBag.totalSeconds = total;
            ViewBag.hours = hours; 
            ViewBag.minutes = minutes;
            ViewBag.seconds = seconds;

            return View("TimeCalculatorResult");

        }
    }
}
