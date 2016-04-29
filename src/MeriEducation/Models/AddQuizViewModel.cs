using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System.Models
{
    public class AddQuizViewModel
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string QuestionText { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string CorrectAnswer { get; set; }
        public int QuizId { get; set; }
    }
}
