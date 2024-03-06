using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELEK_NODE_SOLVER
{
    public static class Global
    {
        // Listy przechowujące informacje o obiektach topologii

        public static List<Node> List_Of_Nodes = new List<Node>();
        public static List<Branch> List_Of_Branches = new List<Branch>();

        // Parametry elektryczne globalne

        public static double frec = 50;

    }
}
