using Pidev.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pidev.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Chat()
        {

            User userc = Session["userConnected"] as User;

            return View();
        }
        
    }
}