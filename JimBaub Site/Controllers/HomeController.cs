using JimBaub_Site.Models;
using JimBaub_Site.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JimBaub_Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreData db;

        public HomeController(IStoreData db)
        {
            this.db = db;
        }
        
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
        public ActionResult Store()
        {
            ViewBag.Message = "Don't Delay, Buy Today!";
            var model = db.GetAllItems();
            return View(model);
        }
    }
}