using MatematikaLibraries;
using System.Diagnostics.Metrics;
using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Masukkan angka pertama: ");
        int input1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Masukkan angka kedua: ");
        int input2 = int.Parse(Console.ReadLine());

        int fpb1 = UtilityLibraries.FPB(input1, input2);*/

        Console.WriteLine("Hasil FPB: " + UtilityLibraries.FPB(60, 45));

        /*Console.WriteLine("Masukkan angka pertama: ");
        input1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Masukkan angka kedua: ");
        input2 = int.Parse(Console.ReadLine());

        int kpk1 = UtilityLibraries.KPK(input1, input2);*/

        Console.WriteLine("Hasil KPK: " + UtilityLibraries.KPK(12, 8));
        int[] turun = { 1, 4, -12, 9 };
        Console.WriteLine("Hasil Turunan: " + UtilityLibraries.Turunan(turun));
        int[] integ = {4,6, -12, 9};
        Console.WriteLine("Hasil Integral: " + UtilityLibraries.Integral(integ));
    }
}
