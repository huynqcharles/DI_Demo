using DI_Demo.IServices;
using DI_Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICombatService _combatService;
        public HomeController(ICombatService combatService)
        {
            _combatService = combatService;
        }
        public IActionResult Index()
        {
            ViewBag.Damage = _combatService.Damage(100, 20);
            return View();
        }
    }
}
