using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab17_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());
            Write("Введите число К: ");
            k = int.Parse(ReadLine());

            int[] a = new int[40];
            int[] b = new int[40];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }

            int nomerserii = 0, ind1 = 0, ind2 = 0, razmer = 0;
            k--;
            for (int i = 1; i < n; i++)
            {
                if (a[i - 1] != a[i])
                {
                    nomerserii++;
                    if (nomerserii == k)
                    {
                        ind1 = i; // индекс начала серии
                    }
                    ind2 = i; // index konca
                }
                if (nomerserii == k)
                {
                    razmer++;
                }
            }

            int c = -1;

            for (int i = 0; i < ind1; i++)
            {
                c++;
                b[c] = a[i];
            }
            for (int i = ind2; i < n; i++)
            {
                c++;
                b[c] = a[i];
            }
            for (int i = ind1 + razmer; i < ind2; i++)
            {
                c++;
                b[c] = a[i];
            }
            for (int i = ind1; i < ind1 + razmer; i++)
            {
                c++;
                b[c] = a[i];
            }


            for (int i = 0; i < n; i++)
            {
                Write(b[i] + " ");
            }
        }
    }
}
