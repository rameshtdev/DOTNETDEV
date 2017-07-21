using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarlabsNET
{
    public class Rectangle
    {
        private int _length;
        private int _width;
        private int _area;
        public const double pi = 3.14;
        public readonly int id;

        public void test()
        {
            int a = 1;
            string s = "sam";
            s = "john";
            String s1 = "sam";
        }

        public int Area
        {
            get
            {        
                return _area;
            }
            set
           {
                _area = value;
           }
        }
        public Rectangle(int len, int wid)
        {
            id = 1;
            _area = len * wid;
            Console.WriteLine("length:{0}, Width:{1}", len, wid);
        }
        public Rectangle(double len,double wid)
        {
            Console.WriteLine("length:{0}, Width:{1}", len, wid);
        }
    }
}
