using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;

namespace EkoCcs.Core.Helper
{
    public static class NhibernateHelper
    {
        public static ISessionFactory GetNhibarnateSessionFactory()
        {
            var cfg = new Configuration();
            cfg.DataBaseIntegration(x =>
            {
                x.ConnectionStringName = "nhbConnectionstring";
                x.Driver<SqlClientDriver>();
                x.Dialect<MsSql2008Dialect>();
            });
            cfg.CurrentSessionContext<WebSessionContext>();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();
            return sefact;
        }
    }
}
