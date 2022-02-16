using static System.Console;
class myClass
{
    public string text;
    public myClass(string a)
    {
        text = a;
    }
    public static implicit operator int(myClass a)
    {
        int n = a.text.Length;
        return n;
    }
    public static implicit operator char(myClass a)
    {
        char s = a.text[0];
        return s;
    }
    public static explicit operator myClass(int a)
    {
        string txt = "A";
        for (int i = 1; i < a; i++)
        {
            txt += 'A';
        }
        return new myClass(txt);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass("Umbrella");

        int a = (int)A;
        WriteLine(a);

        char b = (char)A;
        WriteLine(b);

        myClass B = (myClass)a;
        WriteLine(B.text);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}