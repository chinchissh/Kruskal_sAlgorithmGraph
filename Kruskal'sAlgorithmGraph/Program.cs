using System;

namespace Kruskal_sAlgorithmGraph
{
    public class Program // Графы, алгоритм Краскала
    {
        public static void Main()
        {
            List<Edge> graphEdges = new List<Edge>()
        {
            new Edge { Source = 1, Destination = 2, Weight = 3 },
            new Edge { Source = 1, Destination = 4, Weight = 2 },
            new Edge { Source = 2, Destination = 3, Weight = 5 },
            new Edge { Source = 2, Destination = 5, Weight = 4 },
            new Edge { Source = 3, Destination = 6, Weight = 1 },
            new Edge { Source = 6, Destination = 7, Weight = 3 },
            new Edge { Source = 7, Destination = 8, Weight = 2 },
            new Edge { Source = 4, Destination = 8, Weight = 6 },
            new Edge { Source = 5, Destination = 8, Weight = 2 },
            // Добавьте остальные ребра графа здесь
        };

            Graph graph = new Graph(graphEdges);
            List<Edge> minimumSpanningTree = graph.GetMinimumSpanningTree();

            Console.WriteLine("Ребра, включенные в минимальное остовное дерево:");
            foreach (Edge edge in minimumSpanningTree)
            {
                Console.WriteLine($"{edge.Source} -- {edge.Destination} (вес: {edge.Weight})");
            }
        }
    }
}
