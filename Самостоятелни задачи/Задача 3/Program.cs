using static System.Console;
class myClass
{
    public double a;
    public double b;
    private double sum;
    public myClass(int a, int b)
    {
        this.a = a;
        this.b = b;
        sum = Math.Pow(a, 2) + Math.Pow(b, 2);
    }
    public static bool operator >(myClass a, myClass b)
    {
        if (a.sum > b.sum) return true;
        else return false;
    }
    public static bool operator <(myClass a, myClass b)
    {
        if (a.sum < b.sum) return true;
        else return false;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass(4, 7);
        myClass B = new myClass(5, 9);

        bool isTrue1 = A > B;
        bool isTrue2 = A < B;

        WriteLine("A>B: {0}", isTrue1);
        WriteLine("A<B: {0}", isTrue2);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}