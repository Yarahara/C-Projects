// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args)
    {
        string s1 = "abc";
        string s2 = "123.45";
        Console.WriteLine($"String 1 {s1} String 2 {s2}");

        double s2i = double.Parse(s2);
        Console.WriteLine(s2i);

        int a = 2;
        int b = 19;
        string c = a.ToString() + "." + b.ToString();
        Console.WriteLine(c);

        double rn = 678.9;
        double d = 180d/(b-1);
        Console.WriteLine(d);

        Console.WriteLine("What is the oz in ml? ");
        string oz = Console.ReadLine();
        double dOz = double.Parse(oz);
        double ml = dOz * 29.5735;
        Console.WriteLine($"{ml} ml is {dOz} oz");

        Console.WriteLine("What is the ml in oz? ");
        string ml2 = Console.ReadLine();
        ml = double.Parse(ml2);
        dOz = ml / 29.5735;
        Console.WriteLine($"{ml} ml is {dOz} oz");


    }
}