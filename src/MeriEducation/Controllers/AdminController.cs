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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult quizes()
        {
            return View(db.Quizes.ToList());
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

        public IActionResult Details(int id)
        {
            var thisQuiz = db.Quizes.Include(quizes => quizes.Questions).ToList().FirstOrDefault(quizes => quizes.QuizId == id);
            return View(thisQuiz);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            var thisquiz = db.Quizes.FirstOrDefault(x => x.QuizId == id);
            db.Quizes.Remove(thisquiz);
            db.SaveChanges();
            return RedirectToAction("quizes");
        }

        public ActionResult Edit(int id)
        {
            var thisquiz = db.Quizes.FirstOrDefault(quizes => quizes.QuizId == id);
            return View(thisquiz);
        }
        [HttpPost]
        public ActionResult Edit(Quiz quiz)
        {
            db.Entry(quiz).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("quizes");
        }

        public ActionResult EditQuestion(int id)
        {
            var thisquestion = db.Questions.FirstOrDefault(questions => questions.QuestionId == id);
            return View(thisquestion);
        }
        [HttpPost]
        public ActionResult EditQuestion(Question question)
        {
            db.Entry(question).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("quizes");
        }
    }
}
