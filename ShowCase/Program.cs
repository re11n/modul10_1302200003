using MatematikaLibraries;
using System.Diagnostics.Metrics;
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hasil FPB: " + UtilityLibraries.FPB(60, 45));

        Console.WriteLine("Hasil KPK: " + UtilityLibraries.KPK(12, 8));

        int[] turun = { 1, 4, -12, 9 };
        Console.WriteLine("Hasil Turunan: " + UtilityLibraries.Turunan(turun));

        int[] integ = {4,6, -12, 9};
        Console.WriteLine("Hasil Integral: " + UtilityLibraries.Integral(integ));
    }
}
