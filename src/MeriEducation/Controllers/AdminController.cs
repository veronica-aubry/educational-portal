﻿using System;
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
            _db.Quizzes.Add(quiz);
            _db.SaveChanges();
            return RedirectToAction("AddQuestion", new { id = quiz.QuizId });

            }

        public ActionResult AddQuestion(int id)
        {
            var thisQuiz = _db.Quizzes.Include(quizes => quizes.Questions).ToList().FirstOrDefault(quizes => quizes.QuizId == id);
            return View(thisQuiz);
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

        [HttpPost]
        public IActionResult NewQuiz(string newName, int newGrade)
        {
            Quiz newQuiz = new Quiz(newName, newGrade);
            _db.Quizzes.Add(newQuiz);
            _db.SaveChanges();
            return Json(newQuiz);
        }


        [HttpPost]
        public IActionResult NewQuestion(string newQuestionText, string newAnswer1, string newAnswer2, string newAnswer3, string newAnswer4, string newCorrectAnswer, int QuizId)
        {
            Question newQuestion = new Question(newQuestionText, newAnswer1, newAnswer2, newAnswer3, newAnswer4, newCorrectAnswer, QuizId);     
            _db.Questions.Add(newQuestion);
            _db.SaveChanges();
            return Json(newQuestion);
        }

        [HttpPost]
        public IActionResult QuizEdit(string editName, int editGrade, int quizId)
        {
            var thisQuiz = _db.Quizzes.FirstOrDefault(quizzes => quizzes.QuizId == quizId);
            Console.WriteLine(thisQuiz.QuizId);
            thisQuiz.Name = editName;
            thisQuiz.Grade = editGrade;
            _db.Entry(thisQuiz).State = EntityState.Modified;
            _db.SaveChanges();
            return Json(thisQuiz);
        }
    }
}
