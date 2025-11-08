using ECommerce.Core.Entities;
using ECommerce.Data;
using ECommerce.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_UI.Controllers
{
    public class NewsController : Controller
    {
        private readonly IService<News> _service;
        public NewsController(IService<News> service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _service.GetAllAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound("Invalid Request!");
            }

            var news = await _service.
                GetAsync(m => m.Id == id && m.IsActive);
            if (news == null)
            {
                return NotFound("No active campaign found.");
            }

            return View(news);
        }
    }
}
