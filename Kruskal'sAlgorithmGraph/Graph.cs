using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskal_sAlgorithmGraph
{

    public class Edge
    {
        public int Source { get; set; }
        public int Destination { get; set; }
        public int Weight { get; set; }
    }

    public class Graph
    {
        private List<Edge> edges;

        public Graph(List<Edge> graphEdges)
        {
            edges = graphEdges;
        }

        public List<Edge> GetMinimumSpanningTree()
        {
            List<Edge> minimumSpanningTree = new List<Edge>();

            edges.Sort((x, y) => x.Weight.CompareTo(y.Weight));

            int[] parent = new int[edges.Count];
            for (int i = 0; i < edges.Count; i++)
            {
                parent[i] = i;
            }

            foreach (Edge edge in edges)
            {
                int sourceRoot = Find(parent, edge.Source);
                int destinationRoot = Find(parent, edge.Destination);

                if (sourceRoot != destinationRoot)
                {
                    minimumSpanningTree.Add(edge);
                    Union(parent, sourceRoot, destinationRoot);
                }
            }

            return minimumSpanningTree;
        }

        private int Find(int[] parent, int vertex)
        {
            if (vertex != parent[vertex])
            {
                parent[vertex] = Find(parent, parent[vertex]);
            }
            return parent[vertex];
        }

        private void Union(int[] parent, int source, int destination)
        {
            int sourceRoot = Find(parent, source);
            int destinationRoot = Find(parent, destination);
            parent[sourceRoot] = destinationRoot;
        }
    }

}
