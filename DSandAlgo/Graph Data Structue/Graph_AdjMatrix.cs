using System;
using System.Collections.Generic;
using System.Text;

namespace DSandAlgo.Graph_Data_Structue
{
    /// <summary>
    /// Graph implementation for Adjacency matrix
    /// </summary>
    class Graph_AdjMatrix : IGraph
    {
        public int[,] adjMatrix = new int[5, 5];

        public Graph_AdjMatrix()
        {

        }
        
        //O(1)
        public void AddEdge(int s, int e)
        {
            adjMatrix[s, e] = 1;
            adjMatrix[e, s] = 1;
        }
        
        //O(n^2)
        public void DisplayEdges()
        {
            Console.WriteLine();
            Console.Write("Display Edges ");
            for (int i = 0; i < adjMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < adjMatrix.GetLength(1); j++)
                {
                    if (adjMatrix[i, j] == 1)
                    {
                        Console.Write($"({i},{j}) " );
                    }
                }
            }       
        }

        // O(1)
        public bool HasEdge(int s, int e)
        {
            return adjMatrix[s, e] > 0;
        }

        public void NodeTraversal()
        {
            throw new NotImplementedException();
        }

        // O(1)
        public void RemoveEdge(int s, int e)
        {
            adjMatrix[s, e] = 0;
            adjMatrix[e, s] = 0;
        }
    }
}
