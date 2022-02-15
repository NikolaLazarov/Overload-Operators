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
        return num;
    }
    public override bool Equals(Object a)
    {
        myClass y1 = (myClass)a;
        if (num == y1.num && txt == y1.txt) return true;
        else return false;
    }

}
public class Program
{
    public static void Main(string[] args)
    {

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}