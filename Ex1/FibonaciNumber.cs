using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_2024.Ex1
{
    public class FibonacciNumber
    {
        public static int[] CreateNumbers()
        {
            int[] temp = new int[10];
            int a = 0, b = 1;
            for (int i = 0; i < 10; i++)
            {
                temp[i] = a;
                int c = a;
                a = b;
                b += c;
            }
            return temp;
        }
    }
}
