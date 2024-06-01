using Microsoft.AspNetCore.Mvc;

namespace MvcTemelleri_2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username,string password)
        {

            var validusername = "ibrahim";
            var validpassword = "123456";


            if (username==validusername && password==validpassword)
            {
                ViewData["message"] = "Giriş Başarılı";
            }
            else
            {
                ViewData["message"] = "Giriş Başarısız";
            }

            return View();
        }
    }
}
