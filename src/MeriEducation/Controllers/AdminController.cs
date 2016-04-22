using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MeriEducation.Models;
using Microsoft.Data.Entity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MeriEducation.Controllers
{
    public class AdminController : Controller
    {
        private MeriEducationContext db = new MeriEducationContext();
        public IActionResult quizes()
        {
            return View(db.Quizes.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(Quiz quiz)
        //{
        //    db.Quizes.Add(quiz);
        //    db.SaveChanges();
        //    return RedirectToAction("quizes");
        //}

        [HttpPost]
        public ActionResult Create(AddQuizViewModel model)
        {
            var quiz = new Quiz
            {
                name = model.name,
                grade = model.grade
            };

            var question = new Question
            {
                questionText = model.questionText,
                answer1 = model.answer1,
                answer2 = model.answer2,
                answer3 = model.answer3,
                answer4 = model.answer4,
                correctAnswer = model.correctAnswer
            };

            {
                db.Quizes.Add(quiz);
                question.quizId = quiz.QuizId;
                db.Questions.Add(question);
                db.SaveChanges();
                return RedirectToAction("quizes");

            }
        }
    }
}
