using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string userName { get; set; }
        public string name { get; set; }
        public int grade { get; set; }
        public int avatarId { get; set; }
        public int points { get; set; }
    }
}
