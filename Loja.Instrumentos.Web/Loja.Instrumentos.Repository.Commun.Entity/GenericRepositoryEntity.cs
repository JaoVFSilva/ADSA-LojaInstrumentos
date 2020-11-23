using Loja.Instrumentos.RepositoryCommon;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Instrumentos.Repository.Common.Entity
{
    public class GenericRepositoryEntity<TEntity, TKey> : IGenericRepository<TEntity, TKey>
        where TEntity : class
    {
        private DbContext _context;

        public GenericRepositoryEntity(DbContext context)
        {
            _context = context;
        }

        public void Alter(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Exclude(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void ExcludeForId(TKey id)
        {
            TEntity entity = SelectForId(id);
            Exclude(entity);
        }

        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public List<TEntity> Select()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity SelectForId(TKey id)
        {
            return _context.Set<TEntity>().Find(id);
        }
    }
}
