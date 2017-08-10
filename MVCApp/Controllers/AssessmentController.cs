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