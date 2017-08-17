using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCApp.API
{
    [RoutePrefix("api/Assessment")]
    public class AssessmentController : ApiController
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

        [Route("GetAssessments")]
        [HttpGet]
        public HttpResponseMessage GetAssessments()
        {
            HttpResponseMessage response = Request.CreateResponse<List<Assessment>>(HttpStatusCode.OK, list,Configuration.Formatters.XmlFormatter);
            return response;
        }

        [Route("DeleteAssessment")]
        [HttpDelete]
        public HttpResponseMessage DeleteAssessment(Assessment model)
        {
            //Update DB

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("AssessmentDetail")]
        [HttpGet]
        public HttpResponseMessage AssessmentDetail()
        {
            //Update DB
            var model = new Assessment()
            {
                id = 1,
                firstname = "Scott",
                lastname = "Morgan",
                hiredate = new DateTime(2015, 3, 4),
                IAgree = true,
                email = "Scott@marlabs.com"
            };
            HttpResponseMessage response = Request.CreateResponse<Assessment>(HttpStatusCode.OK, model);
            return response;
        }




    }
}
