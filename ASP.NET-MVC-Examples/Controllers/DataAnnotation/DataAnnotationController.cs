using ASP.NET_MVC_Examples.Models.DataAnnotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Examples.Controllers.DataAnnotation
{
    public class DataAnnotationController : Controller
    {
        //
        // GET: /DataAnnotation/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(UserViewModel model)
        {
            return View();
        }

    }
}
