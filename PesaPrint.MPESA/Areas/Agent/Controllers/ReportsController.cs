using PesaPrint.MPESA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PesaPrint.MPESA.Areas.Agent.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Agent/Reports
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Transactions()
        {

            var db = new PesaPrintDatabaseEntities();

            return View(db.Transactions.ToList());
        }
    }
}