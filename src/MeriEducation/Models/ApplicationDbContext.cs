using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace MeriEducation.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Avatar> Avatars { get; set; }
        public virtual DbSet<Quiz> Quizzes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<CompletedQuestion> CompletedQuestions { get; set; }
        public virtual DbSet<CompletedQuiz> CompletedQuizzes { get; set; }
        public virtual DbSet<VocabWordList> VocabWordLists { get; set; }
        public virtual new DbSet<ApplicationUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MeriEducation;integrated security = True");
        }
    }
}
