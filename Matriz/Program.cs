using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matriz = { }; // matriz unidimensional
            int[,] matriz1 = { {2,4}, {6,8} }; // matriz inicializada

            int[,] matriz2 = new int[2, 2]; // forma incorrecta

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matriz1[i, j]);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matriz2[i, j]);
                }
            }

            // agregar valores
            matriz2[0, 0] = 1;
            matriz2[0, 1] = 2;
            matriz2[1, 0] = 3;
            matriz2[1, 1] = 4;

            Console.WriteLine(matriz2);
        }
    }
}
