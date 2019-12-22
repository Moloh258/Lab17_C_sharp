using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab17_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Write("Введите количество точек: ");
            n = int.Parse(ReadLine());

            int[,] a = new int[10, 2];

            for (int i = 0; i < n; i++)
            {
                Write("A{0}: ", i);
                Write("X = ");
                a[i, 0] = int.Parse(ReadLine());
                Write("Y = ");
                a[i, 1] = int.Parse(ReadLine());
            }

            int k1 = 0, k2 = 0, k3 = 0;
            double maxk = 0, k;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int q = j + 1; q < n; q++)
                    {
                        k = 0;
                        k += Math.Sqrt(Math.Pow(a[i, 0] - a[j, 0], 2) + Math.Pow(a[i, 1] - a[j, 1], 2));
                        k += Math.Sqrt(Math.Pow(a[i, 0] - a[q, 0], 2) + Math.Pow(a[i, 1] - a[q, 1], 2));
                        k += Math.Sqrt(Math.Pow(a[j, 0] - a[q, 0], 2) + Math.Pow(a[j, 1] - a[q, 1], 2));
                        if (k > maxk)
                        {
                            k1 = i;
                            k2 = j;
                            k3 = q;
                            maxk = k;
                        }
                    }
                }
            }

            WriteLine("P: {0}", maxk);
            WriteLine("A{0} : x = {1} y = {2}", k1, a[k1, 0], a[k1, 1]);
            WriteLine("A{0} : x = {1} y = {2}", k2, a[k2, 0], a[k2, 1]);
            WriteLine("A{0} : x = {1} y = {2}", k3, a[k3, 0], a[k3, 1]);

        }
    }
}
