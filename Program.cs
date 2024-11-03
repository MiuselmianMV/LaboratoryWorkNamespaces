using _03_11_2024.Ex1;
using _03_11_2024.Ex2;
using _03_11_2024.Ex3;
using _03_11_2024.Ex4;

namespace Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
        }

        public static void Ex1()
        {
            int[] fib = FibonacciNumber.CreateNumbers();
            int[] simp = SimpleNumber.CreateNumbers();
            int[] even = EvenNumber.CreateNumbers();
            int[] odd = OddNumber.CreateNumbers();
            Console.Write("Fibonacci numbers: ");
            Show(fib);
            Console.Write("Simple numbers: ");
            Show(simp);
            Console.Write("Even numbers: ");
            Show(even);
            Console.Write("Odd numbers: ");
            Show(odd);
        }
        public static void Ex2()
        {
            Rectangle.Draw(2, 10);
            Square.Draw(10);
            Triangle.Draw(10);
        }
        public static void Ex3()
        {
            var game = new GuessTheNumber();
            game.Game(0, 100);
            Console.WriteLine("Congratulations!!!");
        }
        public static void Ex4()
        {
            var generator = new PseudoTextGen();
            generator.Generate();
        }

        public static void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
    }

}
