using System;
namespace MatematikaLibraries
{
    public static class UtilityLibraries
    {
        public static int FPB(int input1, int input2)
        {
            int result = input1 % input2;
            while (result != 0)
            {
                input1 = input2;
                input2 = result;
                result = input1 % input2;
            }
            return input2;
        }

        public static int KPK(int input1, int input2)
        {
            return (input1 * input2) / FPB(input1,input2);
        }

        public static string Turunan(int[] persamaan)
        {
            int n = persamaan.Length - 1;
            int[] turun = new int[n];
            for(int i=1; i < n; i++)
            {
                turun[i] = persamaan[i] * (n - i);
            }

            string result = turun[0] + "x^" + (n - 1);

            for(int i = 1; i < n; i++)
            {
                if (turun[i] > 0)
                {
                    result = result + "+" + turun[i] + "x" + (n-i-1);
                } else if (turun[i] <0)
                {
                    result = result + "-" + (-turun[i]) + "x" + (n-i-1);
                }
            }
            return result;
        }

        public static string Integral(int[] persamaan)
        {
            int n = persamaan.Length;
            int[] integral = new int[n + 1];
            for (int i = 1; i < n; i++)
            {
                integral[i] = persamaan[i - 1] / i;
            }
            string result = "C";
            for(int i=n;i>=0;i--)
            {
                if (integral[i] > 0)
                {
                    result = "+" + integral[i] + "x" + (i + 1) + result;
                } else if (integral[i] < 0)
                {
                    result = integral[i] + "x^" + (i+1) + result;
                }
            }
            return result;
        }
    }
}