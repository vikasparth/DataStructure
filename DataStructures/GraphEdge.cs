using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class GraphEdge
    {
        GraphNode Start;
        GraphNode End;
        int Weight;

        public GraphEdge(int weight)
        {
            this.Weight = weight;
        }
    }
}
