using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Midterm.Models
{
    public class Movie_Info
    {
        [Required(ErrorMessage = "A First Name is Required")]
        [StringLength(5)]
        [Display(Name = "Movie Code")]
        public string Movie_Code { get; set; }

        [Required(ErrorMessage = "A First Name is Required")]
        [StringLength(40)]
        [Display(Name = "Movie Title")]
        public string Movie_Title { get; set; }

        [Required(ErrorMessage = "A First Name is Required")]
        [StringLength(3)]
        [Display(Name = "Movie Genre")]
        public string Genre_Code { get; set; }

        [Required(ErrorMessage = "A First Name is Required")]
        [StringLength(3)]
        [Display(Name = "Movie Media Type")]
        public string Media_Code { get; set; }
    }
}