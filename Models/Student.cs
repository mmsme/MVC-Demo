using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Day_4.Models
{
    public class Student
    {
            public int Id { set; get; }
            [Required, StringLength(25, MinimumLength = 3), RegularExpression("^[a-zA-Z ]*$")]
            public string Name { set; get; }
            [Range(18,30)]
            public int Age { set; get; }
            [Required , RegularExpression(@"[a-zA-Z0-9_]*@[A-Za-z]+.[a-zA-Z]{2,4}")]
            public string Email { set; get; }
            [Required, StringLength(30, MinimumLength = 6)]
            public string Password { set; get; }
            [Required, Compare("Password")]
            public string CPassword { set; get; }
            public string Img { set; get; }
    }
}