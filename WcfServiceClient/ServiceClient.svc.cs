using System;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace WcfServiceClient
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class ServiceClient : IServiceClient
    {
        [WebGet(ResponseFormat = WebMessageFormat.Json)] 
        public string AskNumber()
        {
            var soapService = new SoapServiceReference.SoapServiceClient();
//            if (soapService.ClientCredentials != null)
//            {
//                soapService.ClientCredentials.UserName.UserName = "lex";
//                soapService.ClientCredentials.UserName.Password = "123456";
//            }

            int res;
            try
            {
                res = soapService.GeNumber();
            }
            catch (InvalidOperationException e)
            {
                return e.Message;
            }

            return "Hello times x" + res;
        }
    }
}
