using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace WcfSoapService
{
    public class ServiceAuthenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != "lex" || password != "123456")
                throw new SecurityTokenValidationException("Invalid credentials");
        }
    }
}