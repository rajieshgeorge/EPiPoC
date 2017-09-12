using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    public class IPController : Controller
    {
        // GET: IP
        public ActionResult Index()
        {
   
                    var str = "";
                    foreach (System.Net.IPAddress address in System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList)
                    {
                        str += address.ToString() + "-" + System.Net.IPAddress.IsLoopback(address).ToString() + "</br>";
                    }
                    str += "</br> </br> and Mac  </br> </br>";

                    foreach (var net in NetworkInterface.GetAllNetworkInterfaces().Where(nic => nic.OperationalStatus == OperationalStatus.Up).Select(nic => nic.GetPhysicalAddress().ToString()))
                    {
                        str += net + "</br>";
                    }
                    return new ContentResult() { Content = str };
                    }
                    
                    

    }
}