using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Midterm.Models
{
    public class Genre
    {
        [Required]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "The code must be less than 3!")]
        [Display(Name = "Genre Code")]
        public string Genre_Code { get; set; }

        [Required(ErrorMessage = "A Genre Description is required!")]
        [StringLength(20)]
        [Display(Name = "Genre Description")]
        public string Genre_Desc { get; set; }

    }
}