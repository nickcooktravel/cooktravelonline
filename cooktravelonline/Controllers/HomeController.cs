using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cooktravelonline.Controllers
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

        //published air
        public ActionResult Air()
        {
            return View();
        }

        //hotel
        public ActionResult Hotel()
        {
            return View();
        }

        //Cook Travel Business
        public ActionResult CTB()
        {
            return View();
        }

        //Cook Travel Corporate

        //Cook Travel Luxury

        //Cook Travel Cruises
    }
}