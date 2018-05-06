using Owin;

namespace Ekocss.Http.Auth
{
    public interface IStartup
    {
        void Configuration(IAppBuilder app);
    }
}