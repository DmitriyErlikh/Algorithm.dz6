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

            graph.AddEdge(v0, v1, 4);
            graph.AddEdge(v0, v2, 7);
            graph.AddEdge(v1, v3, 9);
            graph.AddEdge(v1, v5, 8);
            graph.AddEdge(v2, v4, 7);
            graph.AddEdge(v2, v5, 3);
            graph.AddEdge(v2, v6, 1);
            graph.AddEdge(v3, v5, 5);
            graph.AddEdge(v4, v3, 2);
            graph.AddEdge(v4, v6, 6);

            int [,] matrix =  graph.GetMatrix();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j<matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
            }

            graph.Wave(v0, matrix);

            Console.ReadLine();
        }
    }
}
