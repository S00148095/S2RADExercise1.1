using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Exercise1a.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Exercise1a.Data
{
    public class CoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public CoreContext() : base("CoreContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}