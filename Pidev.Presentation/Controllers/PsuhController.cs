using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pidev.Presentation.Controllers
{
    public class PsuhController : Controller
    {
        // GET: Psuh
        public ActionResult Index()
        {
            int x = 9;
            x = x + 652;
            x = x + 22;
            x = x + 245;
            return View();
        }
    }
}