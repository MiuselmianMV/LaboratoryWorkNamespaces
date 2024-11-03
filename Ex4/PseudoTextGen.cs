using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_2024.Ex4
{
    public class PseudoTextGen
    {
        public string[] Vowels { get; set; } = ["a", "e", "u", "i", "o"];
        public int NumOfVowels { get; set; } = 0;
        public string[] Consonants { get; set; } = ["b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z"];
        public int NumOfCons { get; set; } = 0;
        public int MaxLength { get; set; } = 0;

        public  void Generate()
        {
            TakeInfo();

            var rand = new Random();
            int lettersAvail = NumOfCons + NumOfVowels;
            while (lettersAvail > 0)
            {
                int wordLength = rand.Next(0, MaxLength);
                
                if (wordLength > lettersAvail)
                    wordLength = lettersAvail;

                for (int i = 0; i < wordLength; i++)
                {
                    if (i % 2 == 0 && NumOfVowels > 0)
                    {
                        Console.Write(Vowels[rand.Next(Vowels.Length)]);
                        NumOfVowels--;
                    }
                    else if (i % 2 == 1 && NumOfCons > 0)
                    {
                        Console.Write(Consonants[rand.Next(Consonants.Length)]);
                        NumOfCons--;
                    }
                    else if (NumOfCons == 0)
                    {
                        Console.Write(Vowels[rand.Next(Vowels.Length)]);
                        NumOfVowels--;
                    }
                    else if (NumOfVowels == 0)
                    {
                        Console.Write(Consonants[rand.Next(Consonants.Length)]);
                        NumOfCons--;
                    }
                }
                Console.Write(" ");
                lettersAvail -= wordLength;
            }
        }
        public void TakeInfo()
        {
            TakeConsNum();
            TakeVowelsNum();
            TakeMaxLength();
        }

        public void TakeConsNum()
        {
            Console.WriteLine("Enter number of consonants: ");
            string str = Console.ReadLine();
            int.TryParse(str, out int n);
            this.NumOfCons = n;
        }
        public void TakeVowelsNum()
        {
            Console.WriteLine("Enter number of vowels: ");
            string str = Console.ReadLine();
            int.TryParse(str, out int n);
            this.NumOfVowels = n;
        }
        public void TakeMaxLength()
        {
            Console.WriteLine("Enter max length of the word: ");
            string str = Console.ReadLine();
            int.TryParse(str, out int n);
            this.MaxLength = n;
        }

    }
}
