using System;
using System.Collections.Generic;
using System.Text;

namespace DSandAlgo.Graph_Data_Structue
{
    /// <summary>
    /// Graph implementation using linked list
    /// </summary>
    class Graph_LinkedList : IGraph
    {
        LinkedList<int>[] _nodes;

        public Graph_LinkedList()
        {
            this._nodes = new LinkedList<int>[5];
            for (int i = 0; i < _nodes.Length; i++)
            {
                _nodes[i] = new LinkedList<int>();
            }
        }

        // O(1)
        public void AddEdge(int s, int e)
        {
            _nodes[s].AddLast(e);
            _nodes[e].AddLast(s);
        }

        // O(n)
        public bool HasEdge(int s, int e)
        {
            foreach (var item in _nodes[s])
            {
                if (item == e)
                {
                    return true;
                }
            }
            return false;
        }

        // O(n)
        public void RemoveEdge(int s, int e)
        {
            _nodes[s].Remove(e);
            _nodes[e].Remove(s);
        }

        public void CreateDefault()
        {
            for (int i = 0; i < _nodes.Length; i++)
            {
                _nodes[i] = new LinkedList<int>();
            }

            AddEdge(0, 1);
            AddEdge(0, 4);
            AddEdge(1, 2);
            AddEdge(1, 3);
            AddEdge(1, 4);
            AddEdge(2, 3);
            AddEdge(3, 4);
        }
        
        // O(2e) or O(n^2)
        public void DisplayEdges()
        {
            Console.WriteLine();
            Console.Write("Display edges ");

            for (int i = 0; i < _nodes.Length; i++)
            {
                foreach (var item in _nodes[i])
                {
                    Console.Write($"({i},{item}) ");
                }
            }
        }

        public void NodeTraversal()
        {
            throw new NotImplementedException();
        }
    }
}
