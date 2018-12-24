using Santa.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santa.Route
{
    interface IPath
    {
        IPath_Node Start_Node { get; set; }
        IPath_Node End_Node { get; set; }


    } 
}
