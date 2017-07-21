using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarlabsNET
{
    public class Cat : IAnimal
    {
        public void makenoise()
        {
            Console.WriteLine("Cat makenoise");
        }
        public void eat()
        {
            Console.WriteLine("Cat eat");
        }
    }
}
