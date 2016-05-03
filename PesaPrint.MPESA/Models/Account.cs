using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesaPrint.MPESA.Models
{
    public class Account:BaseEntity
    {
        public string UserId { get; set; }
        public long LinkedId { get; set; }
        
    }
}