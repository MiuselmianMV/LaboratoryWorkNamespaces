using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_2024.Ex2
{
    internal class Square
    {
        public static void Draw(int side)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    if ((i == 0 && j == 0) || (i == 0 && j == side - 1))
                    {
                        Console.Write(" ");
                        continue;
                    }
                    if (i == side - 1 && (j == 0 || j == side - 1))
                    {
                        Console.Write("|");
                    }
                    else if (i == 0 || i == side - 1)
                    {
                        Console.Write("__");
                    }
                    else if (j == 0 || j == side - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
