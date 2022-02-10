using System;
using static System.Console;

namespace Листинг_8._1
{
    //creating a new class
    class myClass
    {
        //creating a new public number variable
        public int numbers;
        //creating a constructor
        public myClass(int n)
        {
            //setting the number variables value
            numbers = n;
        }
        //creating an operator with two arguments
        public static int operator +(myClass a, myClass b)
        {
            //creating a int variable and assinging its value
            //to the summation of the two objects variables
            int m = a.numbers + b.numbers;
            //return the value of the variable
            return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating the two instances
            myClass A = new myClass(100);
            myClass B = new myClass(200);

            //creating a number variable
            int num;
            //assinging its value to the summation of the objects
            //using the operator we created
            num = A + B;
            //displaying the summation
            WriteLine("A + B = {0}", num);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
