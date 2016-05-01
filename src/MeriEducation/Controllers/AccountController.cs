using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Identity;
using MeriEducation.Models;
using MeriEducation.ViewModels;
using System.Security.Claims;

namespace MeriEducation.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByIdAsync(User.GetUserId());
            ViewBag.User = user;
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var user = new ApplicationUser { UserName = model.Email, FirstName = model.FirstName, LastName = model.LastName, Points = 0};

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Student");
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult RegisterTeacher()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterTeacher(RegisterViewModel model)
        {
            var user = new ApplicationUser { UserName = model.Email, FirstName = model.FirstName, LastName = model.LastName};

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Teacher");
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

    }
}