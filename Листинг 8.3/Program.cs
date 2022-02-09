using static System.Console;
class myData
{
    private int code;
    private char symb;
    private string text;
    public myData(int n, char s, string t)
    {
        code = n;
        symb = s;
        text = t;
    }
    public override string ToString()
    {
        string txt = "Полета на обекта:\n";
        txt += "Числово поле: " + code + "\n";
        txt += "Символно поле: \'" + symb + "\' \n";
        txt += "Текстово поле: \"" + text + "\" \n";
        txt += "-----------------------------";
        return txt;
    }
    public static myData operator +(myData obj, int n)
    {
        return new myData(+obj + n, -obj, ~obj);
    }
    public static myData operator -(myData obj, int n)
    {
        return new myData(+obj - n, -obj, ~obj);
    }
    public static int operator +(int n, myData obj)
    {
        return n + (+obj);
    }
    public static int operator -(int n, myData obj)
    {
        return n - (+obj);
    }
    public static myData operator +(myData obj, string t)
    {
        return new myData(+obj, -obj, t);
    }
    public static string operator ~(myData obj)
    {
        return obj.text;
    }
    public static int operator +(myData obj)
    {
        return obj.code;
    }
    public static char operator -(myData obj)
    {
        return obj.symb;
    }
    public static char operator >>(myData obj, int k)
    {
        return (~obj)[k];
    }
    public static char operator <<(myData obj, int k)
    {
        return (~obj)[(~obj).Length - k - 1];
    }
    public static myData operator ^(myData a, myData b)
    {
        string txt = ~a + " & " + ~b;
        return new myData(+a, -b, txt);
    }
    public static myData operator ++(myData obj)
    {
        obj.code += 10;
        return obj;
    }
    public static myData operator --(myData obj)
    {
        obj.code -= 10;
        return obj;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myData A = new myData(100, 'A', "Alpha");
        myData B = new myData(200, 'B', "Beta");

        myData C = A ^ B;
        WriteLine(A);
        WriteLine(B);
        WriteLine(C);

        C = B ^ A;
        WriteLine(C);

        int n = +A;
        char s = -A;
        string t = ~A;

        WriteLine("Обект А: полета {0}, \'{1}\' и \"{2}\"\n", n, s, t);

        A++;
        WriteLine(A);

        WriteLine(++A);

        WriteLine(--B);
        --B;
        WriteLine(B);

        C = A + 1000;
        WriteLine(C);
        C = A - 100;
        WriteLine(C);

        WriteLine("Сума и разлика: {0} и {1}\n", 2000 + A, 1000 - A);

        C = A + "Charlie";
        WriteLine(C);

        for (int i = 0; i < (~C).Length; i++)
        {
            Write((C >> i) + " ");
        }
        WriteLine();

        for (int i = 0; i < (~C).Length; i++)
        {
            Write((C << i) + " ");
        }
        WriteLine();

        t = "Обект С. " + C;
        WriteLine(t);


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
