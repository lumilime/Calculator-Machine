﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcultaorMachine;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // casting

            Console.Write("Inputkan nilai b = ");
            var b = Convert.ToInt32(Console.ReadLine()); // casting
            //membuat objek Calculator menggunakan keyword var
            var cal = new Calculator();

            Console.WriteLine(); // tambahkan baris kosong
            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b,cal.Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian: {0} x {1} = {2}", a, b, cal.Perkalian(a, b));
            Console.WriteLine("Hasil pangkat: {0} ^ {1} ={2}", a, b,cal.Pangkat(a, b));
            Console.WriteLine("Hasil Modulo: {0} % {1} = {2}", a, b,Calculator.Modulo(a, b));


            //khusus metod Pembagian dipanggil langsung dari class calculator
            // karena merupakan method static
            Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b));


            Console.ReadKey();
        }

       
    }
}
