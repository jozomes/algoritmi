using System;
using System.Collections.Generic;

class Program
{
    static List<List<int>> CreateAdjacencyList(List<List<int>> edges, int numVertices)
    {
        // Inicijalizirajte listu susjedstva
        List<List<int>> adjList = new List<List<int>>(new List<int>[numVertices]);

        // Popunite listu susjedstva na temelju bridova u
        // grafu
        for (int i = 0; i < edges.Count; i++)
        {
            int u = edges[i][0];
            int v = edges[i][1];
            // Budući da je graf neusmjeren, stoga guramo bridove u oba smjera
            adjList[u].Add(v);
            adjList[v].Add(u);
        }

        return adjList;
    }

    static void Main()
    {
        // Neusmjereni graf od 4 čvora
        int numVertices = 4;
        List<List<int>> edges = new List<List<int>> { new List<int> { 0, 1 }, new List<int> { 0, 2 }, new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 1 } };

        // Kreirajte listu susjedstva
        List<List<int>> listasus = CreateAdjacencyList(edges,numVertices);

        // Ispišite listu susjedstva
        foreach (List<int> item in listasus)
        {
            foreach (int item1 in item)
            {
                Console.Write(item1);
            }
        }
        Console.ReadKey();
    }
}