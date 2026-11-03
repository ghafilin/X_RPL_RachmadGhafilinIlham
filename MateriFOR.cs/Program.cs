using System;

namespace TugasRPL
{
    class MateriFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MENU MATERI FOR LOOP ===");
            Console.WriteLine("1. Program 1: Angka 1-5");
            Console.WriteLine("2. Program 2: Angka Genap 2-10");
            Console.WriteLine("3. Program 3: Hitung Mundur 5-1");
            Console.WriteLine("4. Program 4: Kelipatan 5");
            Console.WriteLine("5. Program 5: Total Penjumlahan 1-5");
            Console.Write("Pilih nomor program (1-5): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n[HASIL PROGRAM]:");

            if (pilihan == 1)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Angka: " + i);
                }
            }
            else if (pilihan == 2)
            {
                for (int i = 2; i <= 10; i += 2)
                {
                    Console.WriteLine("Genap: " + i);
                }
            }
            else if (pilihan == 3)
            {
                for (int i = 5; i >= 1; i--)
                {
                    Console.WriteLine("Mundur: " + i);
                }
            }
            else if (pilihan == 4)
            {
                for (int i = 5; i <= 25; i += 5)
                {
                    Console.WriteLine("Kelipatan: " + i);
                }
            }
            else if (pilihan == 5)
            {
                int total = 0;
                for (int i = 1; i <= 5; i++)
                {
                    total = total + i;
                }
                Console.WriteLine("Total hasil 1+2+3+4+5 = " + total);
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
            }

            Console.ReadLine();
        }
    }
}
