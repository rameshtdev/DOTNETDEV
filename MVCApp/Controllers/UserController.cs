using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    [RoutePrefix("Employee/a")]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User
        [Route("Begin/HelloWorld/{id}/{id1}")]
        [Route("Hello/{id=0}/{id1=0}")]
        public ActionResult HelloWorld(int id,int id1)
        {
            
            return View();
        }

        
    }
}