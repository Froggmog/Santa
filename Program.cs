using Santa.Node;
using Santa.Route;
using Santa.Search;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            IPath_Node n1 = new Path_Node(1,1);
            IPath_Node n2 = new Path_Node(2,2);
            IPath path = new SPath(n1, n2);
            Console.WriteLine(Directory.GetCurrentDirectory());
            Santasearch santasearch = new Santasearch();
            Console.WriteLine("Pause");
        }
    }
}
