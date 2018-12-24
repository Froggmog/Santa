using Santa.Node;
using Santa.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;



namespace Santa.Search
{
    class Santasearch
    {
        private MutableDataTable dt;
        private ICollection<IPath_Node> nodes;

        public Santasearch()
        {
            
            dt = DataTable.New.Read("C:\\Users\\renel\\source\\repos\\Santa\\Santa\\data\\nicelist.csv", ';', false);
            foreach (var x in dt.Rows)
            {
                foreach (var y in dt.Rows)
                {
                    string s = x["ID"];
                }
            }
            dt.DeleteColumn
        }
        
        
    }
}
