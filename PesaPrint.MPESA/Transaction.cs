//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PesaPrint.MPESA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public string TransactionCode { get; set; }
        public string ReceiptNumber { get; set; }
        public System.DateTime TransactionTime { get; set; }
        public double Amount { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerName { get; set; }
        public string TransactionType { get; set; }
        public string SmsMessage { get; set; }
        public string SystemBalance { get; set; }
        public int ShopId { get; set; }
    
        public virtual Shop Shop { get; set; }
    }
}
