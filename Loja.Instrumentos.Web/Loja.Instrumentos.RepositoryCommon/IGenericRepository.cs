using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Instrumentos.RepositoryCommon
{
    public interface IGenericRepository<TEntity, TKey>
        where TEntity : class
    {
        List<TEntity> Select();
        TEntity SelectForId(TKey id);

        void Insert(TEntity entity);

        void Alter(TEntity entity);

        void Exclude(TEntity entity);

        void ExcludeForId(TKey id);
    }
}
