using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarlabsNET
{
    public class BusinessClass
    {
        public readonly IDataClass dataClass;
        public BusinessClass(IDataClass obj)
        {
            dataClass = obj;
        }
        public void UpdateCustomer()
        {
            dataClass.UpdateCustomer();
        }
    }
}
