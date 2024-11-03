using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_2024.Ex3
{
    public class GuessTheNumber
    {   

        public int Start {  get; set; }
        public int End { get; set; }
        public bool Answered { get; set; } = false;

        public void Game(int start, int end)
        {
            this.Start = start;
            this.End = end;
            while (!Answered)
            {
                Guess();
            }
        }

        public void Guess()
        {
            int guess;
            guess = (Start + End) / 2;
            Console.WriteLine("Your number is {0} ?", guess);
            ShowMenu();
            int num = GetNum();
            if (num == 3) 
            {
                this.Answered = true;
            }
            else if (num == 1)
            {
                Start = guess;
            }
            else if (num == 2)
            {
                End = guess;
            }
        }
        public static int GetNum()
        {
            string str = Console.ReadLine();
            int.TryParse(str, out int num);
            if (num < 1 || num > 3)
            {
                Console.WriteLine("Enter a number from 1 to 3!!!");
                return GetNum();
            }
            return num;
        }

        public static void ShowMenu()
        {
            Console.WriteLine("1-Nope, bigger\n2-No, smaller\n3-Yes, that's it!");
        }
    }
    
}
