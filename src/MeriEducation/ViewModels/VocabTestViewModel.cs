using MeriEducation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeriEducation.ViewModels
{
    public class VocabTestViewModel
    {
        public VocabWordList VocabWords { get; set; }
        public List<Dictionary<string, List<string>>> Synonyms { get; set; }
    }

}
