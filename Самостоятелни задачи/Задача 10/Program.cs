using static System.Console;
class myClass
{
    public char symb;
    public myClass(char a)
    {
        symb = a;
    }
    public static String operator +(myClass a, myClass b)
    {
        String str = "";
        str += a.symb;
        str += b.symb;
        return str;
    }
    public static int operator -(myClass a, myClass b)
    {
        int n = (int)a.symb - (int)b.symb;
        return n;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass('H');
        myClass B = new myClass('Q');

        WriteLine("A + B = {0}", A + B);
        WriteLine("A - B = {0}", A - B);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}