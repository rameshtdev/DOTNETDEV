using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ModelFirstContainer())
            {
                var student = context.Students.Where(w => w.Name == "Mark").FirstOrDefault();
                var courseList = context.Courses.Where(w=>w.Name!="Mech").ToList();

                //Query Syntax
                var studentsEnrolled = (from s in context.Students join e in context.Enrollments on s.StudentId equals e.StudentStudentId select s.Name).Distinct().ToList();
                //Method syntax
                var studentsEnrolled1 = context.Students.Join(context.Enrollments, s => s.StudentId, e => e.StudentStudentId, (s, e) => new { s.Name }).Distinct().ToList();

                //Left Join
                /*
                    Select S.Name, COUNT(E.EnrollmentId) from Students S
                    LEFT JOIN Enrollments E ON S.StudentId=E.StudentStudentId
                    GROUP BY S.Name
                 */
                var LeftJoin = (from s in context.Students
                                join e in context.Enrollments 
                                on s.StudentId equals e.StudentStudentId
                                group s by s.Name
                                into es from e1 in es.DefaultIfEmpty()                               
                                select new { es.Key, count = es.Count() }).Distinct().ToList();
                foreach (var student1 in LeftJoin)
                {
                    Console.WriteLine("{0}-{1}",student1.Key,student1.count);

                }
                /*
                foreach(var course in courseList)
                {
                    var enroll = new Enrollment()
                    {
                        Student = student,
                        Course = course
                    };
                    context.Enrollments.Add(enroll);
                    context.SaveChanges();

                }
                */
            }

            //
            Console.ReadKey();
        }
    }
}
