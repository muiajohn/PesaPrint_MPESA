using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PesaPrint.MPESA.Models
{
    public class PesaDbContext:IdentityDbContext<PesaUser>
    {
        public PesaDbContext()
            : base("PesaPrintDatabaseEntities", throwIfV1Schema: false)
        {
          
        }

        public static PesaDbContext Create()
        {
            return new PesaDbContext();
        }

        static PesaDbContext()
        {

            Database.SetInitializer<PesaDbContext>(new DbInitializer());
        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Account> Accounts { get; set; } 

    }
}