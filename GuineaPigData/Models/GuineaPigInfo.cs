using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuineaPig.Models
{
    public class GuineaPigInfo
    {
        public string Name { get; set; }

        public DateTime dateofbirth { get; set; }

        public string selectedbreed { get; set; }

        public string color { get; set; }

        public bool isnice { get; set; }

        [Display(Name = "Guinea Pig Breeds")]
        public List<string> breeds {get; set;}

    }
}
