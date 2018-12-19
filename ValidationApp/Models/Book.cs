﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ValidationApp.Models
{
    public class Book
    {       
            public int Id { get; set; }
            [Display(Name = "Название")]
            [Required(ErrorMessage = "Поле должно быть установлено")]
            [StringLength(10, MinimumLength =3, ErrorMessage = "Недопустимая длина строки")]
            [Remote("CheckName", "Home", ErrorMessage= "Некорректное название")]
            public string Name { get; set; }
            [Display(Name = "Автор")]
            [Required]  
            public string Author { get; set; }
            [Display(Name = "Год")]
            [Required]
            [Range(1800, 2000, ErrorMessage = "Недопустимый год!")]
            public int Year { get; set; }
            }

    public class LoginModel {
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage ="Некорректный адрес")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }

    }
}