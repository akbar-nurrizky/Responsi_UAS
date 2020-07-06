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
                        TambahProduk();
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
            Console.WriteLine("Pilih Menu");
            Console.Write("1. Tambah Produk \n2. Hapus Produk \n3. Tampilkan Produk \n4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection
            Produk produk = new Produk();
            daftarProduk.Add(produk);
            Console.WriteLine();
           
            Console.WriteLine("Tambah Data Produk");
            Console.WriteLine();

            Console.Write("Kode Produk: ");
            produk.Kode = Console.ReadLine();
            Console.Write("Nama Produk: ");
            produk.Nama = Console.ReadLine();
            Console.Write("Harga Beli : ");
            produk.Beli = int.Parse(Console.ReadLine());
            Console.Write("Harga Jual : ");
            produk.Jual = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection
            string kodehps;
            int hps = -1, n = -1;

            Console.WriteLine("Mengapus Data");
            Console.Write("Kode Produk : "); 
            kodehps = Console.ReadLine();

            foreach (Produk produk in daftarProduk)
            {
                n++;
                if (produk.Kode == kodehps)
                {
                    hps = n;
                }
            }
            if (hps != -1)
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
            int i = 1;
            foreach (Produk produk in daftarProduk)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}",
                i, produk.Kode, produk.Nama, produk.Beli, produk.Jual);
                i++;
            }
            if(i < 1)
            {
                Console.Write("Empty");
            }
            else
            {
                Console.Write("\tEmpty");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
