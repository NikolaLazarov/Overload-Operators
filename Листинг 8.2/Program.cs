using System;
using static System.Console;

namespace Листинг_8._2
{
    class myClass
    {
        public int number;
        public myClass(int n)
        {
            number = n;
        }
        public override String ToString()
        {
            return "Поле number: " + number;
        }
        public static myClass operator +(myClass a, myClass b)
        {
            int m = a.number + b.number;
            myClass t = new myClass(m);
            return t;
        }
        public static myClass operator +(myClass a, int x)
        {
            int m = a.number + x;
            return new myClass(m);
        }
        public static myClass operator +(int x, myClass a)
        {
            return a + x;
        }
        public static int operator +(myClass a)
        {
            return a.number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass A = new myClass(100);
            myClass B = new myClass(200);

            myClass C = A + B;
            WriteLine(A);
            WriteLine(B);
            WriteLine(C);

            C = A + 1;
            WriteLine(C);

            C = 10 + A;
            WriteLine(C);

            WriteLine("Унарен оператор: ");
            WriteLine(+C);
            int num = (+A) + (+B);
            WriteLine("Сума на числата: {0}", num);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
