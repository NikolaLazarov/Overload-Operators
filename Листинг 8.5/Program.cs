// See https://aka.ms/new-console-template for more information
using static System.Console;
//creating a new class
class myClass
{
    //creating a new number variable
    public int code;
    //creating a constructor with one argument
    public myClass(int n)
    {
        //assigning the original variables value to the arguments
        code = n;
    }
    //creating a operator with two arguments
    //both are instances of myClass
    public static myClass operator <=(myClass a, myClass b)
    {
        //if the first is lower or equal in value, then the second, return a;
        if (a.code <= b.code) return a;
        //else return b;
        else return b;
    }
    //creating a operator with two arguments
    //both are instances of myClass
    public static myClass operator >=(myClass a, myClass b)
    {
        //if the first is higher or equal in value, then the second, return a;
        if (a.code >= b.code) return a;
        //else return b;
        else return b;
    }
    //creating a operator with two arguments
    //one is an instance of myClass
    //the other is a number variable
    public static bool operator <=(myClass a, int x)
    {
        //if the first is lower or equal in value, then the second - 1,return true
        if (a.code <= x - 1) return true;
        //else return false
        else return false;
    }
    //creating a operator with two arguments
    //one is an instance of myClass
    //the other is a number variable
    public static bool operator >=(myClass a, int x)
    {
        //if the first is higher or equal in value, then the second + 1,return true
        if (a.code >= x + 1) return true;
        //else return false
        else return false;
    }
    //creating a operator with two arguments
    //both are instances of myClass
    public static bool operator <(myClass a, myClass b)
    {
        //return the result of the comparison
        return a.code < b.code;
    }
    //creating a operator with two arguments
    //both are instances of myClass
    public static bool operator >(myClass a, myClass b)
    {
        //return the result of the comparison
        return a.code > b.code;
    }
    //creating a operator with two arguments
    //one is an instance of myClass
    //the other is a number variable
    public static int operator <(myClass a, int x)
    {
        //return the result of the subtraction
        return x - a.code;
    }
    //creating a operator with two arguments
    //one is an instance of myClass
    //the other is a number variable
    public static int operator >(myClass a, int x)
    {
        //return the result of the subtraction
        return a.code - x;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating two instances of myClass
        myClass A = new myClass(100);
        myClass B = new myClass(200);

        //displaying the objects
        WriteLine("Обект А: {0}", A.code);
        WriteLine("Обект B: {0}", B.code);

        //displaying the comparisons between A and B
        WriteLine("A<B дава: {0}", A < B);
        WriteLine("A>B дава: {0}", A > B);

        //creating a new myClass variable
        myClass C;
        //assigning its value to the result of the comparison as a reference
        C = A >= B;
        //assigning the objects value
        //it assigning the value of the reference too
        C.code = 300;
        //displaying the object
        WriteLine("Обект B: {0}", B.code);

        //assigning the value of the class variable to the result of the comparison
        //as a reference
        C = A <= B;
        //assigning the objects value
        //it assigning the value of the reference too
        C.code = 150;
        //displaying the object
        WriteLine("Обект А: {0}", A.code);

        //assigning the value of the result of the comparison
        (A <= B).code = 500;
        //displaying the object
        WriteLine("Обект А: {0}", A.code);

        //creating three number variable
        int x = 400, y = 500, z = 600;

        //comparing them with A
        //with different operators
        WriteLine("A<={0} дава {1}", x, A <= x);
        WriteLine("A>={0} дава {1}", x, A >= x);
        WriteLine("A<={0} дава {1}", y, A <= y);
        WriteLine("A>={0} дава {1}", y, A >= y);
        WriteLine("A<={0} дава {1}", z, A <= z);
        WriteLine("A>={0} дава {1}", z, A >= z);
        WriteLine("A<{0} дава {1}", z, A < z);
        WriteLine("A>{0} дава {1}", x, A > x);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
