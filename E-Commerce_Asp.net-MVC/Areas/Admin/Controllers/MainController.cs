using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Asp.net_MVC.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
