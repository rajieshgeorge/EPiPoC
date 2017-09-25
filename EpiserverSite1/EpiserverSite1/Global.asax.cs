using System;
using System.Globalization;
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
            CreateCulture();

        }

        public static void CreateCulture()
        {
            //* Get the base culture and region information
            CultureInfo cultureInfo = new CultureInfo("en-GB");
            RegionInfo regionInfo = new RegionInfo(cultureInfo.Name);

            //* Create the a locale for en-HK
            CultureAndRegionInfoBuilder cultureAndRegionInfoBuilder = new CultureAndRegionInfoBuilder("en-EG", CultureAndRegionModifiers.None);

            //* Load the base culture and region information
            cultureAndRegionInfoBuilder.LoadDataFromCultureInfo(cultureInfo);
            cultureAndRegionInfoBuilder.LoadDataFromRegionInfo(regionInfo);

            //* Set the culture name
            cultureAndRegionInfoBuilder.CultureEnglishName = "English (Egypt)";
            cultureAndRegionInfoBuilder.CultureNativeName = "English (Egypt)";

            //* Register with your operating system
            cultureAndRegionInfoBuilder.Register();

        }
    }
}