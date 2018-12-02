using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDA_Basic_Graphs
{
    class Node
    {
        char value;
        LinkedList<Link> neighbours;

        public Node(char value)
        {
            this.value = value;
            neighbours = new LinkedList<Link>();
        }

        public char Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public void AddNeighbour(Link neighbour)
        {
            neighbours.AddLast(neighbour);
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Node node = obj as Node;
                return node.value == value;
            }
            else return false;
        }
    }
}
