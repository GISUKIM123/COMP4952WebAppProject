using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechproMiniMart.Models;

namespace TechproMiniMart.Controllers
{
    public class HomeController : Controller
    {
        private UserModel userModel = new UserModel();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.users = userModel.findAll();
            return View();
        }
    }
}