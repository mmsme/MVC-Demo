using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Day_4.Models
{
    public class LoginViewModel
    {
        [Required, RegularExpression(@"[a-zA-Z0-9_]*@[A-Za-z]+.[a-zA-Z]{2,4}")]
        public string Email { set; get; }
        [Required, StringLength(30, MinimumLength = 6)]
        public string Password { set; get; }
    }
}