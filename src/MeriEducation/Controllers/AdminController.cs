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
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AdminController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
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

        public async Task<IActionResult> Quizzes()
        {
            var user = await _userManager.FindByIdAsync(User.GetUserId());
            ViewBag.User = user;
            return View(_db.Quizzes.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddQuizViewModel model)
        {
            var quiz = new Quiz
            {
                Name = model.Name,
                Grade = model.Grade
            };

            var question = new Question
            {
                QuestionText = model.QuestionText,
                Answer1 = model.Answer1,
                Answer2 = model.Answer2,
                Answer3 = model.Answer3,
                Answer4 = model.Answer4,
                CorrectAnswer = model.CorrectAnswer
            };

            {
                _db.Quizzes.Add(quiz);
                question.QuizId = quiz.QuizId;
                _db.Questions.Add(question);
                _db.SaveChanges();
                return RedirectToAction("Quizzes");

            }
        }

        public IActionResult Details(int id)
        {
            var thisQuiz = _db.Quizzes.Include(quizes => quizes.Questions).ToList().FirstOrDefault(quizes => quizes.QuizId == id);
            return View(thisQuiz);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            var thisquiz = _db.Quizzes.FirstOrDefault(x => x.QuizId == id);
            _db.Quizzes.Remove(thisquiz);
            _db.SaveChanges();
            return RedirectToAction("Quizzes");
        }

        public ActionResult Edit(int id)
        {
            var thisquiz = _db.Quizzes.FirstOrDefault(quizes => quizes.QuizId == id);
            return View(thisquiz);
        }
        [HttpPost]
        public ActionResult Edit(Quiz quiz)
        {
            _db.Entry(quiz).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Quizzes");
        }

        public ActionResult EditQuestion(int id)
        {
            var thisquestion = _db.Questions.FirstOrDefault(questions => questions.QuestionId == id);
            return View(thisquestion);
        }
        [HttpPost]
        public ActionResult EditQuestion(Question question)
        {
            _db.Entry(question).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Quizzes");
        }
    }
}
