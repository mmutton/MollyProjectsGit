using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVC1.Models;

namespace HelloMVC1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var cars = HelloModel.GetCars();

            ViewBag.MollyCreatedThisValue = "Hello MVC";

            return View(cars);
        }
    }
}