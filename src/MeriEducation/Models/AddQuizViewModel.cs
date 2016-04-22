using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    public class AddQuizViewModel
    {
        public int grade { get; set; }
        public string name { get; set; }
        public string questionText { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer4 { get; set; }
        public string correctAnswer { get; set; }
        public int quizId { get; set; }
    }
}
