using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDA_Basic_Graphs
{
    class Graph
    {
        private LinkedList<Node> nodes;

        public Graph()
        {
            nodes = new LinkedList<Node>();
        }

        public void AddNode(Node node)
        {
            nodes.AddLast(node);
        }

        public LinkedList<Node> BFS(Node start, Node end)
        {
            LinkedList<Node> output = new LinkedList<Node>();
            while(start != end)
            {

            }
        }
    }
}
