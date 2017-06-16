using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Service2Reference.Service2Client svc2Obj = new Service2Reference.Service2Client();
            int value =  svc2Obj.DoWork();
            ViewData["val"] = value;
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