using System;

namespace TugasRPL
{
    class MateriWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MENU MATERI WHILE LOOP ===");
            Console.WriteLine("1. Program 6: Cetak Kalimat 5x");
            Console.WriteLine("2. Program 7: Angka Ganjil 1-9");
            Console.WriteLine("3. Program 8: Kurangi Angka 10-7");
            Console.WriteLine("4. Program 9: Input Loop (Ketik 0 Berhenti)");
            Console.WriteLine("5. Program 10: Kelipatan Kuadrat < 50");
            Console.Write("Pilih nomor program (1-5): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n[HASIL PROGRAM]:");

            if (pilihan == 1)
            {
                int i = 1;
                while (i <= 5)
                {
                    Console.WriteLine("Saya belajar C# ke-" + i);
                    i++;
                }
            }
            else if (pilihan == 2)
            {
                int i = 1;
                while (i <= 9)
                {
                    Console.WriteLine("Ganjil: " + i);
                    i += 2;
                }
            }
            else if (pilihan == 3)
            {
                int i = 10;
                while (i >= 7)
                {
                    Console.WriteLine("Angka saat ini: " + i);
                    i--;
                }
            }
            else if (pilihan == 4)
            {
                int angka = -1;
                while (angka != 0)
                {
                    Console.Write("Masukkan angka (Ketik 0 untuk berhenti): ");
                    angka = Convert.ToInt32(Console.ReadLine());
                }
            }
            else if (pilihan == 5)
            {
                int i = 1;
                while (i * i < 50)
                {
                    Console.WriteLine("Kuadrat dari " + i + " adalah " + (i * i));
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
            }

            Console.ReadLine();
        }
    }
}
