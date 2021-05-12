using System;

namespace Algorithm.dz6
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            var v0 = new Vertex(0);
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);

            graph.AddVertex(v0);
            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);


            Console.ReadLine();
        }
    }
}
