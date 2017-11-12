using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LtopDesctopAPI.Controllers
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


        public ActionResult productTP()
        {
            ViewBag.Message = "product";

            return View();
        }

        public ActionResult productsLP()
        {
            ViewBag.Message = "product1";

            return View();
        }

        public ActionResult productsIP()
        {
            ViewBag.Message = "productTelephone";

            return View();
        }


    }
}