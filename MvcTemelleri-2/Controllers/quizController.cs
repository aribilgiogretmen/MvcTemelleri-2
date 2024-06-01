using Microsoft.AspNetCore.Mvc;

namespace MvcTemelleri_2.Controllers
{
    public class quizController : Controller
    {
        public IActionResult Index()
        {

            ViewData["Question"] = "Türkiyenin Başkenti Neresi ?";
            ViewData["Answer"] = "Ankara";

            return View();
        }

        [HttpPost]
        public IActionResult Index(string userAnswer)
        {
            ViewData["Question"] = "Türkiyenin Başkenti Neresi ?";
            ViewData["Answer"] = "Ankara";

            string correctAnswer = ViewData["Answer"].ToString();
            ViewData["userAnswer"] = userAnswer;

            if (userAnswer.Equals(correctAnswer,StringComparison.OrdinalIgnoreCase))
            {
                ViewData["Result"] = "Doğru Cevap";
            }
            else
            {
                ViewData["Result"] = $"Yanlış Cevap, Doğru Cevap {correctAnswer}";
            }
            return View();
        }
    }
}
