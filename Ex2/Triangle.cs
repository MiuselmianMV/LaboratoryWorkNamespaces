using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_2024.Ex2
{
    internal class Triangle
    {
        public static void Draw(int height)
        {
           int num = 1;
           for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++) 
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < num; k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                num += 2;
            }


        }
    }
}
//   *
//  ***
// *****