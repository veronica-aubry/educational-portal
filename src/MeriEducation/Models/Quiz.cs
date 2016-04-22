using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    [Table("Quizes")]
    public class Quiz
    {
        [Key]
        public int QuizId { get; set; }
        public int grade { get; set; }
        public string name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
