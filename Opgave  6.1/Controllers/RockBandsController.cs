using Microsoft.AspNetCore.Mvc;

namespace Opgave__6._1.Controllers
{
    public class RockBandsController : Controller
    {
        public IActionResult Index()
        {
            string[] rockBands = ["ACDC", "Offspring", "The Who", "Dire Straits", "U2", "Guns n Roses", "Sum 41", "Ramstein", "Avanstasia", "Twisted sisters"];
            ViewBag.rockBands = rockBands;

            return View("RockBands");
        }
    }
}
