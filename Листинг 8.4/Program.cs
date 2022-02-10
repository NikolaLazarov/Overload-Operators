using static System.Console;
//creating a new class
class myClass
{
    //creating a new character variables
    public char symb;
    //creating a constructor with a character variable as argument
    public myClass(char s)
    {
        //assigning the original variables value to the arguments value
        symb = s;
    }
    //creating a operator with two arguments
    //both are instances of the symbol field
    public static bool operator <=(myClass a, myClass b)
    {
        //if the first char filed is lower by value then the second
        //return true
        if (a.symb <= b.symb) return true;
        //else return false
        else return false;
    }
    //creating a operator with two arguments
    //both are instances of the symbol field
    public static bool operator >=(myClass a, myClass b)
    {
        //if the first char filed is higher by value then the second
        //return true
        if (a.symb >= b.symb) return true;
        //else return false
        else return false;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating 3 instances
        myClass A = new myClass('A');
        myClass B = new myClass('B');
        myClass C = new myClass('C');

        //comparing the character filed of the object
        //with the operator <= and >=
        //and displaying the result
        WriteLine("A<=B дава {0}", A <= B);
        WriteLine("A>=B дава {0}", A >= B);
        WriteLine("A<=C дава {0}", A <= C);
        WriteLine("A>=C дава {0}", A >= C);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
