using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE DOIS NÚMEROS INTEIROS:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];
            Console.WriteLine("DIGITE OS NÚMEROS DA MATRIZ: ");
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("MATRIZ:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Digite algum número da matriz: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == num)
                    {
                        Console.WriteLine($"Posição: {i},{j} ");
                        if (matriz[i, j - 1] != 0)
                        {
                            Console.WriteLine($"Esquerda: {matriz[i, j - 1]}");
                        }

                        if (matriz[i, j + 1] != 0)
                        {
                            Console.WriteLine($"Direita: {matriz[i, j + 1]}");
                        }

                        if (matriz[i - 1, j] != 0)
                        {
                            Console.WriteLine($"Cima: {matriz[i - 1, j]}");
                        }

                        if (matriz[i + 1, j] != 0)
                        {
                            Console.WriteLine($"Baixo: {matriz[i + 1, j]}");
                        }
                    }
                }
            }




        }
    }
}
