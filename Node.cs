using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELEK_NODE_SOLVER
{
    public class Node
    {
        public double V;

        public int Index;

        public string name;

        public List<Branch> List_Of_Ngh_Branch = new List<Branch>();
    }
}
