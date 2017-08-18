using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    public interface ICalc
    {
        int AddNumbers(int x, int y);
        int MultiplyNumbers(int x, int y);
    }

    public class Calculator:ICalc
    {
        private IDataClass DObj;

        public Calculator(IDataClass DInput)
        {
            DObj = DInput;
        }
        public int AddNumbers(int x, int y)
        {

            if(x<0 || y<0)
            {
                throw (new IndexOutOfRangeException());
            }
            //Call Data class
            var result= DObj.AddNumbers(x, y);
            return result;
        }

        public int MultiplyNumbers(int x, int y)
        {
            //Call Data class
            var result =  DObj.MultiplyNumbers(x, y);
            return result;
        }
    }
}
