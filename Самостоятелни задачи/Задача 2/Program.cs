using static System.Console;
class myClass
{
    public int number;
    public int[] arrNums = new int[0];
    public myClass(int a)
    {
        number = a;
        Array.Resize(ref arrNums, a);
        for (int i = 0; i < arrNums.Length; i++)
        {
            arrNums[i] = 0;
        }
    }
    int[] Nums = new int[0];
    public myClass(int[] arr)
    {
        Array.Resize(ref Nums, arr.Length);
        for (int i = 0; i < Nums.Length; i++)
        {
            Nums[i] = arr[i];
        }
    }
    public override string ToString()
    {
        string arr = "";
        foreach (int i in arrNums)
        {
            arr += i;
        }
        return arr;
    }
    public static myClass operator ++(myClass a)
    {
        return new myClass(a.number + 1);
    }
    public static myClass operator --(myClass a)
    {
        return new myClass(a.number - 1);
    }
    public static string operator ~(myClass a)
    {
        string s = "";
        foreach (int i in a.Nums)
        {
            s += i;
        }
        return s;
    }
    public static myClass operator +(myClass a, int b)
    {
        Array.Resize(ref a.arrNums, a.arrNums.Length + 1);
        a.arrNums[a.arrNums.Length - 1] = b;
        return new myClass(a.arrNums);
    }
    public static myClass operator +(int a, myClass b)
    {
        Array.Resize(ref b.arrNums, b.arrNums.Length + 1);
        b.arrNums[0] = a;
        return new myClass(b.arrNums);
    }
    public static myClass operator +(myClass a, myClass b)
    {
        myClass jh = new myClass(a.number);
        if (a.number > b.number)
        {
            Array.Resize(ref b.arrNums, a.number);
            for (int i = 0; i < a.arrNums.Length; i++)
            {
                jh.arrNums[i] = a.arrNums[i] + b.arrNums[i];
            }
        }
        return new myClass(jh.arrNums);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass(4);
        myClass B = new myClass(3);

        A++;
        WriteLine(A);

        B--;
        WriteLine(B);

        WriteLine(~(A + B));

        WriteLine(~(A + 3));
        WriteLine(~(3 + B));

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
