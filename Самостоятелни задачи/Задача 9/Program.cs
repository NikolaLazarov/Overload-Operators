using static System.Console;
class myClass
{
    public int numb;
    public myClass(int a)
    {
        numb = a;
    }
    public static int operator +(myClass a, myClass b)
    {
        return a.numb += b.numb;
    }
    public static int operator -(myClass a, myClass b)
    {
        return a.numb -= b.numb;
    }
    public static int operator *(myClass a, myClass b)
    {
        return a.numb *= b.numb;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass(9);
        myClass B = new myClass(7);

        myClass a = new myClass(A + B);
        WriteLine("A + B = {0}", a.numb);
        myClass b = new myClass(A - B);
        WriteLine("A - B = {0}", b.numb);
        myClass c = new myClass(A * B);
        WriteLine("A * B = {0}", c.numb);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}