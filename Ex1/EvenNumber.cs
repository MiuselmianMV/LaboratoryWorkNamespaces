using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_2024.Ex1
{
    public class EvenNumber
    {
        public static int[] CreateNumbers()
        {
            var rand = new Random();
            int[] temp = new int[10];
            for (int i = 0; i < 10; i++)
            {
                temp[i] = rand.Next(0, 100) * 2;
            }
            return temp;
        }
    }
}
