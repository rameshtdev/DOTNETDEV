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

            /*
             (1) Enable-Migrations
            (2) Add-Migration Version_Name -ConnectionString "data source=.\sqlexpress;initial catalog=codefirstDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" -ConnectionProviderName "System.Data.SqlClient" -Verbose

            (3) Update-Database -ConnectionString "data source=.\sqlexpress;initial catalog=codefirstDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" -ConnectionProviderName "System.Data.SqlClient" -Verbose

             */
        }
    }
}
