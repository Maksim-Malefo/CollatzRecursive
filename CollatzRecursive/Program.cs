using System;

namespace CollatzRecursive
{
    class Program
    {
        public static int ColRec(int x)
        {
            Console.WriteLine("X = " + x);
            if (x <= 1)
                return x;
            else if (x % 2 == 0)
                return ColRec(x / 2);
            else if (x % 2 != 0)
                return ColRec((x * 3) + 1);
            return x;
        }
        static void Main(string[] args)
        {
            int x;
            while(true)
            {
                string Exit;
                Console.WriteLine("This is Collatz hypothesis.");
                Console.WriteLine("Start(press any key) or Exit(press Q)?");
                Exit = Console.ReadLine();
                if (Exit == "Q" || Exit == "q")
                    break;
                else
                {
                    Console.Write("Enter any number: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    ColRec(x);
                }
                
            }
        }
    }
}
