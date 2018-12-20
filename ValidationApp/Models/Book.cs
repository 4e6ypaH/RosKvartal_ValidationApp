using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationApp.Annotations;

namespace ValidationApp.Models
{
    public class Book
    {       
            public int Id { get; set; }
            [Display(Name = "Название")]           
            public string Name { get; set; }
            [Display(Name = "Автор")]
            public string Author { get; set; }
            [Display(Name = "Год")]
            public int Year { get; set; }
            }

    public class LoginModel {
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage ="Некорректный адрес")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }

    }
}