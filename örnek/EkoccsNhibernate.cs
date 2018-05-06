using EkoCcs.Core.Models;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;


namespace EkoCcs.Core.Entities
{
    public class EkoccsNhibernate //:IEkoccsNhibernate
    {
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
    }

    //public internal interface IEkoccsNhibernate
    //{
    //    void CustumSave(Customer customer);
    //}
}
