using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectsMVCApplication.Models
{
    public class ValidationMSGexampleModel
    {
        [Required(ErrorMessage ="Id is requred")]
        public int id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [StringLength(20, ErrorMessage ="Name cannot be longer than 20 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Age is Required")]
        [Range(18,60, ErrorMessage ="Age must be between 18 and 60")]
        public string Age { get; set; }

        [Required(ErrorMessage ="Email is requred")]
        [EmailAddress(ErrorMessage ="Invalid Email Format")]
        public string Email { get; set; }

        //[Required]
        //[Compare("Password", ErrorMessage = "Confirm Password does not match")]
        //public string ConfirmPassword { get; set; }

        //[Required]
        //public string Password { get; set; }
    }
}