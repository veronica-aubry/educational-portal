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
        public int SkinId { get; set; }
        public int HairId { get; set; }
        public int OutfitId { get; set; }
        public virtual Skin Skin { get; set; }
        public virtual Hair Hair {get; set; }
        public virtual Outfit Outfit { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
