using static System.Console;
//creating new class
class myClass
{
    //creating new number class variable
    public int code;
    //creating constructor with one argument
    public myClass(int n)
    {
        //assigning the number variable to the argument
        code = n;
    }
    //creating a operator with a class object as argument
    public static bool operator true(myClass obj)
    {
        //if the objects number field is higher or equal to 5
        //the operator returns true
        if (obj.code >= 5) return true;
        //else the operator returns false
        else return false;
    }
    //creating a operator with a class object as argument
    public static bool operator false(myClass obj)
    {
        //if the operator "true"s value is true
        //the operator returns false
        if (obj) return false;
        //else the operator returns true
        return true;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new object
        myClass obj = new myClass(10);
        //creating a loop
        //while the operator "true" returns true
        //execute the code in the loop
        while (obj)
        {
            //displaying the objects number field plus a blank space
            Write(obj.code + " ");
            //subtracts one from the number field
            obj.code--;
        }
        //displaying new line
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}