using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_2024.Ex2
{
    public class Rectangle
    {
        public static void Draw(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i == 0 && j == 0 )|| (i == 0 && j == width - 1))
                    {
                        Console.Write(" ");
                        continue;
                    }
                    if (i == height - 1 && (j == 0 || j == width - 1))
                    {
                        Console.Write("|");
                    }
                    else if (i == 0 || i == height - 1)
                    {
                        Console.Write("_");
                    }
                    else if (j == 0 || j == width - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
