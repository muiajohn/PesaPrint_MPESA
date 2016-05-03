using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesaPrint.MPESA.Models
{
    public class Merchant:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<Shop> Shops { get; set; }
    }
}