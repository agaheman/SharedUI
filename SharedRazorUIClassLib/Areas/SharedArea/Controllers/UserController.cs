using Microsoft.AspNetCore.Mvc;

namespace SharedRazorUIClassLib.Areas.SharedArea.Controllers
{
    [Area("SharedArea")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OverrideExample()
        {
            return View();
        }
    }
}
