using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQOtherExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ to objects
            /*
            string[] products = { "Book", "ball", "pen", "phone", "laptop", "hardrive" };

            var book = products.Where(w => w == "Book").SingleOrDefault();

            List<customer> customers = new List<customer>()
            {
                new customer() {firstname= "john", lastname = "cashel"},
                new customer() {firstname= "mary", lastname = "wood"}
            };
            var customer = customers.Where(w => w.firstname.Contains("jo")).Select(s => s.lastname).FirstOrDefault();
            Console.WriteLine(customer);
            */


            //LINQ to SQL
            /*
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["LINQOtherExamples.Properties.Settings.ModelFirstConnectionString"].ToString();
            ModelFirstDataContext context = new ModelFirstDataContext(conn);
            var listofStudents = context.Students.Select(s => s.Name).ToList();
           foreach(var item in listofStudents)
           {
               Console.WriteLine(item);
           }
          
            var newStudent = new Student() { Name = "jack" };
            context.Students.InsertOnSubmit(newStudent);
            context.SubmitChanges();
             */

            //LINQ to XML
            var sampleXML = @"<departments>
                                <department>Engineering</department>
                                <department>Sales</department>
                                <department>QA</department>
                                <department>Accounts</department>
                                <department>HR</department>
                                </departments>";

            XDocument doc = new XDocument();
            doc = XDocument.Parse(sampleXML);
            doc.Element("departments").AddFirst(new XElement("department", "support"));
            var departments = doc.Element("departments").Descendants();
            foreach(var item in departments)
            {
                Console.WriteLine("Department name - {0}",item.Value);
            }

            Console.ReadKey();
        }
    }
    public class customer
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
}
