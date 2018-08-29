using System.Web.Http;

namespace RTLSWebService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static string notificationString = "";
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);



        }
    }
}
