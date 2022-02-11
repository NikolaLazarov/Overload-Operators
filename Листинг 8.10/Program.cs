using System;
using static System.Console;

namespace Листинг_8._10
{
    class myClass
    {
        public int code;
        public char symb;
        public string text;
        public myClass(int code, char symb, string text)
        {
            this.code = code;
            this.symb = symb;
            this.text = text;
        }
        public override String ToString()
        {
            String txt = "Полетата на обекта:\n";
            txt += "Числово поле: " + code + "\n";
            txt += "Символно поле: " + symb + "\n";
            txt += "Текстово поле: " + text + "\n";
            txt += "----------------------";
            return txt;
        }
        public static explicit operator String(myClass obj)
        {
            return obj.text;
        }
        public static implicit operator int(myClass obj)
        {
            return obj.code;
        }
        public static implicit operator char(myClass obj)
        {
            return obj.symb;
        }
        public static implicit operator myClass(int n)
        {
            myClass t = new myClass(n, 'B', "Bravo");
            return t;
        }
        public static explicit operator myClass(char s)
        {
            return new myClass(300, s, "Charlie");
        }
        public static implicit operator myClass(String t)
        {
            return new myClass(t.Length, t[0], t);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass A = new myClass(100, 'A', "Alpha";
            WriteLine("Обект А. " + A);

            myClass B = 200;
            WriteLine("Обект B. " + B);

            myClass C = (myClass)'C';
            WriteLine("Обект C. " + C);

            myClass D = "Делта";
            WriteLine("Обект D. " + D);

            WriteLine("Още веднъж полетата на обкет A:");
            WriteLine("Число: " + (int)A);
            WriteLine("Символ: " + (char)A);
            WriteLine("Текст: " + (String)A + "\n");

            WriteLine("Различни операции:");
            int n = 0;
            n = A + B;
            WriteLine("Стойност A+B=" + n);
            char s = B;
            WriteLine("Символ: " + s);

            WriteLine("Число: " + (int)(myClass)"Echo");

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
