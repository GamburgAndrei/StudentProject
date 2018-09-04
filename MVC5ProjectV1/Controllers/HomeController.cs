using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5ProjectV1.Models;
using System.Data.Entity;
using MVC5ProjectV1.Util;

namespace MVC5ProjectV1.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            ViewBag.Message = "Это вызов частичного представления из обычного";
            return View(db.Books);
        }
        public ActionResult Partial()
        {
            ViewBag.Message = "Это частичное представление";
            return PartialView();
        }
        [HttpGet]
        public ActionResult Buy(int ID)
        {
            ViewBag.BookID = ID;
            return View();
        }
        public string Square(int a,int h)
        {
            double s = a * h / 2;
            return " Площадь треугольника с основанием:" + a + "И высотой:" + h + "Равна:" + s;
        }
        public ActionResult GetHTML()
        {
            return new HTMLResult("<h2>Hello World</h2>");
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо." + purchase.Person + "за покупку";
        }
    }
    
}