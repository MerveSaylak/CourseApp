using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
     //localhost:5237/
    //localhost:5237/home
    public class HomeController:Controller
    {
        //localhost:5237/home/index => home/index.cshtml
        public IActionResult Index() {
            //return "home/index";
            int saat=DateTime.Now.Hour;

            ViewBag.Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Merve";
            return View();
        }

        //localhost:5237/home/about => home/about.cshtml
        public IActionResult About()
        {
            return View();
        }
    }
}
