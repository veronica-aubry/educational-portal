using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string CorrectAnswer { get; set; }
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<CompletedQuestion> CompletedQuestions { get; set; }


        public Question(string questionText, string answer1, string answer2, string answer3, string answer4, string correctAnswer, int quizId, int questionId = 0)
        {
            QuestionText = questionText;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
            CorrectAnswer = correctAnswer;
            QuizId = quizId;
        }

        public Question() { }
    }
}

