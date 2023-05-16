using Microsoft.AspNetCore.Mvc;

namespace Session_Demo.Controllers
{
    public class ShowController : Controller
    {
        public IActionResult Index()
        {
            var session = HttpContext.Session.GetString("MySession");

            if (session == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
