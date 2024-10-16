using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hafta_1.Ödev
{
    class Program
    {
        static void Main()
        {
            Console.Write("Matrisin boyutunu girin (N): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int value = 1;

            // Spiral matrisi doldurmak için kenar sınırları
            int left = 0, right = n - 1, top = 0, bottom = n - 1;

            while (value <= n * n)
            {
                // Yukarıdan sağa doğru
                for (int i = left; i <= right; i++)
                    matrix[top, i] = value++;
                top++;

                // Sağdan aşağıya
                for (int i = top; i <= bottom; i++)
                    matrix[i, right] = value++;
                right--;

                // Aşağıdan sola
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                        matrix[bottom, i] = value++;
                    bottom--;
                }

                // Soldan yukarı
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                        matrix[i, left] = value++;
                    left++;
                }
            }

            // Matrisi yazdırma
            Console.WriteLine("Spiral Matris:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine(); // Her satırdan sonra yeni bir satıra geçer
            }
            Console.Read();
        }
    }
}



