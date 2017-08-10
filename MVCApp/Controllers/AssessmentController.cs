using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    [RoutePrefix("Assessment")]
    public class AssessmentController : Controller
    {
        // GET: Assessment
        public ActionResult Index()
        {
            return View();
        }
        [Route("list")]
        public ActionResult GetAssessments()
        {
            var list = new List<Assessment>() {
                new Assessment()
                {
                    firstname ="Scott",
                    lastname ="Morgan",
                    hiredate =new DateTime(2015,3,4),
                    IAgree =true,
                    email ="Scott@marlabs.com"
                },
            new Assessment()
            {
                firstname = "John",
                lastname = "Test",
                hiredate = new DateTime(2013, 1, 1),
                IAgree = true,
                email = "John@marlabs.com"
            }
            };
            return View(list);
        }


        [Route("Add")]
        public ActionResult AddAssessment()
        {

            return View();
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult AddAssessment(Assessment model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Message = "Saved Successfully !!";
            }
            else
            {
                ViewBag.Message = "Model Validation Failed..";
            }

            return View("AddAssessmentComplete");
        }
    }
}