using System;

namespace MyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMaths myMath = new MyMaths();
            int i = 0;
            while (i < 15)
            {
                Console.WriteLine($"{myMath.Sin(1)}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
