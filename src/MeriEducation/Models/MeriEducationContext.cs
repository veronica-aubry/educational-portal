using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace MeriEducation.Models
{
    public class MeriEducationContext: DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Avatar> Avatars { get; set; }
        public virtual DbSet<Quiz> Quizes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MeriEducation;integrated security = True");
        }
    }
}
