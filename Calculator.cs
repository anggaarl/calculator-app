using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }


        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            char pilihan;

            beranda:
            Console.WriteLine(" ========================================");
            Console.WriteLine(" 	   Program Kalkulator      	");
            Console.WriteLine(" ========================================");
            Console.WriteLine("\n");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" 	     Masukan Pilihan		");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" 					");
            Console.WriteLine(" (A) Penambahan  	");
            Console.WriteLine(" (B) Pengurangan		");
            Console.WriteLine(" (C) Perkalian		");
            Console.WriteLine(" (D) Pembagian 		");
            Console.WriteLine(" 					");
            Console.WriteLine(" ========================================");
            Console.Write(" Masukan Pilihan : ");
            pilihan = Convert.ToChar(Console.ReadLine());


            Console.WriteLine();

            if (pilihan == 'A') {
                Console.Write(" Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write(" Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine(" Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                Console.WriteLine();

                goto beranda;
            }
           

            else if (pilihan == 'B') {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                Console.WriteLine();

                goto beranda;

            }

            else if (pilihan == 'C') {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine()); 

                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                Console.WriteLine();

                goto beranda;
            }

            else if (pilihan == 'D') {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine()); 

                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                Console.WriteLine();

                goto beranda;
            }

            else {
                Console.Write("Maaf, pilihan tidak tersedia");
                Console.WriteLine();

                goto beranda;
            }

            Console.ReadKey();
        }
    }
}