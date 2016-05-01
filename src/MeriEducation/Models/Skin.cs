using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    [Table("Skins")]
    public class Skin
    {
        [Key]
        public int SkinId { get; set; }
        public string Name { get; set; }
    }
}