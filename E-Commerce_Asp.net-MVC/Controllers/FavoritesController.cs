using ECommerce.Core.Entities;
using ECommerce.Data;
using ECommerce_UI.ExtensionMethods;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_UI.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly DatabaseContext _context;

        public FavoritesController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var favorites = GetFavorites();
            return View(favorites);
        }
        private List<Product> GetFavorites()
        {
            return HttpContext.Session.GetJson<List<Product>>("GetFavorites") ?? [];//eğer sessionda "GetFavorites" anahtarıyla veri yoksa boş liste döner
        }
        public IActionResult Add(int ProductId)
        {
            var favorites = GetFavorites();
            var product = _context.Products.Find(ProductId);
            if (product != null && !favorites.Any(p => p.Id == ProductId))
            {
                favorites.Add(product);
                HttpContext.Session.SetJson("GetFavorites", favorites);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int ProductId)
        {
            var favorites = GetFavorites();
            var product = _context.Products.Find(ProductId);
            if (product != null && favorites.Any(p => p.Id == ProductId))
            {
                favorites.RemoveAll(i => i.Id == product.Id);
                HttpContext.Session.SetJson("GetFavorites", favorites);
            }
            return RedirectToAction("Index");
        }
    }
}
