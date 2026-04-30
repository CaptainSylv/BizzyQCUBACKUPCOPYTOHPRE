<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
=======
﻿using System.Web.Mvc;
>>>>>>> 873990e (login and register)

namespace BizzyQCU.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

<<<<<<< HEAD
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
=======
        public ActionResult RegisterStudent()
        {
            return View();
        }

        public ActionResult RegisterEnterprise()
        {
            return View();
        }
    }
}
>>>>>>> 873990e (login and register)
