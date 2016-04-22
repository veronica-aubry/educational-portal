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
    public class QuizesController : Controller
    {
        private MeriEducationContext db = new MeriEducationContext();
        public IActionResult Index()
        {
            return View(db.Quizes.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisQuiz = db.Quizes.Include(quizes => quizes.Questions).ToList().FirstOrDefault(quizes => quizes.QuizId == id);
            return View(thisQuiz);
        }

    }
}
