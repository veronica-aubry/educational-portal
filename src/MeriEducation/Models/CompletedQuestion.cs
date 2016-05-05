using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    [Table("CompletedQuestions")]
    public class CompletedQuestion
    {
        [Key]
        public int CompletedQuestionId { get; set; }
        public int CompletedQuizId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual CompletedQuiz CompletedQuiz { get; set; }


        public CompletedQuestion(int completedquizid, int completedquestionid = 0)
        {
            CompletedQuizId = completedquizid;
            CompletedQuestionId = completedquestionid;
        }

        public CompletedQuestion() { }
    }
}