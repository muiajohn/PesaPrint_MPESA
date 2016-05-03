﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Web;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public partial class PesaPrintDatabaseEntities : IdentityDbContext<PesaUser>
    {
        public PesaPrintDatabaseEntities()
            : base("name=PesaPrintDatabaseEntities", throwIfV1Schema: false)
        {
        }

        public static PesaPrintDatabaseEntities Create()
        {
            return new PesaPrintDatabaseEntities();
        }
        static PesaPrintDatabaseEntities()
        {

            Database.SetInitializer<PesaPrintDatabaseEntities>(new DbInitializer());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Merchant> Merchants { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    }
}
