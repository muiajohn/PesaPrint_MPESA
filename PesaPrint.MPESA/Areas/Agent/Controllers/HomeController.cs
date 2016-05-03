using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PesaPrint.MPESA.Areas.Agent.Controllers
{
    public class HomeController : Controller
    {
        // GET: Agent/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}