using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler fileObj = new FileHandler();
            fileObj.ReadFile();
            Console.ReadKey();
        }
    }
}
