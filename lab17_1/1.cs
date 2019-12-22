using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }

            int t = 0;
            b[t] = 1;
            c[t] = a[t];
            for (int i = 1; i < n; i++)
            {
                if (a[i - 1] == a[i])
                {
                    b[t]++;
                }
                else
                {
                    t++;
                    b[t] = 1;
                    c[t] = a[i];
                }
            }

            for (int i = 0; i <= t; i++)
            {
                Write(b[i] + " ");
            }
            WriteLine();
            for (int i = 0; i <= t; i++)
            {
                Write(c[i] + " ");
            }
        }
    }
}
