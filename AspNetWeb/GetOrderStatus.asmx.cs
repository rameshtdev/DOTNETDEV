using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AspNetWeb
{
    /// <summary>
    /// Summary description for GetOrderStatus
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GetOrderStatus : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public OrderStatus GetStatus(int OrderId)
        {
            //Some DB call
            var status = new OrderStatus() { orderId = 123, CurrentStatus = "In Progress" };
            return status;
        }
    }
    public class OrderStatus
    {
        public int orderId { get; set; }
        public string CurrentStatus { get; set; }
    }
}
