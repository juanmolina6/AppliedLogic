using System;

class HourGlass
{
    static void Main()
    {

        Console.Write("Ingrese orden de la matriz: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine();


        int[,] m = new int[n, n];


        Console.WriteLine("MATRIZ COMPLETA");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                m[i, j] = (i * 2) + j;
                Console.Write(m[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Declarar e inicializar matriz auxiliar
        string[,] a = new string[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                a[i, j] = "";
            }
        }

        int x = n / 2;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n - i; j++)
            {
                a[i, j] = "" + m[i, j];
                a[n - i - 1, j] = "" + m[n - i - 1, j];
            }
        }
        Console.WriteLine();
        Console.WriteLine("RELOJ DE ARENA");
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}