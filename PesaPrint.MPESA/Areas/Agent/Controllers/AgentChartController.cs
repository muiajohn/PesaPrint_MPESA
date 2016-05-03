using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PesaPrint.MPESA;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;


namespace PesaPrint.MPESA.Areas.Agent.Controllers
{
    public class AgentChartController : Controller
    {
        // GET: Agent/AgentChart
      // private PesaDbContext db = new PesaDbContext();
        public ActionResult Column()
        {
            return View();
        }
       public JsonResult GetTransactionData()
       {
           
         List<Transaction> sd = new List<Transaction>();
            using (PesaPrintDatabaseEntities dc = new PesaPrintDatabaseEntities())
            {
                sd = dc.Transactions.OrderBy(a => a.Amount).ToList();

            }
            var chartData = new object[sd.Count + 1];

            chartData[0] = new object[]
            {
                "Amount","ShopId","TransactionCode","ReceiptNumber",
                "TransactionTime","CustomerPhone","CustomerName","TransactionType","SmsMessage",
                "SystemBalance"

            };
           
            int j = 0;
            foreach (var i in sd)
            {
                j++;
                chartData[j] = new object[]{
                i.TransactionCode,i.Amount,i.ShopId,i.ReceiptNumber,i.TransactionTime,i.CustomerPhone,i.TransactionType,i.CustomerName,i.SmsMessage,i.SystemBalance};
            }
            

            return new JsonResult { Data = chartData, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
           
        }


        public JsonResult GetShopsData()
        {

            List<Shop> dd = new List<Shop>();
            using (PesaPrintDatabaseEntities dq = new PesaPrintDatabaseEntities())
            { 
                dd = dq.Shops.OrderBy(b => b.Name).ToList();
               
            }
            var chrData = new object[dd.Count + 1];

            chrData[0] = new object[]
            {
                "Name","AgentNumber","MerchantId"
            };

  
            int k = 0;
        foreach (var l in dd)
            {
                k++;
                chrData[k] = new object[]{
                l.Name,l.AgentNumber,l.MerchantId};
            }

            return new JsonResult { Data = chrData, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}