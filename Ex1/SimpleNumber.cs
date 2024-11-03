using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_2024.Ex1
{
    public class SimpleNumber
    {
        public static int[] CreateNumbers()
        {
            int[] temp = new int[10];
            int counter = 0;
            int i = 1;
            while (counter < 10)
            {
                if (IsSimple(i))
                {
                    temp[counter] = i;
                    counter++;
                }
                i++;
            }
            return temp;
        }

        public static bool IsSimple(int number)
        {
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
