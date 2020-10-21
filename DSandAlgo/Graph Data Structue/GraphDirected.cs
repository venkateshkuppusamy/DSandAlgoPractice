using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSandAlgo.Graph_Data_Structue
{
    class GraphDirected : IGraph
    {
        List<int>[] adjList = new List<int>[5];

        public GraphDirected()
        {
            for (int i = 0; i < 5; i++)
            {
                adjList[i] = new List<int>();
            }
        }

        public void AddEdge(int s, int e)
        {
            adjList[s].Add(e);
        }

        public void DisplayEdges()
        {
            for (int i = 0; i < adjList.Length; i++)
            {
                foreach (var item in adjList[i])
                {
                    Console.Write($"({i},{item})");
                }
            }
        }

        public bool HasEdge(int s, int e)
        {
            return adjList[s].Contains(e);
        }

        public void NodeTraversal()
        {
            Console.WriteLine("");
            Console.Write("BFS traversal ");
            int startNode = 0;
            bool[] visited = new bool[adjList.Length];
            Console.Write($"{startNode} ");
            visited[startNode] = true;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startNode);
            while (queue.TryDequeue(out startNode))
            {
                foreach (var item in adjList[startNode])
                {
                    if (!visited[item])
                    {
                        Console.Write($"{item} ");
                        visited[item] = true;
                        queue.Enqueue(item);
                    }
                } 
            }
        }

        public int NodeTraversed(int node)
        {
            bool[] visited = new bool[adjList.Length];
            visited[node] = true;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node);
            while (queue.TryDequeue(out node))
            {
                foreach (var item in adjList[node])
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        queue.Enqueue(item);
                    }
                }
            }
            return visited.Count(s => s == true);
        }

        public void RemoveEdge(int s, int e)
        {
            adjList[s].Remove(e);
        }

        public int FindMotherVertex()
        {
            int motherNode = 0;
            int count, maxcount = 0;
            for (int i = 0; i < 5; i++)
            {
                count = this.NodeTraversed(i);
                if (count > maxcount)
                {
                    maxcount = count;
                    motherNode = i;
                }
            }
            return maxcount == adjList.Length ? motherNode : -1;
            
        }
    }
}
