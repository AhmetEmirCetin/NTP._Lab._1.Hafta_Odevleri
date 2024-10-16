using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hafta_3.Ödev
{
    class Program
    {
        static void Main()
        {
            // Kullanıcıdan bir N sayısı girmesini istiyoruz
            Console.Write("Bir N sayısı girin: ");
            int n = int.Parse(Console.ReadLine()); // Kullanıcının girdiği değeri N olarak alıyoruz

            int toplam = 0; // Asal sayıların toplamını tutacak değişkeni tanımlıyoruz

            // 2'den N'e kadar olan sayıları kontrol ediyoruz
            for (int i = 2; i <= n; i++)
            {
                // Eğer sayı asal ise
                if (IsAsal(i))
                {
                    toplam += i; // Asal sayıyı toplam değişkenine ekliyoruz
                }
            }

            // Hesaplanan asal sayıların toplamını ekrana yazdırıyoruz
            Console.WriteLine($"0 ile {n} arasındaki asal sayıların toplamı: {toplam}");
            Console.ReadKey();
        }

        // Sayının asal olup olmadığını kontrol eden yöntem
        static bool IsAsal(int sayi)
        {
            // Asal sayıların tanımına göre, asal sayılar 2 ve üzerindeki sayılardır
            if (sayi < 2) return false;

            // Sayının kareköküne kadar olan sayıları kontrol ediyoruz
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                // Eğer sayi, i'ye tam bölünüyorsa asal değildir
                if (sayi % i == 0)
                {
                    return false; // Asal değil
                }
            }
            return true; // Asal
        }
    }
}
