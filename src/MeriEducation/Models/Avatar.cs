using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    [Table("Avatars")]
    public class Avatar
    {
        [Key]
        public int AvatarId { get; set; }
        public int genderId { get; set; }
        public int skinId { get; set; }
        public virtual User User { get; set; }
    }
}
