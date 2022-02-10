using System;
using static System.Console;

namespace Листинг_8._2
{

    //creating a new class
    class myClass
    {
        //creating a new public number variable
        public int number;
        //creating a constructor
        public myClass(int n)
        {
            //assigning the variables value to the argument of the constructor
            number = n;
        }
        //pre-defining a toString method
        public override String ToString()
        {
            //it returns text and the variable
            return "The number" + number;
        }
        //creating a operator with two objects as arguments
        //it is used to summate the number variable in each object
        public static myClass operator +(myClass a, myClass b)
        {
            //creating a number variable
            //assigning the variables value to the summation of the arguments
            //number field
            int m = a.number + b.number;
            //creating a new instance of the class
            //with the variable as an argument
            myClass t = new myClass(m);
            //returning the value 
            return t;
        }
        //creating a operator with two arguments
        //one as an object of the class
        //second as an number variable
        public static myClass operator +(myClass a, int x)
        {
            //creating a number variable
            //assigning the variables value to the summation of the two arguments
            int m = a.number + x;
            //return an object
            return new myClass(m);
        }
        //creating a operator with two arguments
        //one as an number variable
        //second as an object of the class
        public static myClass operator +(int x, myClass a)
        {
            //returning the summation of the two arguments
            return a + x;
        }
        //creating a operator with one argument
        //a new instance of the class
        public static int operator +(myClass a)
        {
            //return the number field of the object
            return a.number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating two instances
            myClass A = new myClass(100);
            myClass B = new myClass(200);

            //creating an instances
            //assinging its value to the summation of the first two objects number fields
            myClass C = A + B;
            //displaying each of the objects
            WriteLine(A);
            WriteLine(B);
            WriteLine(C);

            //assinging the value of the third objects field
            //using the + operator with an object and a number as arguments
            C = A + 1;
            //displaying the new object
            WriteLine(C);

            //assinging the value of the third objects field
            //using the + operator with a number filed and a object as arguments
            C = 10 + A;
            //displaying the new number field
            WriteLine(C);

            //using and using an object with + operator
            //with only an object as argument
            WriteLine("Унарен оператор: ");
            WriteLine(+C);
            //creating a number variable
            //assigning the variables value to the summation of the first two objects
            //the objects are being used with + operator with one argument
            int num = (+A) + (+B);
            //displaying the variable
            WriteLine("Сума на числата: {0}", num);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
