using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleWebApp.Models
{
    public class LogOnModel
    {        
        [Required]        
        [Display(Name = "Email address")]
        public string UserName { get; set; }
                
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}