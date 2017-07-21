using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarlabsNET
{
    class Program
    {
        enum days { sun, mon, tue, wed, thu, fri, sat };

        static void Main(string[] args)
        {

            /*
            //string message = string.Format("Hello World-{0}-{1}-{2}",DateTime.Now.Day,DateTime.Now.Month,DateTime.Now.Year);
            //Console.WriteLine("Hello World-{0}-{1}-{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            Rectangle rect = new Rectangle(2,4);
            Console.WriteLine("Area is {0}", rect.Area);

            rect.Area = 11;

            Console.WriteLine("Area is {0}", rect.Area);
            

            //1 Animal type - assign dog instance
            Animal a1 = new dog();
            a1.makenoise();
            a1.notOverride(); // it has the extra method
            //a1.dogspecific(); ?? not available
            //2 dog type - assign dog instance
            dog a2 = new dog();
            a2.makenoise();
            a2.dogspecific();

            //3 Dog type - assign Animal instance
            //dog a3 = new Animal();
            //4 Animal type - assign Animal instance
            Animal a4 = new Animal();
            a4.makenoise();

            Dear |FirstName| |LastName|,
            |Recreuiter| at extension |extnnumber| 
            


            string a = "Hello";
            string b = "World";
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" ");
            sb.Append("\"");
            sb.Append(b);
            sb.Append("\"");
    
            Console.WriteLine("c:{0}", sb);
           

            var a = Console.ReadLine();
            string b = new string(a.ToCharArray().Reverse().ToArray());
            if (a.Equals(b))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");

            var a = Console.ReadLine();
            foreach(var c in a.ToCharArray())
            {
                Console.WriteLine(c);
            }

            
            if (a.Equals(b))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
            
            dog a2 = new dog();
            a2.makenoise();
            int[] a = { 1, 2, 3, 4 };
            string[] s = { "abc", "gfdh" };
            ArrayList a1 = new ArrayList();
            a1.Add("abc");
            

            //Boxing
            int? i = 5;
            object o = i;
            //Unboxing
            int j1 = Convert.ToInt32(o);
            

            //Implicit casting
            Int32 i = 2;
            Int64 j = i;
            //Explicit casting
            int i1 = 5;
            string s2 = i1.ToString();
            

            int j = 0;
            int z = 1;

            try
            {
                int c = z / j;
            }
            catch (DivideByZeroException ex)
            {
                //Console.WriteLine(ex.ToString());
                //throw ex;
                throw new Exception(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            }
            
            
            //Var dynamic and object
            var o = 1;
            var a = "abc";

            dynamic d = 1;
            dynamic d1 = 2;
            dynamic d2 = d + d1;
            

            object o123 = 1;
            object a1 = 2;
            object int1 = (int)o123 + (int)a1;
            
            //GetType, TypeOf, Dynamic
            dynamic d = 1;
            dynamic d1 = 5;// "abc";// 3

            dynamic d2;
            
            if(d.GetType() == typeof(int) || d1.GetType() == typeof(int))
            {
                d2 = d / d1;
            }
            

            //Terenary operator
            int age = 5;
            bool isAdult = false;
            /*
            if(age>21)
            {
                isAdult = true;
            }
            else
            {
                isAdult = false;
            }
            

            isAdult = age > 21 ? true : false;
            

            //Null Coalese operator
            int? age = null;
            int age1 = 0;

            if(age == null)
            {
                age1 = 18;
            }

            
            age1 = age ?? 18;
            

            //AND / OR

            bool isValidUser = true;
            int DepartmentId = 24;
            string role = "admin";

            if((role == "admin"|| DepartmentId == 24) && isValidUser)
            {
                //some code
            }
            */
            // HW
            int[] array = { 1, 2, 3, 3, 3, 4, 4, 1, 6, 5, 6, 8 };
            //  1   2
            //  2   1
            //  3   3
            /*
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach(var i in array)
            {
                if(dict.ContainsKey(i))
                {
                    dict[i] = dict[i] + 1;
                }
                else
                {
                    dict.Add(i, 1);
                }

            }
            foreach(var value in dict)
            {
                Console.WriteLine("{0}  {1}", value.Key, value.Value);
            }
            

            string s = "The motivation behind the development of REST was to create a design pattern for how the Web should work, so that it could act as a guiding framework for the Web standards and designing Web services. REST itself is not a <div><b>hello world !!</b></div> standard but it prescribes the <div><b>hello world !!</b></div> use of standards such as HTTP, URL, and XML/HTML/JPEG. REST - style architectures consist of clients and servers. Clients initiate requests to servers who process these requests and return responses based on these requests. These requests and responses are built around the transfer of representations of these resources. A resource can be any coherent and meaningful concept that can be addressed, while a representation of a resource is a document that captures the intended state of a resource.Fundamentally in REST each resource is first identified using a URL and a new resource for every service required is created.The data returned by the service must be linked to the other data, hence making it in to a network of information unlike the Object Oriented design which encourages the encapsulation of information.";
            

            Console.WriteLine("Today is {0}", (int)days.mon);
            Cat c = new Cat();
            c.makenoise();
            c.eat();
            */

            BusinessClass B = new BusinessClass((new OracleDataClass()));
            B.UpdateCustomer();

            BusinessClass B1 = new BusinessClass((new SQLDataClass()));
            B1.UpdateCustomer();

            Console.ReadKey();

        }
    }
}
