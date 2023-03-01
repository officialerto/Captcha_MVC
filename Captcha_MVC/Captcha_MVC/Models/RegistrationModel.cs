using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Captcha_MVC.Models
{
    public class RegistrationModel
    {
        [Display(Name="User Name")]
        public string UserName { get; set; }
        [Display(Name = "Password")]
        public string UserPassword { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }


    }
}