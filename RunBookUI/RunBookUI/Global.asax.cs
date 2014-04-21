using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
using System.Web.Http;


namespace RunBookUI
{
    public class Global : System.Web.HttpApplication
    {

        public static void RegisterRoutes(RouteCollection routes)
        {

            #region Map Pages
            routes.MapPageRoute(
                    "Projects",
                    "Projects/{Name}",
                    "~/Projects.aspx",
                    true,
                    new RouteValueDictionary
                    {
                        {
                            "Name", "All"
                        }
                    }
                    );


            routes.MapPageRoute(
                "Tasks",
                "Projects/Tasks/{Name}",
                "~/Tasks.aspx",
                true,
                new RouteValueDictionary
                    {
                        {
                            "Name", "All"
                        }
                    }
                ); 
            #endregion

            #region Map WebApi related controllers
            routes.MapHttpRoute(
                   name: "DefaultApi",
                   routeTemplate: "api/{controller}/{id}",
                   defaults: new { id = RouteParameter.Optional }
               ); 
            #endregion

        }

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
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