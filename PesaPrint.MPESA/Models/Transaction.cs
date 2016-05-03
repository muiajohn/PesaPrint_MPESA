using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PesaPrint.MPESA.Models
{
    public class Transaction:BaseEntity
    {

        [Display(Name ="Transaction Code")]
        public string TransactionCode { get; set; }
        [Display(Name = "Receipt Number")]
        public string ReceiptNumber { get; set; }
        [Display(Name = "Transaction Time")]
        public DateTime TransactionTime { get; set; }
        [Display(Name = "Amount")]
        public double Amount { get; set; }
        [Display(Name = "Customer Phone")]
        public string CustomerPhone { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Transaction Type")]
        public string TransactionType { get; set; }
        [Display(Name = "SMS Message")]
        public string SmsMessage { get; set; }
        [Display(Name = "System Balance")]
        public string SystemBalance { get; set; }
        [Display(Name = "Shop ID")]
        public int ShopId { get; set; }
        [ForeignKey("ShopId")]
        public virtual Shop Shop { get; set; }

    }
}