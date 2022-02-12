using System;
using static System.Console;

namespace Листинг_8._10
{
    //creating new class
    class myClass
    {
        //creating a number class variable 
        public int code;
        //creating a character class variable
        public char symb;
        //creating a text class variable
        public string text;
        //creating a constructor with three arguments
        public myClass(int code, char symb, string text)
        {
            //assinging each class variables value to the corresponding argument
            this.code = code;
            this.symb = symb;
            this.text = text;
        }
        //overloading a ToString method
        //displays all class variables
        public override String ToString()
        {
            String txt = "Полетата на обекта:\n";
            txt += "Числово поле: " + code + "\n";
            txt += "Символно поле: " + symb + "\n";
            txt += "Текстово поле: " + text + "\n";
            txt += "----------------------";
            return txt;
        }
        //creating a String operator method with an class objects as argument
        public static explicit operator String(myClass obj)
        {
            //return the text field of the object
            return obj.text;
        }
        //creating a int operator method with an class objects as argument
        public static implicit operator int(myClass obj)
        {
            //return the number field of the object
            return obj.code;
        }
        //creating a char operator method with a class objects as argument
        public static implicit operator char(myClass obj)
        {
            //return the character field of the object
            return obj.symb;
        }
        //creating a myClass operator method with a number as argument
        public static implicit operator myClass(int n)
        {
            //returns a new myClass object
            //the number field is replaced with the arguments
            myClass t = new myClass(n, 'B', "Bravo");
            return t;
        }
        //creating a myClass operator method with a number as argument
        public static explicit operator myClass(char s)
        {
            //returns a new myClass object
            //the character field is replaced with the arguments
            return new myClass(300, s, "Charlie");
        }
        //creating a myClass operator method with a number as argument
        public static implicit operator myClass(String t)
        {
            //returns new class object
            //the number filed is the length of the argument
            //the character field is the first index the arguments
            //the text filed is the argument
            return new myClass(t.Length, t[0], t);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new class object
            myClass A = new myClass(100, 'A', "Alpha");
            //displaying the object
            WriteLine("Обект А. " + A);

            //creating a new class variable with reference to a myClass operator
            myClass B = 200;
            //displaying the object
            WriteLine("Обект B. " + B);

            //creating a new class variable with 'C' being converted to myClass
            myClass C = (myClass)'C';
            //displaying the object
            WriteLine("Обект C. " + C);

            //creating a new class variable with reference to a myClass operator
            myClass D = "Делта";
            //displaying the object
            WriteLine("Обект D. " + D);

            //displaying one more time the fields of the object A with conversions
            WriteLine("Още веднъж полетата на обкет A:");
            WriteLine("Число: " + (int)A);
            WriteLine("Символ: " + (char)A);
            WriteLine("Текст: " + (String)A + "\n");

            //displaying other operations
            WriteLine("Различни операции:");
            //creating a number variable
            int n = 0;
            //assinging its value to the summation of the number fields of the object via conversion to int
            n = A + B;
            //displaying the summation
            WriteLine("Стойност A+B=" + n);
            //creating a character variable and assinging its value to the objects character field via conversion to char
            char s = B;
            //displaying the variable
            WriteLine("Символ: " + s);

            //displaying the number of symbols in the word "Echo" with conversion to an object
            //then extracting the number filed of the object via conversion to int
            WriteLine("Число: " + (int)(myClass)"Echo");

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
