using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Instrumentos.Business;
using Loja.Instrumentos.Data.Entity.TypeConfiguration;

namespace Loja.Instrumentos.Data.Entity.Context
{
    public class InstrumentoDbContext : DbContext
    {

        public DbSet<Particulars> Particulars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ParticularsTypeConfiguration());
        }


    }
}
