using System;
using System.Web.Http;
using System.Web.Routing;

namespace AngularSharp.SampleWeb
{
    public class Global : System.Web.HttpApplication
    {
        // some changes
        protected void Application_Start(object sender, EventArgs e)
        {
            //GlobalConfiguration.Configuration.Formatters.Insert(0, new JsonMediaTypeFormatter());
            RouteTable.Routes.MapHttpRoute("AngularSharpSampleApi",
                "api/{controller}/{page}",
                defaults: new
                {
                    controller = "GenericBook",
                    booktype = "repbook",
                    page = 1,
                });
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}