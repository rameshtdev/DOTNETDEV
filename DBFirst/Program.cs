using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var dbcontext = new sampleDBEntities())
            {
                var assesssments = dbcontext.Assessments.OrderByDescending(o=>o.FirstName).ToList();

                foreach(var item in assesssments)
                {
                    Console.WriteLine("FirstName:{0}, LastName:{1}",item.FirstName,item.LastName);
                }
            }

                Console.ReadKey();
        }
    }
}
