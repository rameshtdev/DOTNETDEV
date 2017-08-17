using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*
             * wsdl /language:c# /out:c:\OrderStatus.cs http://localhost:49303/GetOrderStatus.asmx?WSDL
             */
            GetOrderStatus order = new GetOrderStatus();
            var obj = order.GetStatus(4);
            Response.Write(obj.CurrentStatus);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}