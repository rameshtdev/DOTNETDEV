using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    public interface IDataClass
    {
        int AddNumbers(int x, int y);
        int MultiplyNumbers(int x, int y);
    }

    public class DataClass: IDataClass
    {
        public int AddNumbers(int x, int y)
        {
            //Coming from DB
            return (x + y);
        }

        public int MultiplyNumbers(int x, int y)
        {
            //Coming from DB
            return (x * y);
        }
    }
}
