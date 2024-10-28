using Microsoft.AspNetCore.Mvc;

namespace Opgave__6._1.Controllers
{
    public class SimpleCalculator : Controller
    {


        public IActionResult Index()
        {
            // Omdirigerer til Simple
            return RedirectToAction("SimpCalculator");
        }


        [HttpGet]
        public IActionResult SimpCalculator()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SimpCalculator(IFormCollection formCollection)
        {
            int felt1 = Convert.ToInt32(formCollection["Felt1"]);
            
           int felt2 = Convert.ToInt32(formCollection["Felt2"]);
           string operation = formCollection["operation"];
           int result = 0;

            switch (operation)
            {
                case "+":
                    result = felt1 + felt2;
                    break;
                case "-":
                    result = felt1 - felt2;
                    break;
                case "*": result = felt1 * felt2; break;
                case "/":
                    if (felt2 != 0) // Undgå division med nul
                    {
                        result = felt1 / felt2;
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Kan ikke dividere med nul.";
                        return View();
                    }
                    break;
                default:
                    ViewBag.ErrorMessage = "Ugyldig operation";
                    return View();
            }
            ViewBag.Result = result;
            return View();




            }










        }


    
}
