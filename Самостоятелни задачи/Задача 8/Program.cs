using static System.Console;
class myClass
{
    public int[] arrNums = new int[0];
    public myClass(int[] a)
    {
        Array.Resize(ref arrNums, a.Length);
        for (int i = 0; i < arrNums.Length; i++)
        {
            arrNums[i] = a[i];
        }
    }
    public static string operator ~(myClass a)
    {
        string str = "";
        for (int i = 0; i < a.arrNums.Length; i++)
        {
            str += a.arrNums[i] + " ";
        }
        return str;
    }
    public static implicit operator string(myClass a)
    {
        string txt = "";
        for (int i = 0; i < a.arrNums.Length; i++)
        {
            txt += a.arrNums[i];
        }
        return txt;
    }
    public static implicit operator int(myClass a)
    {
        int n = 0;
        for (int i = 0; i < a.arrNums.Length; i++)
        {
            n += a.arrNums[i];
        }
        return n;
    }
    public static explicit operator myClass(int j)
    {
        int[] A = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] B = new int[A.Length - j];
        for (int i = 0; i < B.Length; i++)
        {
            B[i] = A[i];
        }
        myClass T = new myClass(B);
        return T;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
        myClass A = new myClass(a);
        WriteLine(~A);

        string b = (string)A;
        WriteLine(b);

        int c = (int)A;
        WriteLine(c);

        myClass B = (myClass)4;
        WriteLine(~B);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}