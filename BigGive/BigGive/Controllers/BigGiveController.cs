using Microsoft.AspNetCore.Mvc;

namespace BigGive.Controllers
{
    public class BigGiveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
