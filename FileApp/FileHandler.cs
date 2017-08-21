using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileApp
{
    public class FileHandler
    {
        public void writeFile()
        {
            var path = @"C:\temp\CSharpFile.csv";
            StreamWriter w;
            if (!File.Exists(path))
            {
                w = new StreamWriter(path);
                w.WriteLine(string.Format("{0},{1}", 1, "Mike"));
            }
            else
            {
                w = File.AppendText(path);
                w.WriteLine(string.Format("{0},{1}", 2, "Mary"));
            }
            w.Close();
        }
        public void ReadFile()
        {
            var path = @"C:\temp\CSharpFile.csv";
            StreamReader r = new StreamReader(path);
            while(r.Peek()>0)
            {
                Console.WriteLine(r.ReadLine());
            }
            
            r.Close();
        }
    }
}
