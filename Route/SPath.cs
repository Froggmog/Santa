using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Santa.Node;

namespace Santa.Route
{
    class SPath : IPath
    {

        private IPath_Node start_Node;
        private IPath_Node end_Node;
        private long total_weight;
        private static long maximum_weight;

        public IPath_Node Start_Node { get => start_Node; set => start_Node = value; }
        public IPath_Node End_Node { get => end_Node; set => end_Node = value; }
        public long Total_weight { get => total_weight; set => total_weight = value; }
        public static long Maximum_weight { get => maximum_weight; set => maximum_weight = value; }

        public SPath(IPath_Node p_start_node, IPath_Node p_end_node)
        {
            Start_Node = p_start_node;
            End_Node = p_end_node;
            Total_weight = 0;
        }



    }
}
