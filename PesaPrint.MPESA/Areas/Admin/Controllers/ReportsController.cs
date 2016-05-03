using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PesaPrint.MPESA.Areas.Admin.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Admin/Reports
        public ActionResult Index()
        {
            return View();
        }
    }
}