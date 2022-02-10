using static System.Console;
//creating a new class
class Alpha{
    //creating a new number variable
    public int code;
    //creating a constructor with one argument
    public Alpha(int n){
        //assigning the original variables value to arguments
        code = n;
    }
}
//creating a new class
class Bravo{
    //creating a new number variable
    public int code;
    //creating a constructor with one argument
    public Bravo(int n){
        //assigning the original variables value to arguments
        code = n;
    }
    //creating a new constructor with two arguments
    //both being a instance of Bravo
    public static bool operator ==(Bravo a, Bravo b){
        //return the result of the comparison
        return a.code == b.code;
    }
    //creating a new constructor with two arguments
    //both being a instance of Bravo
    public static bool operator !=(Bravo a, Bravo b){
        //return the opposite result of the comparison
        return !(a == b);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating 3 objects
        Alpha A1 = new Alpha(100);
        Alpha A2 = new Alpha(100);
        Alpha A3 = new Alpha(200);

        //displaying the comparison between the objects
        WriteLine("A1==A2 дава {0}",A1==A2);
        WriteLine("A1!=A2 дава {0}",A1!=A2);
        WriteLine("A1==A3 дава {0}",A1==A3);
        WriteLine("A1!=A3 дава {0}",A1!=A3);

        //creating 3 objects
        Bravo B1 =  new Bravo(100);
        Bravo B2 = new Bravo(100);
        Bravo B3 = new Bravo(200);

        //displaying the comparison between the objects
        WriteLine("B1==B2 дава {0}",B1==B2);
        WriteLine("B1!=B2 дава {0}",B1!=B2);
        WriteLine("B1==B3 дава {0}",B1==B3);
        WriteLine("B1!=B3 дава {0}",B1!=B3);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}