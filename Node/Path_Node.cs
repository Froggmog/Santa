using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santa.Node
{
    internal class Path_Node : IPath_Node
    {
        public IPath_Node Next_Node { get; set; }
        public IPath_Node Prev_Node { get; set; }
        public int Weight { get; set; }
        public int ID { get; set; }
        public SortedDictionary<float, IPath_Node> list_Distances { get; set; }
        

        public Path_Node(int id, int weight)
        {
            ID = id;
            Weight = weight;
        }
        public void checkDistanceList()
        {
            foreach (KeyValuePair<float, IPath_Node> item in list_Distances)
            {

                break;
            }
        }
        
    }
}