using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Midterm.Models
{
    public class Media_Type
    {
        [Required]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "The code must be at least 1 and at most 3")]
        [Display(Name = "Media Code")]
        public string Media_Code { get; set; }

        [Required(ErrorMessage = "A Media Description is required!")]
        [StringLength(20)]
        [Display(Name = "Media Description")]
        public string Media_Desc { get; set; }
    }
}