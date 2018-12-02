using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDA_Basic_Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Node A = new Node('A');
            Node B = new Node('B');
            Node C = new Node('C');
            Node D = new Node('D');
            Node E = new Node('E');

            Graph graph = new Graph();

            A.AddNeighbour(new Link(4, B));
            A.AddNeighbour(new Link(8, C));
            graph.AddNode(A);

            B.AddNeighbour(new Link(4, A));
            B.AddNeighbour(new Link(7, C));
            B.AddNeighbour(new Link(18, D));
            graph.AddNode(B);

            C.AddNeighbour(new Link(8, A));
            C.AddNeighbour(new Link(7, B));
            C.AddNeighbour(new Link(10, D));
            C.AddNeighbour(new Link(25, E));
            graph.AddNode(C);

            D.AddNeighbour(new Link(18, B));
            D.AddNeighbour(new Link(10, C));
            D.AddNeighbour(new Link(12, E));
            graph.AddNode(D);

            E.AddNeighbour(new Link(25, C));
            E.AddNeighbour(new Link(12, D));
            graph.AddNode(E);

            
        }
    }
}
