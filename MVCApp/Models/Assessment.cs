using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class Assessment
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string firstname { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastname { get; set; }
        [Required]
        [Display(Name = "Hire Date")]
        public DateTime hiredate { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        
        //[Required]
        [Display(Name = "Select a Country")]
        public List<Country> countries { get; set; }
        [Required]
        [Display(Name = "I Agree")]
        public bool IAgree { get; set; }
    }

    public class Country
    {
        public string name { get; set; }
    }
}