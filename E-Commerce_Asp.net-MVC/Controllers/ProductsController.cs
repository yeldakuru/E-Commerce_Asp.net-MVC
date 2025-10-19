﻿using ECommerce.Data;
using ECommerce_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_UI.Controllers
{
    public class ProductsController : Controller
    {

        private readonly DatabaseContext _context;

        public ProductsController(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Products.Where(p=>p.IsActive).Include(p => p.Brand).Include(p => p.Category);
            return View(await databaseContext.ToListAsync());
        }
        

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            var model=new ProductDetailViewModel()
            { 
                Product=product,
                RelatedProducts=_context.Products.Where(p=>p.IsActive && p.CategoryId==
                product.CategoryId && p.Id!=product.Id)
            };
            return View(model);
        }
    }
}
