using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace params_out_exp
{
    class Program
    {
        static int[] LSS(out int ecount, params int[] v)
        {
            Array.Sort(v);
            int[] res = new int[3];
            res[0] = v[0];      // smallest
            res[1] = v[v.Length - 1];   // largest
            int s = 0, c = 0;

            for (int i = 0; i < v.Length; i++)
            {
                s = s + v[i];
                if (v[i] % 2 == 0) c++;
            }

            ecount = c; // final result assigned to "out" argument type

            res[2] = s;             // sum of array elements

            return res;
        }

        static void Main(string[] args)
        {
            int cnt;
            int[] results = LSS(out cnt, 10, 45, 7, 3, 7, 190, 6, 234, 789, 52);
            Console.WriteLine("Largest = {0}", results[1]);
            Console.WriteLine("Smallest = {0}", results[0]);
            Console.WriteLine("Sum = {0}", results[2]);
            Console.WriteLine("Count of even = {0}", cnt);
        }
    }
}
