using BusinessLayer.Repository;
using BusinessLayer.Valudation;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinalExam.Controllers
{
    public class AdminController : Controller
    {
        IUserMan um = new IUserMan(new UserRepo());
        
        private readonly IToastNotification _toastNotification;

        public AdminController(IToastNotification toastNotification)
        {
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return RedirectToAction("Chat", "Admin");
        }
        [Authorize(Roles = "Admin,User")]
        public IActionResult Chat()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Login(User use)
        { 
            Context c = new Context();
            var admin = c.Users.FirstOrDefault(x => x.UserName == use.UserName && x.UserPassword == use.UserPassword);
            if (admin != null  )
            {
                var claims = new List<Claim> 
                { new Claim(ClaimTypes.Name,admin.UserName), 
                 new Claim(ClaimTypes.Role, admin.UserRole)
                };
                var useridentity = new ClaimsIdentity(claims, "Login"); 
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);                                                          
                await HttpContext.SignInAsync(principal); 
                _toastNotification.AddSuccessToastMessage("Başarılı giriş");
                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("Chat", "Admin");
                }

            }
            if (use.UserName == "admin" && use.UserPassword == "123456")
            {
                var claims = new List<Claim>
                { new Claim(ClaimTypes.Name,"admindefault"),
                 new Claim(ClaimTypes.Role, "Admin")
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                _toastNotification.AddSuccessToastMessage("Başarılı giriş");
                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("Chat", "Admin");
                }
            }
            _toastNotification.AddErrorToastMessage("Bilgileriniz yanlış");
            return View();

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User use)
        {
            UserValidation studentValidator = new UserValidation();
            _ = studentValidator.Validate(use);

            um.Adding(use);
            return RedirectToAction("Login");


        }


        public async Task<IActionResult> Cıkıs()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }
     
        public async Task<IActionResult> User()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://63877911d9b24b1be3f19326.mockapi.io/rea-task-final/users");
            string responseBody = await response.Content.ReadAsStringAsync();
            var result=   JsonConvert.DeserializeObject<List<UserClient>>(responseBody);
            //var values = um.Listing();
            return View(result);
        }
        public IActionResult Ekle()
        {
            return View();

        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Ekle(User use)
        {
            UserValidation _rule = new UserValidation();
            FluentValidation.Results.ValidationResult results = _rule.Validate(use);
            if (results.IsValid)
            {
                um.Adding(use);
                return RedirectToAction("User", "Admin");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        [HttpGet]
        public IActionResult Sil(int id)
        {
            using (Context c = new Context())
            {
                var result = c.Users.FirstOrDefault(o => o.UserId == id);
                c.Users.Remove(result);
                c.SaveChanges();
            }

            return RedirectToAction("User");

        }

       [HttpGet]
        public async Task<IActionResult> Guncelle(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://63877911d9b24b1be3f19326.mockapi.io/rea-task-final/users/"+id);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<UserClient>(responseBody);
            //using (Context c = new Context())
            //{
            //    var result = c.Users.FirstOrDefault(o => o.UserId == id);
            //    return View(result);
            //}
            return View(result);
        }

        [HttpPost]
        public IActionResult Guncelle(User use)
        {
            UserValidation _rule = new UserValidation();
            FluentValidation.Results.ValidationResult results = _rule.Validate(use);
            if (results.IsValid)
            {
                var result = um.Updating(use);
                return RedirectToAction("User", "Admin");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
             

             
        }
      
    }
}
