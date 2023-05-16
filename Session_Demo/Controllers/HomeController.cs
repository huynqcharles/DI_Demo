using Microsoft.AspNetCore.Mvc;

namespace Session_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("MySession", "nguyenquanghuy_session");
            return View();
        }
    }
}
