using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MeriEducation.Models;
using MeriEducation.ViewModels;
using System.Text.RegularExpressions;
using Microsoft.AspNet.Identity;

namespace MeriEducation.Controllers
{
    public class VocabController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public VocabController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
   
        public IActionResult Index()
        {
            return View(_db.VocabWordLists.ToList());
        }

        public IActionResult GetMatches(VocabWordList wordList)
        {
            var result = VocabMatch.GetMatchList(wordList);
            var  model = new VocabTestViewModel
            {
                VocabWords = wordList,
                Synonyms = result
            };
            return View(model);

        }
    }
}
