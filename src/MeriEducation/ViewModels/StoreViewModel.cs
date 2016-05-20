using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeriEducation.Models;

namespace MeriEducation.ViewModels
{
    public class StoreViewModel
    {
        public ICollection<Hair> AllHair { get; set; }
        public ICollection<Outfit> AllOutfits { get; set; }
    }
}
