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
        public string UserId { get; set; }
        public bool InProgress { get; set; }
        public int? Score { get; set;}
        public virtual ApplicationUser User { get; set; }
        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<CompletedQuestion> CompletedQuestions { get; set; }

        public static int ScoreQuiz(CompletedQuiz quiz) {
            var score = 0;
            foreach(var question in quiz.CompletedQuestions)
            {
                if (question.QuestionAnswer == question.CorrectAnswer)
                {
                    Console.WriteLine(question.CorrectAnswer);
                    score = score + 1;
                }
            }
            Console.WriteLine(quiz.CompletedQuestions.Count());
            Console.WriteLine(score);
            var finalScore = (score / (quiz.CompletedQuestions.Count())) * 100;
            return finalScore;
        }

        public CompletedQuiz(int quizid, string userId, int completedquizid = 0, bool inprogress = true)
        {
            QuizId = quizid;
            UserId = userId;
            CompletedQuizId = completedquizid;
            InProgress = inprogress;
        }

        public CompletedQuiz() { }
    }
}

