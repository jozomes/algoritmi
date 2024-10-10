using System;
using System.Collections.Generic;

class Program
{
    static List<List<int>> CreateAdjacencyMatrix(List<List<int>> graph, int numVertices)
    {
        // Inicijaliziraj matricu susjedstva s nulama
        List<List<int>> adjMatrix = new List<List<int>>(new List<int>[numVertices]);
        for (int i = 0; i < numVertices; ++i)
        {
            adjMatrix[i] = new List<int>(new int[numVertices]);
        }

        // Popuni matricu susjedstva na temelju bridova u
        // grafu
        for (int i = 0; i < numVertices; ++i)
        {
            for (int j = 0; j < numVertices; ++j)
            {
                if (graph[i][j] == 1)
                {
                    adjMatrix[i][j] = 1;
                    adjMatrix[j][i] = 1; // Za neusmjereni graf, postavi
                                         // simetrične unose
                }
            }
        }

        return adjMatrix;
    }

    static void Main()
    {
        // Primjer grafa predstavljenog kao lista susjedstva
        // Indeksi predstavljaju vrhove, a vrijednosti
        // su liste susjednih vrhova
        List<List<int>> graph = new List<List<int>> { new List<int> { 0, 1, 0, 0 } };
        // unesi ostatak matrice
  
        int numVertices = graph.Count;


        // Kreiraj matricu susjedstva
        List<List<int>> matsus = CreateAdjacencyMatrix(graph,numVertices);

        // Ispiši matricu susjedstva
        Console.WriteLine("Matrica susjedstva:");
        for (int i = 0; i < numVertices; ++i)
        {
            for (int j = 0; j < numVertices; ++j)
            {
                Console.Write(matsus[i][j] + " ");
            }
            Console.WriteLine(); //prelaazak u novu liniju nakon ispisa trenutnog
        }
    }
}

