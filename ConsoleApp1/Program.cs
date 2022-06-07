using System;
using System.Collections.Generic;
using System.Linq;

namespace buyuktenKucuge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int sayi = 0;
                Console.WriteLine($"{i + 1}. Sayıyı Giriniz:");
                if (!int.TryParse(Console.ReadLine(), out sayi))
                    throw new Exception("Lütfen Sayı Giriniz");
                arr.Add(sayi);
            }

            var desc = arr.OrderByDescending(f => f).ToList();
            foreach (var item in desc)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
