using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LtopDesctopAPI.Controllers
{
    public class MyOfficeController : Controller
    {
        // GET: MyOffice
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult MyAnnouncements()
        {
            return View();
        }

        public ActionResult Settings()
        {
            return View();
        }

        public ActionResult PaymentForServices()
        {
            return View();
        }

    }
}