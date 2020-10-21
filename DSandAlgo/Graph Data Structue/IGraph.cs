using System;
using System.Collections.Generic;
using System.Text;

namespace DSandAlgo.Graph_Data_Structue
{
    interface IGraph
    {
        public void AddEdge(int s, int e);

        public bool HasEdge(int s, int e);

        public void RemoveEdge(int s, int e);

        public void DisplayEdges();

        public void NodeTraversal();
    }
}
