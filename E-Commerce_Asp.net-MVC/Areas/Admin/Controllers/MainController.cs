using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_UI.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        [Area("Admin"), Authorize(Policy = "AdminPolicy")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
