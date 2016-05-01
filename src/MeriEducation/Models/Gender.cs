using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.Models
{
    [Table("Genders")]
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        public string Name { get; set; }
    }
}