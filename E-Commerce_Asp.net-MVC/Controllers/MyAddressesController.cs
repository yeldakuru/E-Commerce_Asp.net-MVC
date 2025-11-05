using ECommerce.Core.Entities;
using ECommerce.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_UI.Controllers
{
    [Authorize]
    public class MyAddressesController : Controller
    {
        private readonly IService<AppUser> _serviceAppUser;
        private readonly IService<Address> _serviceAddress;

        public MyAddressesController(IService<AppUser> service, IService<Address> serviceAddress)
        {    _serviceAppUser = service;
            _serviceAddress = serviceAddress;
        }

     
        public async Task<IActionResult> Index()
        {
            var appUser = await _serviceAppUser.GetAsync(x => x.UserGuid.ToString() == HttpContext.User.FindFirst("UserGuid").Value);
            if (appUser == null)
            {
                return NotFound("User Data Not Found! Please Log Out and Log In Again!");
            }
            var model = await _serviceAddress.GetAllAsync(u => u.AppUserId == appUser.Id);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Address address)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var appUser = await _serviceAppUser.GetAsync(x => x.UserGuid.ToString() == HttpContext.User.FindFirst("UserGuid").Value);
                    if (appUser != null)
                    {
                        address.AppUserId = appUser.Id;
                        _serviceAddress.Add(address);
                        await _serviceAddress.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "An Error Occured!");
                }
            }
            ModelState.AddModelError("", "Registration Failed!");
            return View(address);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var appUser = await _serviceAppUser.GetAsync(x => x.UserGuid.ToString() == HttpContext.User.FindFirst("UserGuid").Value);
            if (appUser == null)
            {
                return NotFound("User Data Not Found! Please Log Out and Log In Again!");
            }
            var model = await _serviceAddress.GetAsync(u => u.AddressGuid.ToString() == id && u.AppUserId == appUser.Id);
            if (model == null)
                return NotFound("Address Info Not Found!");
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//bu token ın geçerliliğini doğrular
        public async Task<IActionResult> Edit(string id, Address address)
        {
            var appUser = await _serviceAppUser.GetAsync(x => x.UserGuid.ToString() == HttpContext.User.FindFirst("UserGuid").Value);
            if (appUser == null)
            {
                return NotFound("User Data Not Found! Please Log Out and Log In Again!");
            }
            var model = await _serviceAddress.GetAsync(u => u.AddressGuid.ToString() == id && u.AppUserId == appUser.Id);
            if (model == null)
                return NotFound("Address Info Not Found!");
            model.Title = address.Title;
            model.District = address.District;
            model.City = address.City;
            model.OpenAddress = address.OpenAddress;
            model.IsDeliveryAddress = address.IsDeliveryAddress;
            model.IsBillingAddress = address.IsBillingAddress;
            model.IsActive = address.IsActive;
            var otherAddresses = await _serviceAddress.GetAllAsync(x => x.AppUserId == appUser.Id && x.Id != model.Id);
            foreach (var otherAddress in otherAddresses)
            {
                otherAddress.IsDeliveryAddress = false;
                otherAddress.IsBillingAddress = false;
                _serviceAddress.Update(otherAddress);
            }
            try
            {
                _serviceAddress.Update(model);
                await _serviceAddress.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "An Error Occured!");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(string id)
        {
            var appUser = await _serviceAppUser.GetAsync(x => x.UserGuid.ToString() == HttpContext.User.FindFirst("UserGuid").Value);
            if (appUser == null)
            {
                return NotFound("User Data Not Found! Please Log Out and Log In Again!");
            }
            var model = await _serviceAddress.GetAsync(u => u.AddressGuid.ToString() == id && u.AppUserId == appUser.Id);
            if (model == null)
                return NotFound("Address Info Not Found!");
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id, Address address)
        {
            var appUser = await _serviceAppUser.GetAsync(x => x.UserGuid.ToString() == HttpContext.User.FindFirst("UserGuid").Value);
            if (appUser == null)
            {
                return NotFound("User Data Not Found! Please Log Out and Log In Again!");
            }
            var model = await _serviceAddress.GetAsync(u => u.AddressGuid.ToString() == id && u.AppUserId == appUser.Id);
            if (model == null)
                return NotFound("Address Info Not Found!");
            try
            {
                _serviceAddress.Delete(model);
                await _serviceAddress.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "An Error Occured!");
            }
            return View(model);
        }
    }
}
