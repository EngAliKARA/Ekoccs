using NHibernate;
using NHibernate.Context;
using System.Web.Http;

namespace Ekocss.Http
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        //public static ISessionFactory NhibernateSessionFactory;
        //public override void Init()
        //{
        //    this.BeginRequest += (sender, e) => {
        //        var session = NhibernateSessionFactory.OpenSession();
        //        CurrentSessionContext.Bind(session);
        //    };
        //    this.EndRequest += (sender, e) =>
        //    {
        //        var session = CurrentSessionContext.Unbind(NhibernateSessionFactory);
        //        session.Dispose();
        //    };
        //    base.Init();
        //}
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
