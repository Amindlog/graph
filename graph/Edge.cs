using System;

namespace graph
{
    public class Edge
    {
        /// <summary>
        /// Ребро граффа
        /// </summary>
        /// <param name="from"> откуда</param>
        /// <param name="to">куда</param>
        /// <param name="weight">вес</param>
        public Edge(Vertecx from, Vertecx to, int weight = 1)
        {
            From = from;
            To = to;
            Weight = weight;
        }
        public Vertecx From { get; set; }

        public Vertecx To { get; set; }

        public int Weight { get; set; }

        public override string ToString()
        {
            return $"({From};{To})";
        }
    }
}
