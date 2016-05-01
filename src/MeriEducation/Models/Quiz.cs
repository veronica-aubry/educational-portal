using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    [Table("Quizzes")]
    public class Quiz
    {
        [Key]
        public int QuizId { get; set; }
        public int Grade { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
