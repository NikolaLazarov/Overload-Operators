using static System.Console;
class myClass
{
    public int num;
    public string txt = "";
    public myClass(int a, string b)
    {
        num = a;
        txt = b;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override bool Equals(Object a)
    {
        myClass y1 = (myClass)a;
        if (num == y1.num && txt == y1.txt) return true;
        else return false;
    }
    public static bool operator ==(myClass a, myClass b)
    {
        return a.Equals(b);
    }
    public static bool operator !=(myClass a, myClass b)
    {
        return !a.Equals(b);
    }
    public static bool operator >(myClass a, myClass b)
    {
        if (a.txt.Length > b.txt.Length) return true;
        else return false;
    }
    public static bool operator <(myClass a, myClass b)
    {
        if (a.txt.Length < b.txt.Length) return true;
        else return false;
    }
    public static bool operator >=(myClass a, myClass b)
    {
        if (a.num >= b.num) return true;
        else return false;
    }
    public static bool operator <=(myClass a, myClass b)
    {
        if (a.num <= b.num) return true;
        else return false;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass(7, "Motorcycle");
        myClass B = new myClass(3, "Motorbike");

        WriteLine("A==B: {0}", A == B);
        WriteLine("A!=B: {0}", A != B);
        WriteLine("A>B: {0}", A > B);
        WriteLine("A<B: {0}", A < B);
        WriteLine("A>=B: {0}", A >= B);
        WriteLine("A<=B: {0}", A <= B);

        WriteLine(A.GetHashCode());
        WriteLine(B.GetHashCode());


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
