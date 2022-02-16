using static System.Console;
class myClass
{
    public int num;
    public myClass(int a)
    {
        num = a;
    }
    public static bool operator true(myClass a)
    {
        switch (a.num)
        {
            case 2:
            case 3:
            case 5:
            case 7:
                return true;
            default:
                return false;
        }
    }
    public static bool operator false(myClass a)
    {
        switch (a.num)
        {
            case < 1:
            case > 10:
                return false;
            default:
                return true;
        }
    }
    public static myClass operator &(myClass a, myClass b)
    {
        if (a) return b;
        else return a;
    }
    public static myClass operator |(myClass a, myClass b)
    {
        if (a) return a;
        else return b;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass(1);
        myClass B = new myClass(2);
        myClass C = new myClass(5);
        myClass D = new myClass(11);

        WriteLine((A && B).num);
        WriteLine((B && A).num);
        WriteLine((A && C).num);
        WriteLine((C && A).num);
        WriteLine((A && D).num);
        WriteLine((D && A).num);

        WriteLine((A || B).num);
        WriteLine((B || A).num);
        WriteLine((A || C).num);
        WriteLine((C || A).num);
        WriteLine((A || D).num);
        WriteLine((D || A).num);


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}