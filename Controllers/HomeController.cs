using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult ProductGallery()
        {
            ViewBag.Message = "Your product gallery.";
            return View();
        }

        public ActionResult ProductDetails()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Sth()
        {
            ViewBag.Message = "Do something. ";
            return View();
        }
    }
}