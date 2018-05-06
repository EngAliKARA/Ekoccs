using Microsoft.Owin.Security.OAuth;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Ekocss.Http.Auth
{
    public class Provider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            await Task.FromResult(context.Validated());
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            if (context.UserName=="alikara" && context.Password == "12345")
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim("name", context.UserName));
                identity.AddClaim(new Claim("role", "Admin"));
                AuthenticationTicket ticket = new AuthenticationTicket(identity, null);
                await Task.FromResult(context.Validated(ticket));
            }
            else
            {
                context.SetError("Yetkisiz Giriş İsteği", "Hatalı Kullanıcı Bilgileri");
            }
        }
    }
}