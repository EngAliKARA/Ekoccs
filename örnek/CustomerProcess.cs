using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Linq;
using System.Reflection;

namespace EkoCcs.Core
{
    public class CustomerProcess<T> : ICustomerProcess<T> where T : class
    {
        private ISession Session;
        public static ISessionFactory GetSession()
        {
            var cfg = new Configuration();
            cfg.DataBaseIntegration(x =>
            {
                x.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["NhDb"].ConnectionString;
                x.Driver<SqlClientDriver>();
                x.Dialect<MsSql2008Dialect>();
            });
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();
            return sefact;
        }
        public CustomerProcess()
        {
            Session = GetSession().OpenSession();
        }
        public void CustumSave(T customer)
        {
            using (var mySession = GetSession().OpenSession())
            {
                using (var tx = mySession.BeginTransaction())
                {
                    mySession.Save(customer);
                    tx.Commit();
                }
            }
        }
        public IQueryable<T> GetAll()
        {
            return Session.Query<T>();
        }

        public T GetById(int id)
        {
            return Session.Get<T>(id);
        }

        public void Create(T entity)
        {
            GetSession().OpenSession.Save(entity);
        }

        public void Update(T entity)
        {
            Session.Update(entity);
        }

        public void Delete(int id)
        {
            Session.Delete(Session.Load<T>(id));
        }
    }

    public interface ICustomerProcess<T> where T : class
    {
        //void CustumSave(T )
        
    }
}
