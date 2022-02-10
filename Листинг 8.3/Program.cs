using static System.Console;
//creating a new class
class myData
{
    //creating three private variables
    //a number variable
    private int code;
    //a character variable
    private char symb;
    //a string variable
    private string text;
    //creating a constructor with the three variables as arguments
    public myData(int n, char s, string t)
    {
        //assigning the variables values to the values of the arguments
        code = n;
        symb = s;
        text = t;
    }
    //pre-defining a toString function
    public override string ToString()
    {
        //creating a string variable
        //assigning the variables to the values of the three private variables
        //and text showing each variables value
        string txt = "Полета на обекта:\n";
        txt += "Числово поле: " + code + "\n";
        txt += "Символно поле: \'" + symb + "\' \n";
        txt += "Текстово поле: \"" + text + "\" \n";
        txt += "-----------------------------";
        //return the variable
        return txt;
    }
    //creating a operator with two arguments that summates 
    //the number field and the number argument
    //an object and a number
    public static myData operator +(myData obj, int n)
    {
        //returning a new object
        return new myData(+obj + n, -obj, ~obj);
    }
    //creating a operator with two arguments that subtracts 
    //number argument form the number field
    public static myData operator -(myData obj, int n)
    {
        //returning the a new object
        return new myData(+obj - n, -obj, ~obj);
    }
    //creating a operator with two arguments that summates 
    //a number and the number filed of the object
    public static int operator +(int n, myData obj)
    {
        //returning a number variable
        return n + (+obj);
    }
    //creating a operator with two arguments that subtracts 
    //a number field form a number
    public static int operator -(int n, myData obj)
    {
        //returning a number variable
        return n - (+obj);
    }
    //creating a operator with two arguments
    //the string field of the object is replaced with a string
    public static myData operator +(myData obj, string t)
    {
        //returning a new object
        return new myData(+obj, -obj, t);
    }
    //creating a operator with one argument
    //it returns the string field of the object
    public static string operator ~(myData obj)
    {
        //returning the string field of the object
        return obj.text;
    }
    //creating a operator with one argument
    //it returns the number field of the object
    public static int operator +(myData obj)
    {
        //returning the number field of the object
        return obj.code;
    }
    //creating a operator with one argument
    //it returns the character field of the object
    public static char operator -(myData obj)
    {
        //returning the character field of the object
        return obj.symb;
    }
    //creating a operator with two arguments
    //it returns the index(as the number argument) of the string field of the object
    public static char operator >>(myData obj, int k)
    {
        //returning the index of the string field
        return (~obj)[k];
    }
    //creating a operator with two arguments
    //it returns the index(as the number argument) of the string field of the object
    //but backwords
    public static char operator <<(myData obj, int k)
    {
        ////returning the index of the string field but backwords
        return (~obj)[(~obj).Length - k - 1];
    }
    //creating a operator with two arguments
    //it merges the two objects fields
    public static myData operator ^(myData a, myData b)
    {
        //creating a string variable and assigning it to the summation
        //of the string fields of the objects
        string txt = ~a + " & " + ~b;
        //returning a constructor of the class with
        //the first argument of the constructor is the first objects number variable
        //the second argument of the constructor is the second objects character variable
        //the third argument of the constructor is the string variable we created
        //returning the object
        return new myData(+a, -b, txt);
    }
    //creating a operator with one argument
    //it adds 10 to the number field of the object
    public static myData operator ++(myData obj)
    {
        //adds 10 to the number field of the object
        obj.code += 10;
        //returns the number field
        return obj;
    }
    //creating a operator with one argument
    //it subtracts 10 form the number field of the object
    public static myData operator --(myData obj)
    {
        //subtracts 10 form the number field of the object
        obj.code -= 10;
        //return the number field
        return obj;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating two instances
        myData A = new myData(100, 'A', "Alpha");
        myData B = new myData(200, 'B', "Beta");

        //creating a third instances and assigning it to ^ operation between A and B
        myData C = A ^ B;
        //displaying the instances
        WriteLine(A);
        WriteLine(B);
        WriteLine(C);

        //creating a third instances and assigning it to ^ operation between B and A
        C = B ^ A;
        //displaying the instances
        WriteLine(C);

        //creating and assigning variables to the fileds of the first objects
        int n = +A;
        char s = -A;
        string t = ~A;

        //displaying them
        WriteLine("Обект А: полета {0}, \'{1}\' и \"{2}\"\n", n, s, t);

        //using the ++ operator on the object A
        A++;
        //displaying the object
        WriteLine(A);

        //using the ++ operator on the object A again and displaying it
        WriteLine(++A);

        //using the -- operator on the object B and displaying it
        WriteLine(--B);
        //using the -- operator on the object again
        --B;
        //displaying it
        WriteLine(B);

        //using the operator + with an number filed and an number variable
        //assinging it to the object C
        C = A + 1000;
        //displaying it
        WriteLine(C);
        //using the operator - with an number filed and an number variable
        //assinging it to the object C
        C = A - 100;
        //displaying it
        WriteLine(C);

        //using the operator + with a number variable and a number filed
        //using the operator - with a number variable and a number filed
        //diplating it
        WriteLine("Сума и разлика: {0} и {1}\n", 2000 + A, 1000 - A);

        //using the operator + with a object and a string
        //assinging it
        C = A + "Charlie";
        //displaying it
        WriteLine(C);

        //displaying each of the indexes of the string field of the object C
        //with spaces between the symbols
        for (int i = 0; i < (~C).Length; i++)
        {
            Write((C >> i) + " ");
        }
        WriteLine();

        //displaying each of the indexes of the string field of the object C but backwords
        //with spaces between the symbols
        for (int i = 0; i < (~C).Length; i++)
        {
            Write((C << i) + " ");
        }
        WriteLine();

        //using the operator + with a string value and a string field
        //assinging it to the variable
        t = "Обект С. " + C;
        //displaying the variable
        WriteLine(t);


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
