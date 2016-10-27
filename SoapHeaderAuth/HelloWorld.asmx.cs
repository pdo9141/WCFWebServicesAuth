using System;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace SoapHeaderAuth
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HelloWorld : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;

        public class AuthSoapHd : SoapHeader
        {
            public string UserName;
            public string Password;
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public string AuthTest()
        {
            if (spAuthenticationHeader.UserName.Equals("TestUser") && spAuthenticationHeader.Password.Equals("TestPassword"))
            {
                return String.Format("UserName: {0}, Password: {1}", spAuthenticationHeader.UserName, spAuthenticationHeader.Password);
            }
            else
            {
                return "Access Denied";
            }
        }
    }
}
