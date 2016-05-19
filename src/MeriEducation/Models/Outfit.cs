using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    [Table("Outfits")]
    public class Outfit
    {
        [Key]
        public int OutfitId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}