﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationApp.Models;

namespace ValidationApp.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult CheckName(string name)
        {
            var result = !(name == "Название");
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            


            //if (book.Year == 1980)
            //{
            //    ModelState.AddModelError("Year", "Некорректный код");
            //}
            //if (book.Name.Length > 5)
            //{
            //    ModelState.AddModelError("Name", "Недопустимая длина строки");
            //}

            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}