using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Day_4.Models
{
    public class Department
    {

        public int Id { set; get; }
        [Required, StringLength(20, MinimumLength = 2)]
        public string Name { set; get; }
        [Range(5,20)]
        public int NumOfIns { set; get; }
        [Range(25, 250)]
        public int NumOfStds { set; get; }

    }
}