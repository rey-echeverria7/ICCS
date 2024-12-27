using Microsoft.AspNetCore.Mvc;

namespace ICCS.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
