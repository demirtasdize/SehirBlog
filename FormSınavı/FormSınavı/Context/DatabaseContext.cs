using FormSınavı.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSınavı.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Mekan> Mekanlar{ get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
    }
}
