﻿using AspNetWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AspNetWeb.DataAccess
{
    public class AssessmentData
    {
        private string connString = Convert.ToString(ConfigurationManager.AppSettings["ConnectionString"]);
        public void SaveAssessment(Assessment inputModel)
        {
            //Save to DB
            using (var con = new SqlConnection(connString))
            {
                con.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SaveAssessment";
                    cmd.CommandTimeout = 1000;
                    cmd.Parameters.Add(new SqlParameter("@firstname", inputModel.firstname));
                    cmd.Parameters.Add(new SqlParameter("@lastname", inputModel.lastname));
                    cmd.Parameters.Add(new SqlParameter("@hiredate", inputModel.hiredate));
                    cmd.Parameters.Add(new SqlParameter("@email", inputModel.email));
                    cmd.Parameters.Add(new SqlParameter("@country", inputModel.country));
                    cmd.Parameters.Add(new SqlParameter("@gender", inputModel.gender));
                    cmd.Parameters.Add(new SqlParameter("@tech", inputModel.technologies));
                    cmd.Parameters.Add(new SqlParameter("@qual", inputModel.qualification));
                    var count = cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}