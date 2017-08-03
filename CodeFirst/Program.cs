using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CodeFirstDBContext())
            {
                var Student = new Student() { Name = "Paul" };
                context.Students.Add(Student);
                context.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
