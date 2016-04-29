using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace System.Models
{
    [Table("Avatars")]
    public class Avatar
    {
        [Key]
        public int AvatarId { get; set; }
        public int GenderId { get; set; }
        public int SkinId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
