using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginRegC_.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;


namespace LoginRegC_.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet ("Index")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost ("Register")]
        public  IActionResult Register(User newUser)
        {
            if(_context.Users.Any(user => user.Email == newUser.Email))
            {
                ModelState.AddModelError("Email", "Email already in use!");
                return View("Register");
            }

            if(ModelState.IsValid)
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Success");
            }
            return View("Register");
        }
        [HttpGet ("Success")]
        public IActionResult Success()
        {
            return View();
        }

        [HttpGet ("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost ("LoginUser")]
        public IActionResult LoginUser(LoginUser checkUser)
        {
            if(ModelState.IsValid)
            {
                // find user with email
                User userInDb = _context.Users.FirstOrDefault(use => use.Email == checkUser.LoginEmail);
                // if user doesn't exist
                    // send validation error
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Login");
                    return View("Login");
                }
                // verify password
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(checkUser, userInDb.Password, checkUser.LoginPassword);
                    // send validation error
                if(result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid password");
                    return View("Login");
                }

                // put userId in session
                HttpContext.Session.SetInt32("LoggedUserId", userInDb.UserId);
                return RedirectToAction("Success");
            }
            return View("Login");
        }


// =======================Nothing under here================
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
