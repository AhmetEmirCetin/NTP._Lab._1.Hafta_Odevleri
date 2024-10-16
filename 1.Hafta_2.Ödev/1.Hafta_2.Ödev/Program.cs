using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hafta_2.Ödev
{
    class Program
    {
        static void Main()
        {
            Console.Write("N değerini girin: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[n, n];
            int[,] matrixB = new int[n, n];
            int[,] resultMatrix = new int[n, n];

            // İlk matrisi kullanıcıdan al
            Console.WriteLine("İlk matrisi girin:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matrixA[{i},{j}]: ");
                    matrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // İkinci matrisi kullanıcıdan al
            Console.WriteLine("İkinci matrisi girin:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matrixB[{i},{j}]: ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Matrisi çarpma işlemi
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            // Sonucu ekrana yazdır
            Console.WriteLine("Sonuç matrisi:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
