using Loja.Instrumentos.Business;
using Loja.Instrumentos.Data.Entity.Context;
using Loja.Instrumentos.Repository.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Instrumentos.Repository.Entity
{
   public class ParticularsRepository : GenericRepositoryEntity<Particulars, int>
    {
        public ParticularsRepository(InstrumentoDbContext context)
            : base(context)
        {


        }

    }
}
