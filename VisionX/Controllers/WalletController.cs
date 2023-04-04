using Microsoft.AspNetCore.Mvc;

namespace VisionX.Controllers
{
    public class WalletController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
