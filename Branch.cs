using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ELEK_NODE_SOLVER
{
    public class Branch
    {
        // Informacje o początku i końcu // Węzły

        public int[] Tab_Of_Ngh_Nodes;

        // Informacje o przechowywanyh elementach

        //R
        public double R { get; set; }
        //L
        public double L { get; set; }
        //C
        public double C { get; set; }
        //U
        public Complex U { get; set; }
        //I
        public Complex I { get; set; }
        //Z
        public Complex Z { get; set; }

    }
}
