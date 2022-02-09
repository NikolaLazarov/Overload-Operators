using static System.Console;
class myClass
{
    public char symb;
    public myClass(char s)
    {
        symb = s;
    }
    public static bool operator <=(myClass a, myClass b)
    {
        if (a.symb <= b.symb) return true;
        else return false;
    }
    public static bool operator >=(myClass a, myClass b)
    {
        if (a.symb >= b.symb) return true;
        else return false;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass('A');
        myClass B = new myClass('B');
        myClass C = new myClass('C');

        WriteLine("A<=B дава {0}", A <= B);
        WriteLine("A>=B дава {0}", A >= B);
        WriteLine("A<=C дава {0}", A <= C);
        WriteLine("A>=C дава {0}", A >= C);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
