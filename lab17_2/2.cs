using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, l;
            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());

            Write("Введите число L: ");
            l = int.Parse(ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }

            int k;
            l--;
            for (int i = 0; i < n; i++)
            {
                k = 0;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] == a[i])
                    {
                        k++;
                    }
                    else break;
                }

                if (k >= l)
                {
                    i = i + k;
                    Write("0 ");
                }

                if (k < l)
                {
                    Write(a[i] + " ");
                }
            }
        }
    }
}
