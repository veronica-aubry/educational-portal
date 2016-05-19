using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeriEducation.Models;


namespace MeriEducation.ViewModels
{
    public class ProfileViewModel
    {
        public ApplicationUser User { get; set; }
        public Avatar UserAvatar { get; set; }
        public ICollection<CompletedQuiz> CompletedQuizzes { get; set; } 
    }
}
