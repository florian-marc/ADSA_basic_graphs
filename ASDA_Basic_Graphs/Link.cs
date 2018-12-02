using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDA_Basic_Graphs
{
    class Link
    {
        int cost;
        Node end;

        public Link(int cost, Node end)
        {
            this.cost = cost;
            this.end = end;
        }

        public int Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }

        public Node End
        {
            get { return this.end; }
            set { this.end = value; }
        }

    }
}
