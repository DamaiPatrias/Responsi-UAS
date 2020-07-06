using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        Console.Write("\nKode Produk : "); string kodep = Console.ReadLine();
                        Console.Write("Nama Produk : "); string namap = Console.ReadLine();
                        Console.Write("Harga Beli : "); double hargab = double.Parse(Console.ReadLine());
                        Console.Write("Harga Jual : "); double hargaj = double.Parse(Console.ReadLine());
                        TambahProduk(kodep, namap, hargab, hargaj);
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Write("1. Tambah Produk \n2. Hapus Produk \n3. Tampilkan Produk \n4. Keluar");
        }

        static void TambahProduk(string kodep, string namap, double hargab, double hargaj)
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection
            daftarProduk.Add(new Produk { KodeP = kodep, NamaP = namap, HargaB = hargab, HargaJ = hargaj });

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection
            string kodehps;
            int hps = -1, n = -1;

            Console.WriteLine("Hapus Data");
            Console.Write("Kode Produk : "); kodehps = Console.ReadLine();

            foreach(Produk produk in daftarProduk)
            {
                n++;
                if(produk.KodeP == kodehps)
                {
                    hps = n;
                }
            }
            if(hps != -1)
            {
                daftarProduk.RemoveAt(hps);
            }
            else 
            {
                Console.WriteLine("\nKode Produk Tidak Ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection
            int urut1 = 1;
            foreach(Produk produk in daftarProduk)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}",
                    urut1, produk.KodeP, produk.NamaP, produk.HargaB, produk.HargaJ);
                urut1++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
