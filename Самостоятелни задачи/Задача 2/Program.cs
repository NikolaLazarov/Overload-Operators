using static System.Console;
class myClass
{
    public int lht;
    public int[] arrNums = new int[0];
    public myClass(int a)
    {
        lht = a;
        Array.Resize(ref arrNums, a);
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
        foreach (int i in Nums)
        {
            arr += i + " ";
        }
        return arr;
    }
    public static myClass operator ++(myClass a)
    {
        return new myClass(a.lht++);
    }
    public static myClass operator --(myClass a)
    {
        return new myClass(a.lht--);
    }
    public static string operator ~(myClass a)
    {
        string arr = "";
        foreach (int i in a.arrNums)
        {
            arr += i + " ";
        }
        return arr;
    }
    public static myClass operator +(myClass a, myClass b)
    {
        if (a.lht > b.lht)
        {
            myClass jh = new myClass(a.lht);
            Array.Resize(ref b.arrNums, a.lht);
            for (int i = 0; i < a.arrNums.Length; i++)
            {
                jh.arrNums[i] = a.arrNums[i] + b.arrNums[i];
                return new myClass(jh.arrNums);
            }
        }
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