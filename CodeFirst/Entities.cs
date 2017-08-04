using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Enrollment> enrollments { get; set; }
    }
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Enrollment> enrollments { get; set; }
    }

    public class Address
    {
        public int AddressId { get; set; }
        public int StudentId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int CourseCourseId { get; set; }
        public virtual Course course { get; set; }

        public int StudentStudentId { get; set; }
        public virtual Student student { get; set; }
    }
}
