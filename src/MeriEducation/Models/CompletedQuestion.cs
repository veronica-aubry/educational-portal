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
        public int QuestionId { get; set; }
        public string UserId { get; set; }
        public string QuestionAnswer { get; set; }
        public string CorrectAnswer { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Question Question { get; set; }
        public virtual CompletedQuiz CompletedQuiz { get; set; }


        public CompletedQuestion(int completedquizid, string userId, int questionId, string questionAnswer, string correctAnswer, int completedquestionid = 0)
        {
            CompletedQuizId = completedquizid;
            UserId = userId;
            QuestionId = questionId;
            QuestionAnswer = questionAnswer;
            CorrectAnswer = correctAnswer;
            CompletedQuestionId = completedquestionid;
        }

        public CompletedQuestion() { }
    }
}