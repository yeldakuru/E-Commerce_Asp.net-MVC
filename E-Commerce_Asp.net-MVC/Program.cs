using ECommerce.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options=>
{
    options.Cookie.Name = ".ECommerce.Session";//session cookie adý
    options.Cookie.HttpOnly = true;//sadece sunucu tarafýnda eriþilebilir
    options.Cookie.IsEssential = true;//gizlilik politikalarýndan baðýmsýz olarak gerekli
    options.IdleTimeout = TimeSpan.FromDays(1);//boþta kalma süresi
    options.IOTimeout = TimeSpan.FromMinutes(10);//giriþ/çýkýþ iþlemleri için zaman aþýmý süresi
});//bir kullanýcýnýn oturumu boyunca (örneðin siteye giriþ yaptýðý süre boyunca)
//veriyi sunucuda saklamak için kullanýlýr.




builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x=>
    {
        x.LoginPath = "/Account/SignIn";
        x.AccessDeniedPath = "/AccessDenied";
        x.Cookie.Name = "Account";
        x.Cookie.MaxAge = TimeSpan.FromDays(7);
        x.Cookie.IsEssential = true;
    });//cookie tabanlý authentication ekleniyor

builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("AdminPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin"));//sadece Admin rolüne sahip kullanýcýlar eriþebilir
    x.AddPolicy("UserPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin", "User", "Customer"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthentication(); // önce oturum açma
app.UseAuthorization(); // sonra yetkilendirme


app.MapControllerRoute(
 name: "admin",
 pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
         );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
