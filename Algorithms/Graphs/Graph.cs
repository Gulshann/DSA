using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms.Graphs
{
    public class Graph
    {
        List<List<Edge>> network = new List<List<Edge>>();

        List<List<EdgeWeighted>> networkWeigthed = new List<List<EdgeWeighted>>();

        List<Edge> Node = new List<Edge>();
        public Graph()
        {
            BuildNonWeightedAdjacencyGraph();
        }

        public void BuildNonWeightedAdjacencyGraph()
        {
            network.Add(new List<Edge>());
            network.Add(new List<Edge>());
            network.Add(new List<Edge>());
            network.Add(new List<Edge>());
            network.Add(new List<Edge>());
            network.Add(new List<Edge>());
            network.Add(new List<Edge>());

            network[0].Add(new Edge(0, 1));
            network[0].Add(new Edge(0, 2));

            network[1].Add(new Edge(1, 0));
            network[1].Add(new Edge(1, 3));

            network[2].Add(new Edge(2, 0));
            network[2].Add(new Edge(2, 4));

            network[3].Add(new Edge(3, 1));
            network[3].Add(new Edge(3, 4));
            network[3].Add(new Edge(3, 5));

            network[4].Add(new Edge(4, 2));
            network[4].Add(new Edge(4, 3));
            network[4].Add(new Edge(4, 4));

            network[5].Add(new Edge(5, 3));
            network[5].Add(new Edge(5, 4));
            network[5].Add(new Edge(5, 6));

            network[6].Add(new Edge(6, 5));


        }

        public void BFS()
        {
            Queue<int> queue = new Queue<int>();

            bool[] visited = new bool[7];

            queue.Enqueue(0);

            while (queue.Count > 0)
            {
                int curr = queue.Dequeue();

                if (!visited[curr])
                {
                    Console.Write(curr + " "); // Print the current
                    visited[curr] = true;  // Mark visited index to be true and then add all the neighbours of curr in the queue.
                    
                    foreach(var item in network[curr])
                    {
                        queue.Enqueue(item.end);
                    }
                }
            }
        }

        public void PrintGraph()
        {
            int i = 0;
            foreach (var item in network)
            {
                Console.WriteLine($"Network {i++} ");
                foreach (var ii in item)
                {
                    Console.Write($"{ii.start} --> {ii.end}  ");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        //public void BuildWeightedAdjacencyGraph()
        //{
        //    networkWeigthed.Add(new List<EdgeWeighted>());
        //    networkWeigthed.Add(new List<EdgeWeighted>());
        //    networkWeigthed.Add(new List<EdgeWeighted>());
        //    networkWeigthed.Add(new List<EdgeWeighted>());
        //    networkWeigthed[0].Add(new EdgeWeighted(0, 2,3));
        //    networkWeigthed[1].Add(new EdgeWeighted(1, 2,2));
        //    networkWeigthed[1].Add(new EdgeWeighted(1, 3));
        //    networkWeigthed[2].Add(new EdgeWeighted(2, 0));
        //    networkWeigthed[2].Add(new EdgeWeighted(2, 1));
        //    networkWeigthed[2].Add(new Edge(2, 3));
        //    networkWeigthed[3].Add(new Edge(3, 1));
        //    networkWeigthed[3].Add(new Edge(3, 2));
        //}
    }

    public class Edge
    {
        public Edge(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public int start { get; set; }
        public int end { get; set; }
    }

    public class EdgeWeighted
    {
        public int start { get; set; }
        public int end { get; set; }
        public int weight { get; set; }
        public EdgeWeighted(int start, int end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
        }
    }
}
