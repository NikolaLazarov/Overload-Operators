using static System.Console;
class myClass
{
    public int num;
    public char symb;
    public myClass(int a, char b)
    {
        num = a;
        symb = b;
    }
    public static bool operator true(myClass a)
    {
        if (a.num > (int)a.symb)
        {
            if (a.num - (int)a.symb > 10) return true;
            else return false;
        }
        else
        {
            if ((int)a.symb - a.num > 10) return true;
            else return false;
        }
    }
    public static bool operator false(myClass a)
    {
        if (a) return false;
        else return true;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass(60, 'A');
        myClass B = new myClass(70, 'w');

        if (A) { WriteLine(true); }
        else { WriteLine(false); }

        if (B) { WriteLine(true); }
        else { WriteLine(false); }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}