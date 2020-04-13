using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day15.Ajax.Controllers
{
    public class TAPDController : Controller
    {
        // GET: TAPD
        public ActionResult Show()
        {
            return View();
        }
        public ActionResult Add(Models.TAPDModel m)
        {
            return View(m);
        }
        public ActionResult Del(string id)
        {
            return View();
        }
    }
}