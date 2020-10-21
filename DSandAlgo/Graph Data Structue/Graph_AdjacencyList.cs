using System;
using System.Collections.Generic;
using System.Text;

namespace DSandAlgo.Graph_Data_Structue
{
    class Graph_AdjacencyList : IGraph
    {
        List<int>[] adjList = new List<int>[5];

        public Graph_AdjacencyList()
        {
            for (int i = 0; i < adjList.Length; i++)
            {
                adjList[i] = new List<int>();
            }
        }

        // O(1)
        public void AddEdge(int s, int e)
        {
            adjList[s].Add(e);
            adjList[e].Add(s);
        }

        // O(n)
        public void DisplayEdges()
        {
            Console.WriteLine("");
            Console.Write("Display images ");

            for (int i = 0; i < adjList.Length; i++)
            {
                for (int j = 0; j < adjList[i].Count; j++)
                {
                    Console.Write($"({i},{adjList[i][j]}) ");
                }
            }

        }

        public bool HasEdge(int s, int e)
        {
            return adjList[s].Contains(e);
        }
        // O(1)
        public void RemoveEdge(int s, int e)
        {
            adjList[s].Remove(e);
            adjList[e].Remove(s);
        }

        public void NodeTraversal()
        {
            int node = 0;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node);
            bool[] visitedNodes = new bool[adjList.Length];
            Console.Write($"{node} ");
            visitedNodes[node] = true;
            while (queue.TryDequeue(out node))
            {
                foreach (var item in adjList[node])
                {
                    if (!visitedNodes[item])
                    {
                        Console.Write($"{item} ");
                        visitedNodes[item] = true;
                        queue.Enqueue(item);
                    }
                } 
            }
        }

        public void DFSTraversal()
        {
            int startnode = 0;
            bool[] visited = new bool[adjList.Length];
            DFS(startnode, visited);
        }

        private void DFS(int node, bool[] visited)
        {
            Console.WriteLine();
            Console.Write($"{node} ");
            visited[node] = true;
            foreach (var item in adjList[node])
            {
                if (!visited[item])
                {
                    DFS(item, visited);
                }
            }
        }
    }
}
