﻿using System;
﻿using System.Linq;
﻿using System.Web.Mvc;
﻿using Kendo.Mvc.Extensions;
﻿using Kendo.Mvc.UI;
﻿using PesaPrint.MPESA.Models;
﻿

namespace PesaPrint.MPESA.Areas.Agent.Controllers
{
    public class TransactionsController : Controller
    {
        private PesaPrintDatabaseEntities db = new PesaPrintDatabaseEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Transactions_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Transaction> transactions = db.Transactions;
            DataSourceResult result = transactions.ToDataSourceResult(request, transaction => new {
                Id = transaction.Id,
                TransactionCode = transaction.TransactionCode,
                ReceiptNumber = transaction.ReceiptNumber,
                TransactionTime = transaction.TransactionTime,
                Amount = transaction.Amount,
                CustomerPhone = transaction.CustomerPhone,
                CustomerName = transaction.CustomerName,
                TransactionType = transaction.TransactionType,
                SmsMessage = transaction.SmsMessage,
                SystemBalance = transaction.SystemBalance,
            });

            return Json(result);
        }

        [HttpPost]
        public ActionResult Excel_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }
    
        [HttpPost]
        public ActionResult Pdf_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
