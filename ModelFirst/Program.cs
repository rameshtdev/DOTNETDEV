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
                
            }
            Console.ReadKey();
        }
    }
}
