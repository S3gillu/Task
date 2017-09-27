using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Models;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        UserContext context ;

        public HomeController()
        {
            context = new UserContext();
        }
        public ActionResult Index()
        {
            return View(context.Users.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(User custom)
        {

            context.Users.Add(custom);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User Custom)
        {   
            return View();
        }


        


    }
}