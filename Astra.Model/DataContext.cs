using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astra.Model
{
    public class DataContext : DbContext
    {
            public DataContext() : base("Name=AstraConn")
            {
                //Database.SetInitializer(new Initializer());
                Database.SetInitializer<DataContext>(null);
            }

            public virtual DbSet<x_Planning> x_Planning { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
