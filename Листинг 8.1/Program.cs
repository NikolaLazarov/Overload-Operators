using System;
using static System.Console;

namespace Листинг_8._1
{
    class myClass
    {
        public int numbers;
        public myClass(int n)
        {
            numbers = n;
        }
        public static int operator +(myClass a, myClass b)
        {
            int m = a.numbers + b.numbers;
            return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass A = new myClass(100);
            myClass B = new myClass(200);

            int num;
            num = A + B;
            WriteLine("A + B = {0}", num);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
