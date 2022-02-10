using static System.Console;
//creating new class
class myClass
{
    //creating a number variable
    public int code;
    //creating a character variable
    public char symb;
    //creating a constructor with two arguments
    //a number one and a character one
    public myClass(int n, char s)
    {
        //assigning the original variables values to the arguments
        code = n;
        symb = s;
    }
    //pre-defining a GetHashCode method
    public override int GetHashCode()
    {
        //return the result of calculation
        return code ^ symb;
    }
    //pre-defining an Equals method with a object as argument
    public override bool Equals(Object obj)
    {
        //creating a new class variable
        //assinging its value to the arguments value as a references to myClass
        myClass t = (myClass)obj;
        //the original variables values are the same as the new ones 
        //return true
        if (code == t.code && symb == t.symb) return true;
        //else return false
        else return false;
    }
    //creating a operator with two object as arguments
    public static bool operator ==(myClass a, myClass b)
    {
        //return the result of the method equals
        //using Equals() on a with b as reference
        return a.Equals(b);
    }
    //creating a operator with two object as arguments
    public static bool operator !=(myClass a, myClass b)
    {
        //returns the opposite of the == operator
        return !(a == b);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //creating object of myClass
        myClass A = new myClass(100, 'A');
        myClass B = new myClass(100, 'B');
        myClass C = new myClass(200, 'C');
        myClass D = new myClass(100, 'A');

        //displaying the HashCode of the objects
        WriteLine("Хеш-код A: {0}", A.GetHashCode());
        WriteLine("Хеш-код B: {0}", B.GetHashCode());
        WriteLine("Хеш-код C: {0}", C.GetHashCode());
        WriteLine("Хеш-код D: {0}", D.GetHashCode());

        //displaying the comparison between the objects
        WriteLine("A==B дава {0}", A == B);
        WriteLine("A!=B дава {0}", A != B);
        WriteLine("A==C дава {0}", A == C);
        WriteLine("A!=C дава {0}", A != C);
        WriteLine("A==D дава {0}", A == D);
        WriteLine("A!=D дава {0}", A != D);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}