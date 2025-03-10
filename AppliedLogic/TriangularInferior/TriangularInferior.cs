using System;

class TriangularInferior
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine();

        int[,] matriz = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {

                matriz[i, j] = i + j;
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Imprime la triangular inferior
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}