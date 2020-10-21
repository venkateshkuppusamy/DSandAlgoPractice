using DSandAlgo.Graph_Data_Structue;
using System;

namespace DSandAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graph implementation");
            GraphDirected gh = new GraphDirected();
            //gh.CreateDefault();
            //gh.DisplayEdges();

            gh.AddEdge(0, 2);
            gh.AddEdge(2, 1);
            gh.AddEdge(3, 1);
            gh.AddEdge(3, 2);

            //gh.DisplayEdges();
            //gh.RemoveEdge(0, 1);
            gh.AddEdge(4, 0);
            gh.AddEdge(4, 2);
            gh.AddEdge(4, 3);
            gh.DisplayEdges();
            gh.NodeTraversal();

            Console.WriteLine($"Mother Vertex: {gh.FindMotherVertex()}");
            Console.ReadLine();
        }
    }

    
}
