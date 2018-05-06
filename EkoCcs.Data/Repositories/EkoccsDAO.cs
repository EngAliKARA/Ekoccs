using EkoCcs.Core.Helper;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EkoCcs.Data.Repositories
{
    public abstract class EkoccsDAO<T, V> : IEkoccsDAO<T, V> where T : new()
                                                  where V : struct
    {
        private readonly ISession CurrentNhibernateSession;
        protected EkoccsDAO()
        {
            CurrentNhibernateSession = NhibernateHelper.GetNhibarnateSessionFactory().OpenSession();
            //Ekocss.Http.MvcApplication.NhibernateSessionFactory.GetCurrentSession();
        }
        public IEnumerable<T> GetAll()
        {
            var icriteria = this.CurrentNhibernateSession.CreateCriteria(typeof(T));
            return icriteria.List<T>();
        }
        public IEnumerable<T> GetFilterList(string fieldname, V v)
        {
            var icriteria = this.CurrentNhibernateSession.CreateCriteria(typeof(T))
          .Add(Restrictions.Eq(fieldname, v)).List<T>();
            return icriteria;
        }
        public T GetObjectById(V v)
        {
            return (T)this.CurrentNhibernateSession.Load(typeof(T), v);
        }

        public T Insert(T t)
        {
            using (ITransaction transaction = this.CurrentNhibernateSession.BeginTransaction())
            {
                this.CurrentNhibernateSession.Save(t);
                transaction.Commit();
            }
            return t;
        }

        public void Update(T t)
        {
            using (ITransaction transaction = this.CurrentNhibernateSession.BeginTransaction())
            {
                this.CurrentNhibernateSession.SaveOrUpdate(t);
                transaction.Commit();
            }
        }
        public void Delete(V v)
        {
            using (ITransaction transaction = this.CurrentNhibernateSession.BeginTransaction())
            {
                var result = (T)this.CurrentNhibernateSession.Load(typeof(T), v);
                this.CurrentNhibernateSession.Delete(result);
                transaction.Commit();
            }
        }
        public T Deletea(V v)
        {
            using (ITransaction transaction = this.CurrentNhibernateSession.BeginTransaction())
            {
                var result = (T)this.CurrentNhibernateSession.Load(typeof(T), v);
                return result;
            }
        }

    }
}
