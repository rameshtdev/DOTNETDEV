using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarlabsNET
{

    public class Animal
    {
        public void notOverride()
        {
            Console.WriteLine("Animal notOverride");
        }
        public virtual void eat()
        {
            Console.WriteLine("Animal eat");
        }
        public virtual void makenoise()
        {
            Console.WriteLine("Animal makenoise");
        }
    }

    public class dog: Animal
    {
        public void dogspecific()
        {
            Console.WriteLine("dog specific");
        }
        public override void eat()
        {
            Console.WriteLine("dog eat");
        }
        public override void makenoise()
        {
            Console.WriteLine("dog makenoise");
        }
    }
    
    class InheritanceTest
    {
    }
}
