using System;
using System.Collections.Generic;

namespace graph
{
    public class Graff
    {
        List<Vertecx> Vertexes = new List<Vertecx>();
        
        List<Edge> Edges = new List<Edge>();

        public int VertecxCount => Vertexes.Count;
        public int EdgeCount => Edges.Count;

        public void AddVertext(Vertecx vertex)
        {
           Vertexes.Add(vertex);
        }

        public void AddEdge(Vertecx from, Vertecx to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);
        }

        public int[,] GetMatrix()
        {
            var matrix = new int[Vertexes.Count, Edges.Count];

            foreach (var edge in Edges)//проходим по матрице и выставляем метки
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;

                matrix[row, column] = edge.Weight; //само пересечение

            }

            return matrix;
        }

        public List<Vertecx> GetVertexLists(Vertecx vertecx)
        {
            var result = new List<Vertecx>();

            foreach (var edge in Edges)
            {
                if (edge.From == vertecx)
                {
                    result.Add(edge.To);

                }
            }
            return result;
        }
        public bool Wave(Vertecx start, Vertecx finish)
        {
            var result = new List<Vertecx>();
            var list = new List<Vertecx> { start };

            list.Add(start);

            for (int i = 0; i < list.Count; i++)
            {
                var vertex = list[i];
                foreach (var item in GetVertexLists(vertex))
                {
                    if (!list.Contains(item))
                    {
                        list.Add(item);
                    }
                }
            }
            return list.Contains(finish);
        }
    }
}
