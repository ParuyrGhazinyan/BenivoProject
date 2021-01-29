using Benivo.Services.Interfaces;
using BenivoProject.Domain.Core;
using BenivoProject.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BenivoProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = userService.GetUsers(x => x.UserName == model.UserName).FirstOrDefault();
                if(user==null)
                {
                    user = new User { UserName = model.UserName, Password = model.Password };
                    
                    await userService.InsertUser(user);

                    await Authenticate(user); 

                    return RedirectToAction("Index", "Job");
                }
            }
            return RedirectToAction("Index", "Job");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user =await userService.GetUsers(x => x.UserName == model.UserName && x.Password == model.Password).FirstOrDefaultAsync();
                if (user != null)
                {
                    await Authenticate(user); 
                    return RedirectToAction("Index", "Job");
                }
            }
            return RedirectToAction("Index", "Job");
        }
      
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("index","Job");
        }
        private async Task Authenticate(User user)
        {           
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
