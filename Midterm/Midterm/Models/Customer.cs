using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Midterm.Models
{
    public class Customer
    {
        [Required]
        [Display(Name = "Customer Code")]
        public int Customer_Code { get; set; }

        [Required(ErrorMessage = "A First Name is Required")]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string Customer_First_Name { get; set; }

        [Required(ErrorMessage = "A Last Name is Required")]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string Customer_Last_Name { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "This is not a real email address!")]
        [StringLength(50)]
        public string Customer_Email { get; set; }
    }
}