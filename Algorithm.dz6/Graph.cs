using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.dz6
{
    class Graph
    {
        List<Vertex> Vertexes = new List<Vertex>();
        List<Edge> Edges = new List<Edge>();
        public void AddVertex (Vertex vertex)
        {
            Vertexes.Add(vertex);
        }
        public void AddEdge(Vertex from, Vertex to, int weight)
        {
            var edge = new Edge(from, to, weight);
            Edges.Add(edge);
        }

        public int [,] GetMatrix()
        {
            var matrix = new int[Vertexes.Count, Vertexes.Count];

            foreach (var edge in Edges)
            {
                var row = edge.From.Number;
                var colomn = edge.To.Number;

                matrix[row, colomn] = edge.Weight;
            }

            return matrix;
        }

        public void Wave (Vertex vertex, int [,] matrix)
        {
            bool[] Vertexe = new bool[Vertexes.Count];
            var currentVertex = vertex;
            Queue<Vertex> nextVertex = new Queue<Vertex>();

            while (Vertexe[Vertexe.Length-1]==false)
            {
                if (Vertexe[currentVertex.Number] == false)
                {
                    Vertexe[currentVertex.Number] = true;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        if (matrix[currentVertex.Number, i] != 0 )
                        {
                            nextVertex.Enqueue(Vertexes[i]);
                        }
                    }
                }
                currentVertex = nextVertex.Dequeue();
            }
        }
    }
}
