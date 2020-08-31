using Lab6.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Entities model = new Entities();

            return View(model);
        }
    }
}