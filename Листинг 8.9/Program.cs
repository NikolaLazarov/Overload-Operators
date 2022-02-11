using static System.Console;
//creating new class
class myClass
{
    //creating new class character variable
    public char symb;
    //creating constructor with character variable as argument
    public myClass(char s)
    {
        //assigning the variables values to the arguments
        symb = s;
    }
    //creating new operator with one object as argument
    public static bool operator true(myClass obj)
    {
        //checks if the objects char fields are equal to one of the cases
        switch (obj.symb)
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
            case 'Y':
            //if it is return true
                return true;
            default:
            //if not return false
                return false;
        }
    }
    //creating new operator with object as argument
    public static bool operator false(myClass obj)
    {
        //if the statement is true,return the objects character filed as "Y";
        if (obj) return obj.symb == 'Y';
        //else return false
        else return false;
    }
    //creating a new operator with 2 objects as arguments
    public static myClass operator &(myClass a, myClass b)
    {
        //if the first object is true
        //return the second object
        if (a) return b;
        //else return the first one
        else return a;
    }
    //creating new object with 2 objects as arguments
    public static myClass operator |(myClass a, myClass b)
    {
        //if the first object is true
        //return the first object
        if (a) return a;
        //else return the second one
        else return b;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating 4 objects
        myClass A = new myClass('A');
        myClass B = new myClass('B');
        myClass E = new myClass('E');
        myClass Y = new myClass('Y');

        //displaying the comparisons between them
        //(A&&B)-tests A to see if its a lie
        //if false execute the operation A&B
        //if true return A
        WriteLine("Израз А&&B: {0}", (A && B).symb);
        WriteLine("Израз B&&A: {0}", (B && A).symb);
        WriteLine("Израз A&&E: {0}", (A && E).symb);
        WriteLine("Израз E&&A: {0}", (E && A).symb);
        WriteLine("Израз A&&Y: {0}", (A && Y).symb);
        WriteLine("Израз Y&&A: {0}", (Y && A).symb);

        //(A||B)-test to see if its a lie
        //if false execute the operation A|B
        //if true return A
        WriteLine("Израз A||B: {0}", (A || B).symb);
        WriteLine("Израз B||A: {0}", (B || A).symb);
        WriteLine("Израз A||E: {0}", (A || E).symb);
        WriteLine("Израз E||A: {0}", (E || A).symb);
        WriteLine("Израз A||Y: {0}", (A || Y).symb);
        WriteLine("Израз Y||A: {0}", (Y || A).symb);


        WriteLine("Press any key to close the");
        ReadKey(true);
    }
}