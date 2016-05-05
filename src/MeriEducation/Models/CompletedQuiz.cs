using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    [Table("CompletedQuizzes")]
    public class CompletedQuiz
    {
        [Key]
        public int CompletedQuizId { get; set; }
        public int QuizId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<CompletedQuestion> CompletedQuestions { get; set; }


        public CompletedQuiz(int quizid, int completedquizid = 0)
        {
            QuizId = quizid;
            CompletedQuizId = completedquizid;
        }

        public CompletedQuiz() { }
    }
}

