using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
namespace PesaPrint.MPESA.Models
{
    public class Shop : BaseEntity
    {
        [Display(Name = "Shop Name")]
        public string Name { get; set; }
        [Display(Name = "Agent Number")]
        public string AgentNumber { get; set; }
        [Display(Name = "Merchant Name")]
        public int MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public virtual Merchant Merchant {get;set;}

    }
}