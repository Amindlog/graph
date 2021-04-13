using System;

namespace graph
{
    public class Program
    {
        static void Main(string[] args)
        {
            var graff = new Graff();

            var v1 = new Vertecx(1);
            var v2 = new Vertecx(2);
            var v3 = new Vertecx(3);
            var v4 = new Vertecx(4);
            var v5 = new Vertecx(5);
            var v6 = new Vertecx(6);
            var v7 = new Vertecx(7);

            //создание вершин
            graff.AddVertext(v1);
            graff.AddVertext(v2);
            graff.AddVertext(v3);
            graff.AddVertext(v4);
            graff.AddVertext(v5);
            graff.AddVertext(v6);
            graff.AddVertext(v7);

            //создание ребр
            graff.AddEdge(v1, v2);
            graff.AddEdge(v1, v3);
            graff.AddEdge(v3, v4);
            graff.AddEdge(v2, v5);
            graff.AddEdge(v2, v6);
            graff.AddEdge(v6, v5);
            graff.AddEdge(v5, v6);

            GetMatrix(graff);

            Console.WriteLine();
            Console.WriteLine();

            GetVertex(v1, graff);
            GetVertex(v2, graff);
            GetVertex(v3, graff);
            GetVertex(v4, graff);
            GetVertex(v5, graff);
            GetVertex(v6, graff);
            GetVertex(v7, graff);

            Console.WriteLine(graff.Wave(v1, v5));
            Console.WriteLine(graff.Wave(v2, v4));

            Console.ReadLine();
        }
        private static void GetVertex(Vertecx vertecx, Graff graff)
        {
            Console.Write($"{vertecx.Number}: ");
            foreach (var v in graff.GetVertexLists(vertecx))
            {
                Console.Write(v.Number + ", ");
            }
            Console.WriteLine();
        }
        private static void GetMatrix(Graff graff)
        {
            var matrix = graff.GetMatrix();
            for (int i = 0; i < graff.VertecxCount; i++)
            {
                Console.Write($"{i + 1}");
                for (int j = 0; j < graff.VertecxCount; j++)
                {
                    Console.Write($"| {matrix[i, j]} |");
                }
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
            }
            for (int i = 0; i < graff.VertecxCount; i++)
            {
                if (i == 0)
                {
                    Console.Write(" ");
                }
                Console.Write($"| {i + 1} |");

            }
        }
    }
}
