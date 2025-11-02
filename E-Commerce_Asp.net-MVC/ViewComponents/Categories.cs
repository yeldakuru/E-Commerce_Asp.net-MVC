using ECommerce.Core.Entities;
using ECommerce.Data;
using ECommerce.Service.Abstract;
using Microsoft.AspNetCore.Mvc;


namespace ECommerce_UI.ViewComponents
{
    public class Categories : ViewComponent
    {
        private readonly IService<Category> _service;
        public Categories(IService<Category> service)
        {
            _service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            return View(await _service.GetAllAsync(c=>c.IsActive&& c.IsTopMenu ));
        }
    }
}
