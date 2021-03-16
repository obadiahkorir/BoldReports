using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDemoMVC.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        [Display(Name = "User ID")]
        public string MiddleName { get; set; }
        [Display(Name = "Middle Name")]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [Display(Name = "First Name")]
        public string Gender { get; set; }
        [Display(Name = "Gender")]
        public string County { get; set; }
        [Display(Name = "County")]
        public string PostCode { get; set; }
        [Display(Name = "PostCode")]
        public string City { get; set; }
        public string EmailAddress { get; set; }
        [Display(Name = "Email Address")]
        public string Password { get; set; }
    }
}
