using Microsoft.AspNetCore.Mvc;

namespace HairDressR.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
