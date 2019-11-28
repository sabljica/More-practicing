using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name ="Employee ID")]
        [Range(1000000, 9999999,ErrorMessage ="Invalid entrance")]
        public int EmployeeId { get; set; }



        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Feild is required")]
        public string FirstName { get; set; }



        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Feild is required")]
        public string LastName { get; set; }



        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Feild is required")]
        public string EmailAddress { get; set; }
 


        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress",ErrorMessage ="The email and confirm email got to match")]
        public string ConfirmEmail { get; set; }



        [Required(ErrorMessage ="You must enter a password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength =10, ErrorMessage ="Password must be between 10 and 100 characters")]
        public string Password { get; set; }




        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password doesn't match")]
        public string ConfirmPassword { get; set; }
    }
}