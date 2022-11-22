using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Utilities
{
    public class Table2List
    {
        static public List<int> ConverToList(Link.cli00IndexDataTable table)
        {
            List<int> list = new List<int>();
            foreach (Link.cli00IndexRow row in table)
            {
                list.Add(row.id);
            }
            return list;
        }
        static public List<int> ConverToList(Models.LinkRemote.cli00IndexDataTable table)
        {
            List<int> list = new List<int>();
            foreach(Models.LinkRemote.cli00IndexRow row in table)
            {
                list.Add(row.id);
            }
            return list;
        }
    }
}
