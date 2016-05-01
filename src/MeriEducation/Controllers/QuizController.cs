using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MeriEducation.Models;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Identity;
using System.Security.Claims;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace System.Controllers
{
    public class QuizController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public QuizController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByIdAsync(User.GetUserId());
            ViewBag.User = user;
            return View(_db.Quizzes.ToList());
        }

        public async Task<IActionResult> Details(int id)
        {
            var user = await _userManager.FindByIdAsync(User.GetUserId());
            ViewBag.User = user;
            var thisQuiz = _db.Quizzes.Include(quizzes => quizzes.Questions).ToList().FirstOrDefault(quizzes => quizzes.QuizId == id);
            return View(thisQuiz);
        }

    }
}
