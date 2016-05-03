using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PesaPrint.MPESA.Areas.Admin.Controllers
{
    public class AdminChartController : Controller
    {
        // GET: Admin/AdminChart
       public ActionResult Column()
        {
            return View(); 
        }
    }
}