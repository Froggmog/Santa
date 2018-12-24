using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santa.Node
{
    
    interface IPath_Node
    {
        IPath_Node Next_Node { get; set; }
        IPath_Node Prev_Node { get; set; }
        int Weight { get; set; }

    }
}
