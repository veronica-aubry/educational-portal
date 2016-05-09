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

namespace MeriEducation.Controllers
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
            var thisQuiz = _db.Quizzes.Include(quizzes => quizzes.Questions).FirstOrDefault(quizzes => quizzes.QuizId == id);
            var questions = thisQuiz.Questions.ToList();
            CompletedQuiz newCompletedQuiz = new CompletedQuiz(id, user.Id);
            _db.CompletedQuizzes.Add(newCompletedQuiz);
            _db.SaveChanges();
            return View(questions);
        }

        public IActionResult QuestionTake(int quizId, int questionId)
        {
            Console.WriteLine(quizId);
            var thisQuiz = _db.Quizzes.Include(quizzes => quizzes.Questions).FirstOrDefault(quizzes => quizzes.QuizId == quizId);
            var questions = thisQuiz.Questions.ToList();
            return View(questions[questionId]);
        }

        public IActionResult QuestionAnswer(string questionAnswer, int questionId)
        {
            Console.WriteLine(questionId);
            Console.WriteLine(questionAnswer);
            var user = User.GetUserId();
            var thisQuestion = _db.Questions.Include(questions => questions.Quiz).FirstOrDefault(questions => questions.QuestionId == questionId);
            var thisQuiz = _db.CompletedQuizzes.FirstOrDefault(quizzes => quizzes.UserId == user && quizzes.QuizId == thisQuestion.QuizId);
            CompletedQuestion newCompletedQuestion = new CompletedQuestion(thisQuiz.CompletedQuizId, user, thisQuestion.QuestionId, questionAnswer, thisQuestion.CorrectAnswer);
            _db.CompletedQuestions.Add(newCompletedQuestion);
            _db.SaveChanges();
            return Json(newCompletedQuestion.QuestionAnswer);
        }
    }
}
