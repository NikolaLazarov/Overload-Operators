using System;
using static System.Console;

namespace Задача_1
{
    class myClass
    {
        public char symbol;
        public myClass(char symbol)
        {
            this.symbol = symbol;
        }
        public override string ToString()
        {
            string text = "The character: " + symbol;
            return text;
        }
        public static myClass operator ++(myClass a)
        {
            a.symbol++;
            return a;
        }
        public static myClass operator --(myClass a)
        {
            a.symbol--;
            return a;
        }
        public static myClass operator +(myClass a, int b)
        {
            int n = (int)a.symbol + b;
            return new myClass((char)n);
        }
        public static int operator +(int b, myClass a)
        {
            return (int)a.symbol + b;
        }
        public static myClass operator -(myClass a, int b)
        {
            int n = (int)a.symbol - b;
            return new myClass((char)n);
        }
        public static int operator -(int b, myClass a)
        {
            return (int)a.symbol - b;
        }

        class Program
        {
            static void Main(string[] args)
            {
                myClass A = new myClass('G');

                WriteLine(A++);
                WriteLine(A--);
                WriteLine(A + 2);
                WriteLine(A - 2);
                WriteLine(2 + A);
                WriteLine(2 - A);

                WriteLine("Press any key to class...");
                ReadKey(true);
            }
        }
    }
}