using System;
using System.Collections.Generic;

namespace AppKantor
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] namaKaryawan =
            {
                "Adi Sucipto",
                "Bernardo",
                "Halim Kusuma",
                "Giri Atma Santana"
            };
            int[] gajiKaryawan = new int[] { 1000000, 2500000, 375000000, 1000000000 };
            
            Program.ReportDisplay(namaKaryawan, gajiKaryawan);
            
        }
        static int SumSalary(int[] arrSalary)
        {
            int tempValue = 0;
            for (int i = 0; i < arrSalary.Length; i++)
            {
                tempValue = tempValue + arrSalary[i];
            }
            return tempValue;

        }

        static int AverageSalary(int[] arrSalary)
        {
            int tempValue = 0;
            for (int i = 0; i < arrSalary.Length; i++)
            {
                tempValue = tempValue + arrSalary[i];
            }
            return tempValue/ arrSalary.Length;

        }


        static void ReportDisplay(string[] nama, int[] gaji)
        {
            int lengthData = nama.Length;
            if (nama.Length != gaji.Length)
            {
                Console.Write("EROR : Panjang daftar tidak sesuai !");
                return;
            }

            Console.WriteLine("{0,-20}    {1, 6}", "Nama", "Total Gaji");
            for (int x = 0; x < lengthData; x++)
            {
                Console.WriteLine("{0,-20} Rp {1, 6}", nama[x], gaji[x]);
            }
            Console.WriteLine($"Sum of salary on this list is : Rp.{Program.SumSalary(gaji)}");
            Console.WriteLine($"Average of salary on this list is : Rp.{Program.AverageSalary(gaji)}");

        }
    }
}
