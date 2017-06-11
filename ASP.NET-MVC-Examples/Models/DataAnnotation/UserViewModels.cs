using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_Examples.Models.DataAnnotation
{
    public class UserViewModel
    {
        [Display(Name = "Username:")]
        [StringLength(10)]
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Display(Name = "Password:")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [RegularExpression("([0-9]+)")]
        public int Code { get; set; }

        [RegularExpression("([01]?[0-9]|2[0-3]):[0-5][0-9]")]
        public string Time { get; set; }
    }
}