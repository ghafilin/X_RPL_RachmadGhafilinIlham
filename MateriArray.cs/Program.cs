using System;

namespace TugasRPL
{
    class MateriArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MENU MATERI ARRAY ===");
            Console.WriteLine("1. Program 21: Cek Index Array Hari");
            Console.WriteLine("2. Program 22: Mengubah Isi Data Array");
            Console.WriteLine("3. Program 23: Cek Panjang Array (.Length)");
            Console.WriteLine("4. Program 24: Tampilkan Array dengan For");
            Console.WriteLine("5. Program 25: Cari Nilai Tertinggi Array");
            Console.Write("Pilih nomor program (1-5): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n[HASIL PROGRAM]:");

            if (pilihan == 1)
            {
                string[] hari = { "Senin", "Selasa", "Rabu" };
                Console.WriteLine("Hari indeks ke-0 adalah: " + hari[0]);
                Console.WriteLine("Hari indeks ke-2 adalah: " + hari[2]);
            }
            else if (pilihan == 2)
            {
                int[] data = { 100, 200, 300 };
                Console.WriteLine("Data awal indeks ke-1: " + data[1]);
                data[1] = 999;
                Console.WriteLine("Data baru setelah diubah: " + data[1]);
            }
            else if (pilihan == 3)
            {
                string[] kota = { "Sidoarjo", "Surabaya", "Malang", "Gresik" };
                int ukuran = kota.Length;
                Console.WriteLine("Total kapasitas jumlah kota: " + ukuran);
            }
            else if (pilihan == 4)
            {
                string[] siswa = { "Andi", "Budi", "Citra" };
                for (int i = 0; i < siswa.Length; i++)
                {
                    Console.WriteLine("Siswa indeks ke-" + i + " bernama: " + siswa[i]);
                }
            }
            else if (pilihan == 5)
            {
                int[] angka = { 12, 45, 78, 34 };
                int tertinggi = angka[0];
                for (int i = 1; i < angka.Length; i++)
                {
                    if (angka[i] > tertinggi)
                    {
                        tertinggi = angka[i];
                    }
                }
                Console.WriteLine("Angka terbesar di array adalah: " + tertinggi);
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
            }

            Console.ReadLine();
        }
    }
}
