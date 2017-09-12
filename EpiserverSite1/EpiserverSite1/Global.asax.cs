using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace EpiserverSite1
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)

            RouteTable.Routes.MapRoute(
                "Ip",
                "ip/{action}",
                new
                {
                    controller = "Ip",
                    action = "Index"
                },
                new[] { "EpiserverSite1.Controllers" }
            );
        }
    }
}