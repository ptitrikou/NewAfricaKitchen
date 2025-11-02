using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewAfrica.Models;

namespace NewAfrica.Controllers
{
    public class HomeController : Controller
    {
        AdminWebModel db = new AdminWebModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            List<SOUSFAMILL> listcateg = db.SOUSFAMILL.OrderBy(sf => sf.ordresf).ToList();
            ViewBag.listcateg = listcateg;
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
    }
}