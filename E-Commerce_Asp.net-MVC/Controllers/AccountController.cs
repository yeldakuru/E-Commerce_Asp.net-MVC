using ECommerce.Core.Entities;
using ECommerce.Service.Abstract;
using ECommerce_UI.Models;
using ECommerce_UI.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ECommerce_UI.Controllers
{
    public class AccountController : Controller
    {
        //private readonly DatabaseContext _context;

        //public AccountController(DatabaseContext context)
        //{
        //    _context = context;
        //}
        private readonly IService<AppUser> _service;
        private readonly IService<Order> _serviceOrder;
        public AccountController(IService<AppUser> service, IService<Order> serviceOrder)
        {
            _service = service;
            _serviceOrder = serviceOrder;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            AppUser user = await _service.GetAsync(x => x.UserGuid.ToString() == HttpContext.User.FindFirst("UserGuid").Value);
            if (user is null)
            {
                return NotFound();
            }
            var model = new UserEditViewModel()
            {

                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                Password = user.Password,
                Phone = user.Phone,
                Surname = user.Surname
            };
            return View(model);
        }
        [HttpPost, Authorize]
        public async Task<IActionResult> IndexAsync(UserEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AppUser user = await _service.GetAsync(x => x.UserGuid.ToString() == HttpContext.User.FindFirst("UserGuid").Value);
                    if (user is not null)
                    {
                        user.Surname = model.Surname;
                        user.Phone = model.Phone;
                        user.Name = model.Name;
                        user.Password = model.Password;
                        user.Email = model.Email;
                        _service.Update(user);
                        var sonuc = _service.SaveChanges();
                        if (sonuc > 0)
                        {
                            TempData["Message"] = @"<div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
                        <strong>Your information has been updated!</strong>
                        <button type=""button"" class=""btn-close"" data-bs-dismiss=""alert"" aria-label=""Close""></button></div>";

                            //  await MailHelper.SendMailAsync(contact);
                            return RedirectToAction("Index");
                        }
                    }
                }
                catch (Exception)
                {

                    ModelState.AddModelError("", "An error occurred!!");
                }
            }
            return View(model);
        }
        [Authorize]
        public async Task<IActionResult> MyOrders()

        {
            AppUser user = await _service.GetAsync(x => x.UserGuid.ToString() == HttpContext.User.FindFirst("UserGuid").Value);
            if (user is null)
            {
                await HttpContext.SignOutAsync();
                return RedirectToAction("SignIn");
            }
            var model = _serviceOrder.GetQueryable().Where(x => x.AppUserId == user.Id).Include(o => o.OrderLines).ThenInclude(p => p.Product);
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignInAsync(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var account = await _service.GetAsync(x => x.Email == loginViewModel.Email && x.Password ==
                    loginViewModel.Password && x.IsActive);

                    if (account == null)
                    {
                        ModelState.AddModelError("", "Login failed!!");
                    }
                    else
                    {
                        var claims = new List<Claim>()
                        { new(ClaimTypes.Name, account.Name),
                            new(ClaimTypes.Role, account.IsAdmin ? "Admin" : "Customer"),
                            new(ClaimTypes.Email, account.Email),
                            new("UserId", account.Id.ToString()),
                            new("UserGuid", account.UserGuid.ToString()),
                        };
                        var userIdentity = new ClaimsIdentity(claims, "Login");
                        ClaimsPrincipal userPrincipal = new ClaimsPrincipal(userIdentity);
                        await HttpContext.SignInAsync(userPrincipal);
                        return Redirect(string.IsNullOrEmpty(loginViewModel.ReturnUrl) ? "/" : loginViewModel.ReturnUrl);
                    }
                }
                catch (Exception error)
                {
                    //loglama yapılabilir
                    ModelState.AddModelError("", "An error occurred!!");

                }
            }
            return View(loginViewModel);
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUpAsync(AppUser appUser)
        {
            appUser.IsAdmin = false;
            appUser.IsActive = true;

            if (ModelState.IsValid)
            {
                await _service.AddAsync(appUser);
                await _service.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appUser);
        }
        public async Task<IActionResult> SignOutAsync()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("SignIn");
        }
        public IActionResult PasswordRenew()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PasswordRenewAsync(string Email)
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                ModelState.AddModelError("", "Email Cannot Be Empty!");
                return View();
            }
            AppUser user = await _service.GetAsync(x => x.Email == Email);
            if (user is null)
            {
                ModelState.AddModelError("", "The email you entered was not found!");
                return View();
            }
            string mesaj = $"Sayın {user.Name} {user.Surname} <br> To Reset Your Password, Please <a href='https://localhost:7239/Account/PasswordChange?user={user.UserGuid.ToString()}'>Click here</a>";
            var sonuc = await MailHelper.SendMailAsync(Email, "Reset My Password", mesaj);
            if (sonuc)
            {
                TempData["Message"] = @"<div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
                        <strong>Your Password Reset Link Has Been Sent To Your Email Address!</strong>
    <button type=""button"" class=""btn-close"" data-bs-dismiss=""alert"" aria-label=""Close""></button>
    </div>";
            }
            else
            {
                TempData["Message"] = @"<div class=""alert alert-danger alert-dismissible fade show"" role=""alert"">
                        <strong>Your Password Reset Link Could Not Be Sent To Your Email Address!</strong>
    <button type=""button"" class=""btn-close"" data-bs-dismiss=""alert"" aria-label=""Close""></button>
    </div>";
            }
            return View();
        }
        public async Task<IActionResult> PasswordChangeAsync(string user)
        {
            if (user is null)
            {
                return BadRequest("Invalid Request!");
            }
            AppUser appUser = await _service.GetAsync(x => x.UserGuid.ToString() == user);
            if (appUser is null)
            {
                return NotFound("Invalid Value!");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PasswordChange(string user, string Password)
        {
            if (user is null)
            {
                return BadRequest("Invalid Request!");
            }
            AppUser appUser = await _service.GetAsync(x => x.UserGuid.ToString() == user);
            if (appUser is null)
            {
                ModelState.AddModelError("", "Invalid Value!");
                return View();
            }
            appUser.Password = Password;
            var sonuc = await _service.SaveChangesAsync();
            if (sonuc > 0)
            {
                TempData["Message"] = @"<div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
                        <strong>Your password has been updated! You can log in from the login screen.</strong>
    <button type=""button"" class=""btn-close"" data-bs-dismiss=""alert"" aria-label=""Close""></button>
    </div>";
            }
            else
            {
                ModelState.AddModelError("", "Update Failed!");
            }
            return View();
        }
    }
}
