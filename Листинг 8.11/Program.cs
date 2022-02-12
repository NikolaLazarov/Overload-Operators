using System;
using static System.Console;

namespace Листинг_8._11
{
    //creating new class
    class myClass
    {
        //creating new class number variable
        public int code;
        //creating new constructor with one argument
        public myClass(int code)
        {
            //assinging the variables value to the arguments
            this.code = code;
        }
        //creating new operator with two class object as arguments
        public static myClass operator +(myClass a, myClass b)
        {
            //creating new class object
            //with the summation of the objects number fields as an argument
            return new myClass(a.code + b.code);
        }
        //creating new operator with two class object as arguments
        public static int operator *(myClass a, myClass b)
        {

            //returning the multiplication of the two objects number fields
            return a.code * b.code;
        }
        //creating new operator with a number variable as argument
        //converts int to myClass
        public static implicit operator myClass(int n)
        {
            //returning a new class object
            return new myClass(n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating new class object
            myClass A = new myClass(7);
            //displaying the objects number field
            WriteLine("Обект А: {0}", A.code);

            //creating new class object
            myClass B = new myClass(8);
            //displaying the objects number field
            WriteLine("Обект B: {0}", B.code);

            //adding the value of the second objects number field to the first object
            A += B;
            //displaying the objects number field
            WriteLine("Обект А: {0}", A.code);

            //multiplying the value of the first objects number field to the second
            A *= B;
            //displaying the objects number field
            WriteLine("Обект А: {0}", A.code);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
