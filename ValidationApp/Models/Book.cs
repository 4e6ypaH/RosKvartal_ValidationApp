using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ValidationApp.Models
{
    public class Book
    {       
            public int Id { get; set; }
            [Display(Name = "Название")]
            [Required]
            public string Name { get; set; }
            [Display(Name = "Автор")]
            [Required]  
            public string Author { get; set; }
            [Display(Name = "Год")]
            [Required]
            public int Year { get; set; }
            }   
}