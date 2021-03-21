using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MVC_Day_4.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult AboutList()
        {
            return View();
        }

        public ActionResult getData()
        {

            return File("~/res/employee.json", "application / json");
        }
    }
}