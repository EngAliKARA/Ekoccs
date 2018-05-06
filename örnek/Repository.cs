using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EkoCcs.Core.Entities
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region IReadRepository
        IQueryable<TEntity> All();
        TEntity FindBy(Expression<Func<TEntity, bool>> expression);
        TEntity FindBy(object id);
        IQueryable<TEntity> FilterBy(Expression<Func<TEntity, bool>> expression);
        #endregion
        #region IWriteRepository
        bool Add(TEntity entity);
        bool Add(IEnumerable<TEntity> entities);
        bool Update(TEntity entity);
        bool Update(IEnumerable<TEntity> entities);
        bool Delete(TEntity entity);
        bool Delete(IEnumerable<TEntity> entities);
        #endregion
    }
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ISession _session;

        public Repository(ISession session)
        {
            _session = session;
        }

        #region IWriteRepository
        public bool Add(TEntity entity)
        {
            _session.Save(entity);
            return true;
        }
        public bool Add(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                _session.Save(entity);
            }
            return true;
        }
        public bool Update(TEntity entity)
        {
            _session.Update(entity);
            return true;
        }
        public bool Update(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                _session.Update(entity);
            }
            return true;
        }
        public bool Delete(TEntity entity)
        {
            _session.Delete(entity);
            return true;
        }
        public bool Delete(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                _session.Delete(entity);
            }
            return true;
        }
        #endregion

        #region IReadRepository
        public IQueryable<TEntity> All()
        {
            return _session.Query<TEntity>();
        }
        public TEntity FindBy(Expression<System.Func<TEntity, bool>> expression)
        {
            return FilterBy(expression).SingleOrDefault();
        }
        public TEntity FindBy(object id)
        {
            return _session.Get<TEntity>(id);
        }
        public IQueryable<TEntity> FilterBy(Expression<System.Func<TEntity, bool>> expression)
        {
            return All().Where(expression).AsQueryable();
        }
        #endregion
    }
}
