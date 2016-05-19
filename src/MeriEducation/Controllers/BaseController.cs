//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNet.Mvc;
//using Microsoft.AspNet.Identity;
//using MeriEducation.Models;
//using MeriEducation.ViewModels;
//using System.Security.Claims;

//// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

//namespace MeriEducation.Controllers
//{
//    public class BaseController : Controller
//    {
//        public BaseController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//            _db = db;

//        }

//        public async void Controller()
//        {
//            var user = await _userManager.FindByIdAsync(User.GetUserId());
//            ViewBag.User = user;
//        }
//    }
//}
