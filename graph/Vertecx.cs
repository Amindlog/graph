using System;

namespace graph
{
    /// <summary>
    /// вершина
    /// </summary>
    public class Vertecx
    {
        public Vertecx(int number)
        {
            Number = number;
        }
        public int Number { get; set; }

        public override string ToString()
        {
            return Number.ToString();
        }
       
    }
}
