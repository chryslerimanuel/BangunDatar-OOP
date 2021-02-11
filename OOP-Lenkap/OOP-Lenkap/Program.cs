using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lenkap
{
    class Program
    {
        static string ulang = "";

        public static string UlangMenu()
        {
            Console.Write("Ulang lagi? Y/N    ");
            ulang = Console.ReadLine();
            Console.WriteLine();
            return ulang;
        }

        public static void MenuPersegi()
        {
            Persegi persegi = new Persegi();
            Console.Write("Masukan sisi persegi = ");
            int sisi = Convert.ToInt32(Console.ReadLine());
            persegi.HitungPersegi(sisi, sisi, sisi, sisi);
            persegi.HitungPersegi(sisi, sisi);

            Console.WriteLine();

            persegi.Keliling();
            persegi.Luas();
            Console.WriteLine();

            UlangMenu();
        }

        public static void MenuPersegiPanjang()
        {
            PersegiPanjang pp = new PersegiPanjang();

            Console.Write("Masukan panjang persegi panjang = ");
            int panjang = Convert.ToInt32(Console.ReadLine());
            pp.Panjang = panjang;

            Console.Write("Masukan lebar persegi panjang = ");
            int lebar = Convert.ToInt32(Console.ReadLine());
            pp.Lebar = lebar;

            pp.HitungKelPersegiPanjang();
            pp.HitungLuasPersegiPanjang();

            Console.WriteLine();
            pp.Keliling();
            pp.Luas();
            Console.WriteLine();

            UlangMenu();
        }

        public static void MenuLingkaran()
        {
            Lingkaran lingkaran = new Lingkaran();

            Console.Write("Masukan jari-jari lingkaran = ");
            int jari2 = Convert.ToInt32(Console.ReadLine());
            lingkaran.Jari2 = jari2;

            Console.WriteLine();
            lingkaran.Keliling();
            lingkaran.Luas();
            Console.WriteLine();

            UlangMenu();
        }

        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Aplikasi hitung luas & keliling");
                    Console.WriteLine("Menu: \n" +
                        "1. Persegi \n" +
                        "2. Persegi Panjang \n" +
                        "3. Lingkaran \n" +
                        "Masukan pilihan anda (1-3)");
                    int menu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (menu)
                    {
                        case 1:
                            MenuPersegi();
                            break;
                        case 2:
                            MenuPersegiPanjang();
                            break;
                        case 3:
                            MenuLingkaran();
                            break;
                        default:
                            Console.WriteLine("Menu yang anda pilih tidak tersedia");
                            break;
                    }

                } while (ulang == "Y" || ulang == "y");

                 Console.WriteLine("Keluar dari aplikasi... \n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nTerjadi Kesalahan");
                Console.WriteLine("Keluar dari aplikasi... \n");
            }
        }
    }
}
