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
        public List<Assessment> list = new List<Assessment>() {
                new Assessment()
                {
                    id=1,
                    firstname ="Scott",
                    lastname ="Morgan",
                    hiredate =new DateTime(2015,3,4),
                    IAgree =true,
                    email ="Scott@marlabs.com"
                },
            new Assessment()
            {
                id=2,
                firstname = "John",
                lastname = "Test",
                hiredate = new DateTime(2013, 1, 1),
                IAgree = true,
                email = "John@marlabs.com"
            }
            };

        // GET: Assessment
        public ActionResult Index()
        {
            return View();
        }
        [Route("list")]
        [LogActionFilter]
        public ActionResult GetAssessments()
        {
            return View(list);
        }

        [Route("Edit/{id}")]
        public ActionResult EditAssessment(int id)
        {
            var assessment = list.Where(w => w.id == id).FirstOrDefault();
            return View(assessment);
        }


        [Route("Add")]
        public ActionResult AddAssessment()
        {
            var countries = new List<Country>()
            {
                new Country() {name="USA" },
                new Country() {name="Canada" },
                new Country() {name="Mexico" },
                new Country() {name="Japan" },
                new Country() {name="Brazil" },
                new Country() {name="India" },
                new Country() {name="China" }
            };
            Assessment obj = new Assessment() { countries = countries };
            return View(obj);
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult AddAssessment(Assessment model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Message = "Saved Successfully !!";
                ViewData["abc"] = "something";
                TempData["key1"] = "test";

                var abc = TempData["key1"];
                TempData.Keep("key1");

               // var abc = TempData.Peek("key1");
            }
            else
            {
                ViewBag.Message = "Model Validation Failed..";
            }

            return View("AddAssessmentComplete");
        }
    }
}